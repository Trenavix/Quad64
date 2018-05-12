using OpenTK.Graphics.OpenGL;
using Quad64.src.JSON;
using Quad64.src.TestROM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quad64.src.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            tabs.DrawItem += new DrawItemEventHandler(tabs_DrawItem);
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            AddBasicSettings();
            AddAdvancedSettings();
        }

        private TextBox emuPathTextBox;
        private Button setEmuPathButton;
        private CheckBox autoSaveWithEmulatorBox;
        private void AddAdvancedSettings()
        {
            int xOffset = 0, yOffset = 10, SeperatorWidth = Advanced.Width - 6;
            Advanced.Controls.Add(newFancyLabel("Link emulator program", 0,
                yOffset, new Font("Arial", 10, FontStyle.Bold)));
            yOffset += 25;
            addButtonWithTextBox(Advanced, "Browse", Globals.pathToEmulator, true, xOffset, yOffset, Advanced.Width, 
                ref emuPathTextBox, ref setEmuPathButton, OpenEmulatorPath_Click);
            yOffset += 30;
            Advanced.Controls.Add(newCheckBox("Automatically save ROM when launching emulator", xOffset, yOffset, Globals.autoSaveWhenClickEmulator));
            autoSaveWithEmulatorBox = (CheckBox)Advanced.Controls[Advanced.Controls.Count - 1];
        }

        private void addButtonWithTextBox(TabPage page, string buttonText, string textBoxText, bool isTextBoxReadOnly, int x, int y, int screenWidth, ref TextBox box, ref Button button, EventHandler buttonClickEvent)
        {
            button = newButton(buttonText, x, y, buttonClickEvent);
            button.BackColor = Color.FromArgb(224, 224, 224);
            box = newTextBox(textBoxText, isTextBoxReadOnly, x + button.Width, y+1, screenWidth-button.Width-3);
            box.ForeColor = Color.FromArgb(224, 224, 224);
            page.Controls.Add(button);
            page.Controls.Add(box);
        }

        private void OpenEmulatorPath_Click(object sender, EventArgs e)
        {
            LaunchROM.setEmulatorPath();
            emuPathTextBox.Text = Globals.pathToEmulator;
        }
        
        private CheckBox enableWireframe, enableBFculling, drawObjMdls, autoLoadROM;
        private ComboBox renderMap, useHex;
        private void AddBasicSettings()
        {
            int xOffset = 3, yOffset = 5, SeperatorWidth = Basic.Width - 6;

            Basic.Controls.Add(newFancyLabel("Render Settings", 0, 
                yOffset, new Font("Arial", 10, FontStyle.Bold)));
            yOffset += 25;
            Basic.Controls.Add(newCheckBox("Enable wireframe", xOffset, yOffset, Globals.doWireframe));
            enableWireframe = (CheckBox)Basic.Controls[Basic.Controls.Count - 1];
            yOffset += 25;
            Basic.Controls.Add(newCheckBox("Enable backface culling", xOffset, yOffset, Globals.doBackfaceCulling));
            enableBFculling = (CheckBox)Basic.Controls[Basic.Controls.Count - 1];
            yOffset += 25;
            Basic.Controls.Add(newCheckBox("Draw Object Models", xOffset, yOffset, Globals.drawObjectModels));
            drawObjMdls = (CheckBox)Basic.Controls[Basic.Controls.Count - 1];
            yOffset += 30;
            AddComboBoxSetting(Basic, "Render Map: ", 
                new string[] { "Visual Map", "Collision Map" }, 
                xOffset, yOffset, (Globals.renderCollisionMap ? 1 : 0));
            renderMap = (ComboBox)Basic.Controls[Basic.Controls.Count - 1];
            yOffset += 35;
            Basic.Controls.Add(newLineSeparator(xOffset, yOffset, SeperatorWidth));
            yOffset += 10;
            Basic.Controls.Add(newFancyLabel("Editor Settings", 0,
                yOffset, new Font("Arial", 10, FontStyle.Bold)));
            yOffset += 30;
            Basic.Controls.Add(newCheckBox("Automatically load last ROM file", xOffset, yOffset, Globals.autoLoadROMOnStartup));
            autoLoadROM = (CheckBox)Basic.Controls[Basic.Controls.Count - 1];
            yOffset += 30;
            AddComboBoxSetting(Basic, "Use Hexadecimal? ", 
                new string[] { "No (Decimal Only)", "Yes (Signed Hex)", "Yes (Unsigned Hex)" }, 
                xOffset, yOffset, (!Globals.useHexadecimal ? 0 : (Globals.useSignedHex ? 1 : 2)));
            useHex = (ComboBox)Basic.Controls[Basic.Controls.Count - 1];
        }

        private void AddComboBoxSetting(TabPage page, string label, string[] options, int x, int y, int selectedIndex)
        {
            Label cbl = newLabel(label, x, y+3);
            cbl.BackColor = Color.FromArgb(32, 32, 32);
            cbl.ForeColor = Color.FromArgb(224, 224, 224);
            page.Controls.Add(cbl);
            page.Controls.Add(newComboBox(options, x + cbl.Width, y, selectedIndex));
        }

        private Label newLineSeparator(int x, int y, int width)
        {
            Label label = new Label();
            label.AutoSize = false;
            label.Height = 2;
            label.Left = x;
            label.Top = y;
            label.Width = width;
            label.BorderStyle = BorderStyle.FixedSingle;
            label.ForeColor = Color.FromArgb(48, 48, 48);
            label.BackColor = Color.Black;
            label.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            return label;
        }

        private Label newLabel(string text, int x, int y)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = text;
            label.Left = x;
            label.Top = y;
            label.ForeColor = Color.FromArgb(224, 224, 224);
            return label;
        }

        private Label newFancyLabel(string text, int x, int y, Font font)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = text;
            label.Left = x;
            label.Top = y;
            label.Font = font;
            label.ForeColor = Color.FromArgb(224, 224, 244);
            return label;
        }

        private Button newButton(string text, int x, int y, EventHandler clickEvent)
        {
            Button button = new Button();
            button.AutoSize = true;
            button.Text = text;
            button.Left = x;
            button.Top = y;
            button.Click += clickEvent;
            return button;
        }

        private TextBox newTextBox(string text, bool readOnly, int x, int y, int width)
        {
            TextBox box = new TextBox();
            box.Text = text;
            box.Left = x;
            box.Top = y;
            box.ReadOnly = readOnly;
            box.Width = width;
            box.BackColor = Color.FromArgb(64, 64, 64);
            box.ForeColor = Color.FromArgb(224, 224, 244);
            return box;
        }

        private ComboBox newComboBox(string[] options, int x, int y, int selectedIndex)
        {
            ComboBox box = new ComboBox();
            box.Items.AddRange(options);
            box.Left = x;
            box.Top = y;
            box.SelectedIndex = selectedIndex;
            box.TabStop = false;
            box.MouseWheel += new MouseEventHandler(comboBox_MouseWheel);
            box.DropDownStyle = ComboBoxStyle.DropDownList;
            return box;
        }

        private CheckBox newCheckBox(string text, int x, int y, bool isChecked)
        {
            CheckBox box = new CheckBox();
            box.Text = text;
            box.Left = x;
            box.Top = y;
            box.AutoSize = true;
            box.TabStop = false;
            box.Checked = isChecked;
            box.ForeColor = Color.FromArgb(224, 224, 224);
            return box;
        }

        private void updateGlobalSettings()
        {
            Globals.doWireframe = enableWireframe.Checked;
            Globals.drawObjectModels = drawObjMdls.Checked;
            Globals.autoLoadROMOnStartup = autoLoadROM.Checked;
            Globals.doBackfaceCulling = enableBFculling.Checked;
            Globals.renderCollisionMap = (renderMap.SelectedIndex == 1);
            Globals.useHexadecimal = (useHex.SelectedIndex != 0);
            Globals.useSignedHex = (useHex.SelectedIndex == 1);
            Globals.autoSaveWhenClickEmulator = autoSaveWithEmulatorBox.Checked;

            if (Globals.doBackfaceCulling)
                GL.Enable(EnableCap.CullFace);
            else
                GL.Disable(EnableCap.CullFace);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            updateGlobalSettings();
            SettingsFile.SaveGlobalSettings("default");
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Disable scrollwheel with comboBoxes in settings menu
        private void comboBox_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        private void tabs_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage page = tabs.TabPages[e.Index];
            e.Graphics.FillRectangle(new SolidBrush(page.BackColor), e.Bounds);

            Rectangle paddedBounds = e.Bounds;
            int yOffset = (e.State == DrawItemState.Selected) ? -2 : 1;
            paddedBounds.Offset(1, yOffset);
            TextRenderer.DrawText(e.Graphics, page.Text, Font, paddedBounds, Color.FromArgb(224, 224, 224));
        }
    }
}
