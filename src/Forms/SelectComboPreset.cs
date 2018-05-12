﻿using Quad64.src.JSON;
using Quad64.src.LevelInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Quad64.src.Forms
{
    partial class SelectComboPreset : Form
    {
        public bool ClickedSelect { get; set; }
        public ObjectComboEntry ReturnObjectCombo { get; set; }
        public PresetMacroEntry ReturnPresetMacro { get; set; }

        private Level level;

        // 0 = objects, 1 = macro objects, 2 = special (8), 3 = special (10), 4 = special (12)
        private int listType = -1; 
        public SelectComboPreset(Level level, int listType, string columnText, Color columnTextColor)
        {
            InitializeComponent();
            this.level = level;
            this.listType = listType;
            listView1.Columns[0].Text = columnText;
            textBrush = new SolidBrush(columnTextColor);
        }

        private void LoadSpecialList(List<PresetMacroEntry> specialList, bool useFilter)
        {
            List<ushort> presetsTaken = new List<ushort>();
            foreach (PresetMacroEntry entry in specialList)
            {
                if (!presetsTaken.Contains(entry.PresetID))
                {
                    if (level.ModelIDs.ContainsKey(entry.ModelID))
                    {
                        uint modelAddress = level.ModelIDs[entry.ModelID].GeoDataSegAddress;
                        int oce_index = -1;
                        ObjectComboEntry oce = level.getObjectComboFromData(entry.ModelID, modelAddress, entry.Behavior, out oce_index);
                        if (oce_index > -1)
                        {
                            string displayName = "(" + entry.PresetID + ") " + oce.Name;
                            if (!useFilter)
                                listView1.Items.Add(displayName);
                            else
                            {
                                if (displayName.ToUpper().Contains(textBox_filter.Text.ToUpper()))
                                    listView1.Items.Add(displayName);
                            }
                            //int index = listView1.Items.Count - 1;
                        }
                    }
                    presetsTaken.Add(entry.PresetID);
                }
            }
            col2 = Color.FromArgb(95, 100, 100);
        }

        private void SelectComboPreset_Load(object sender, EventArgs e)
        {
            switch (listType)
            {
                case 0:
                    foreach (ObjectComboEntry entry in level.LevelObjectCombos)
                    {
                        listView1.Items.Add(entry.Name);
                        listView1.Items[listView1.Items.Count - 1].Tag = new object[]
                            {
                                entry.ModelID,
                                entry.Behavior
                            };
                        int index = listView1.Items.Count - 1;
                    }
                    col2 = Color.FromArgb(95, 100, 100);
                    break;
                case 1:
                    foreach (PresetMacroEntry entry in level.MacroObjectPresets)
                    {
                        if (level.ModelIDs.ContainsKey(entry.ModelID))
                        {
                            uint modelAddress = level.ModelIDs[entry.ModelID].GeoDataSegAddress;
                            int oce_index = -1;
                            ObjectComboEntry oce = level.getObjectComboFromData(entry.ModelID, modelAddress, entry.Behavior, out oce_index);
                            if (oce_index > -1)
                            {
                                string displayName = "(" + entry.PresetID.ToString() + ") " + oce.Name;
                                displayName += " {" + entry.BehaviorParameter1;
                                displayName += ", " + entry.BehaviorParameter2 + "}";
                                listView1.Items.Add(displayName);
                                int index = listView1.Items.Count - 1;
                            }
                        }
                    }
                    col2 = Color.FromArgb(75, 100, 100);
                    break;
                case 2:
                    LoadSpecialList(level.SpecialObjectPresets_8, false);
                    break;
                case 3:
                    LoadSpecialList(level.SpecialObjectPresets_10, false);
                    break;
                case 4:
                    LoadSpecialList(level.SpecialObjectPresets_12, false);
                    break;

            }
            
            if (listView1.Items.Count > 0)
            {
                listView1.Items[0].Selected = true;
                listView1.Select();
            }
        }

        private Color col1 = Color.FromArgb(95, 100, 100);
        private Color col2 = Color.FromArgb(75, 100, 100);
        private Color highlight = Color.FromArgb(5, 50, 100);
        private void listView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            // If this item is the selected item
            if (e.Item.Selected)
            {
                e.Item.ForeColor = Color.FromArgb(224, 224, 224); //lightgrey
                e.Item.BackColor = highlight;
            }
            else
            {
                if (e.ItemIndex % 2 == 0)
                    listView1.Items[e.ItemIndex].BackColor = col1;
                else
                    listView1.Items[e.ItemIndex].BackColor = col2;
            }
            listView1.BackColor = Color.FromArgb(32, 32, 32);
            e.DrawBackground();
            e.DrawText();
        }

        private Font textFont = new Font("Courier New", 10, FontStyle.Bold);
        private Brush textBrush = new SolidBrush(Color.FromArgb(176, 176, 176));
        private Pen bgPen = new Pen(Color.FromArgb(48, 48, 48), 100.0f);
        private Rectangle bgRect = new Rectangle(0, 0, 400, 2);
        private void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            int x = 180 - (TextRenderer.MeasureText(e.Header.Text, textFont).Width/2);
            e.Graphics.DrawRectangle(bgPen, bgRect);
            e.Graphics.DrawString(e.Header.Text, textFont, textBrush, x, 4);
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
        }

        private int getMacroPresetFromLabel(string label)
        {
            return int.Parse(label.Substring(1, label.IndexOf(")")-1));
        }

        private void setReturnFromSpecialName(List<PresetMacroEntry> specialList, string label)
        {
            int presetID = getMacroPresetFromLabel(label);
            foreach (PresetMacroEntry entry in specialList)
            {
                if (entry.PresetID == presetID)
                {
                    ReturnPresetMacro = entry;
                    return;
                }
            }
        }

        private ObjectComboEntry getObjectComboEntryFromName(string name, object tag)
        {
            byte modelID = (byte)((object[])tag)[0];
            uint behavior = (uint)((object[])tag)[1];

            foreach (ObjectComboEntry entry in level.LevelObjectCombos)
            {
                if (entry.Name.Equals(name) && modelID == entry.ModelID && behavior == entry.Behavior)
                {
                    return entry;
                }
            }
            return null;
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            switch (listType)
            {
                case 0:
                    ReturnObjectCombo = getObjectComboEntryFromName(listView1.SelectedItems[0].Text, listView1.SelectedItems[0].Tag);
                    break;
                case 1:
                    ReturnPresetMacro =
                        level.MacroObjectPresets[
                            getMacroPresetFromLabel(listView1.SelectedItems[0].Text) - 0x1F];
                    break;
                case 2:
                    setReturnFromSpecialName(level.SpecialObjectPresets_8, listView1.SelectedItems[0].Text);
                    break;
                case 3:
                    setReturnFromSpecialName(level.SpecialObjectPresets_10, listView1.SelectedItems[0].Text);
                    break;
                case 4:
                    setReturnFromSpecialName(level.SpecialObjectPresets_12, listView1.SelectedItems[0].Text);
                    break;
            }
            ClickedSelect = true;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ClickedSelect = false;
            Close();
        }

        private void textBox_filter_TextChanged(object sender, EventArgs e)
        {
            BeginUpdate(listView1);
            listView1.Items.Clear();
            switch (listType)
            {
                case 0:
                    foreach (ObjectComboEntry entry in level.LevelObjectCombos)
                    {
                        if (entry.Name.ToUpper().Contains(textBox_filter.Text.ToUpper()))
                        {
                            listView1.Items.Add(entry.Name);
                            listView1.Items[listView1.Items.Count - 1].Tag = new object[]
                            {
                                entry.ModelID,
                                entry.Behavior
                            };
                        }
                    }
                    col2 = Color.FromArgb(75, 100, 100);
                    break;
                case 1:
                    foreach (PresetMacroEntry entry in level.MacroObjectPresets)
                    {
                        if (level.ModelIDs.ContainsKey(entry.ModelID))
                        {
                            uint modelAddress = level.ModelIDs[entry.ModelID].GeoDataSegAddress;
                            int oce_index = -1;
                            ObjectComboEntry oce = level.getObjectComboFromData(entry.ModelID, modelAddress, entry.Behavior, out oce_index);
                            if (oce_index > -1)
                            {
                                string displayName = "(" + entry.PresetID.ToString() + ") " + oce.Name;
                                if (displayName.ToUpper().Contains(textBox_filter.Text.ToUpper()))
                                {
                                    displayName += " {" + entry.BehaviorParameter1;
                                    displayName += ", " + entry.BehaviorParameter2 + "}";
                                    listView1.Items.Add(displayName);
                                }
                            }
                        }
                    }
                    col2 = Color.FromArgb(75, 100, 100);
                    break;
                case 2:
                    LoadSpecialList(level.SpecialObjectPresets_8, true);
                    break;
                case 3:
                    LoadSpecialList(level.SpecialObjectPresets_10, true);
                    break;
                case 4:
                    LoadSpecialList(level.SpecialObjectPresets_12, true);
                    break;

            }
            EndUpdate(listView1);
        }
        
        private const int WM_USER = 0x0400;
        private const int EM_SETEVENTMASK = (WM_USER + 69);
        private const int WM_SETREDRAW = 0x0b;
        private IntPtr OldEventMask;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        private void BeginUpdate(ListView lv)
        {
            SendMessage(lv.Handle, WM_SETREDRAW, IntPtr.Zero, IntPtr.Zero);
            OldEventMask = SendMessage(lv.Handle, EM_SETEVENTMASK, IntPtr.Zero, IntPtr.Zero);
        }

        private void EndUpdate(ListView lv)
        {
            SendMessage(lv.Handle, WM_SETREDRAW, (IntPtr)1, IntPtr.Zero);
            SendMessage(lv.Handle, EM_SETEVENTMASK, IntPtr.Zero, OldEventMask);
        }
    }
}
