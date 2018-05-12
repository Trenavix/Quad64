namespace Quad64.src.Forms
{
    partial class EditWarp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditWarp));
            this.cancelButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.panel_warp_controls = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.w_warpToID = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.w_selectLevel = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.w_areaID = new System.Windows.Forms.NumericUpDown();
            this.w_warpFrom = new System.Windows.Forms.NumericUpDown();
            this.panel_instWarp_controls = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iw_tz = new System.Windows.Forms.NumericUpDown();
            this.iw_ty = new System.Windows.Forms.NumericUpDown();
            this.iw_tx = new System.Windows.Forms.NumericUpDown();
            this.iw_area = new System.Windows.Forms.NumericUpDown();
            this.iw_trigger = new System.Windows.Forms.NumericUpDown();
            this.panel_warp_controls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.w_warpToID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.w_areaID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.w_warpFrom)).BeginInit();
            this.panel_instWarp_controls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iw_tz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iw_ty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iw_tx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iw_area)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iw_trigger)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(413, 354);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(183, 50);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectButton.Location = new System.Drawing.Point(150, 356);
            this.selectButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(183, 50);
            this.selectButton.TabIndex = 3;
            this.selectButton.Text = "Save";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // panel_warp_controls
            // 
            this.panel_warp_controls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_warp_controls.BackColor = System.Drawing.Color.DarkGray;
            this.panel_warp_controls.Controls.Add(this.label7);
            this.panel_warp_controls.Controls.Add(this.w_warpToID);
            this.panel_warp_controls.Controls.Add(this.label6);
            this.panel_warp_controls.Controls.Add(this.w_selectLevel);
            this.panel_warp_controls.Controls.Add(this.label9);
            this.panel_warp_controls.Controls.Add(this.label10);
            this.panel_warp_controls.Controls.Add(this.w_areaID);
            this.panel_warp_controls.Controls.Add(this.w_warpFrom);
            this.panel_warp_controls.Location = new System.Drawing.Point(0, 0);
            this.panel_warp_controls.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel_warp_controls.Name = "panel_warp_controls";
            this.panel_warp_controls.Size = new System.Drawing.Size(746, 338);
            this.panel_warp_controls.TabIndex = 5;
            this.panel_warp_controls.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 218);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 33);
            this.label7.TabIndex = 20;
            this.label7.Text = "To Warp ID:";
            // 
            // w_warpToID
            // 
            this.w_warpToID.Location = new System.Drawing.Point(246, 216);
            this.w_warpToID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.w_warpToID.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.w_warpToID.Name = "w_warpToID";
            this.w_warpToID.Size = new System.Drawing.Size(136, 29);
            this.w_warpToID.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 33);
            this.label6.TabIndex = 18;
            this.label6.Text = "To Level:";
            // 
            // w_selectLevel
            // 
            this.w_selectLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.w_selectLevel.FormattingEnabled = true;
            this.w_selectLevel.Location = new System.Drawing.Point(246, 116);
            this.w_selectLevel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.w_selectLevel.Name = "w_selectLevel";
            this.w_selectLevel.Size = new System.Drawing.Size(475, 32);
            this.w_selectLevel.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(86, 168);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 33);
            this.label9.TabIndex = 16;
            this.label9.Text = "To Area:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(189, 46);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 33);
            this.label10.TabIndex = 15;
            this.label10.Text = "Warp ID: ";
            // 
            // w_areaID
            // 
            this.w_areaID.Location = new System.Drawing.Point(246, 168);
            this.w_areaID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.w_areaID.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.w_areaID.Name = "w_areaID";
            this.w_areaID.Size = new System.Drawing.Size(136, 29);
            this.w_areaID.TabIndex = 11;
            // 
            // w_warpFrom
            // 
            this.w_warpFrom.Location = new System.Drawing.Point(365, 48);
            this.w_warpFrom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.w_warpFrom.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.w_warpFrom.Name = "w_warpFrom";
            this.w_warpFrom.Size = new System.Drawing.Size(182, 29);
            this.w_warpFrom.TabIndex = 10;
            // 
            // panel_instWarp_controls
            // 
            this.panel_instWarp_controls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_instWarp_controls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel_instWarp_controls.Controls.Add(this.label5);
            this.panel_instWarp_controls.Controls.Add(this.label4);
            this.panel_instWarp_controls.Controls.Add(this.label3);
            this.panel_instWarp_controls.Controls.Add(this.label2);
            this.panel_instWarp_controls.Controls.Add(this.label1);
            this.panel_instWarp_controls.Controls.Add(this.iw_tz);
            this.panel_instWarp_controls.Controls.Add(this.iw_ty);
            this.panel_instWarp_controls.Controls.Add(this.iw_tx);
            this.panel_instWarp_controls.Controls.Add(this.iw_area);
            this.panel_instWarp_controls.Controls.Add(this.iw_trigger);
            this.panel_instWarp_controls.Location = new System.Drawing.Point(0, 0);
            this.panel_instWarp_controls.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel_instWarp_controls.Name = "panel_instWarp_controls";
            this.panel_instWarp_controls.Size = new System.Drawing.Size(746, 338);
            this.panel_instWarp_controls.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(57, 242);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 33);
            this.label5.TabIndex = 9;
            this.label5.Text = "Teleport on Z axis: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(57, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "Teleport on Y axis: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(57, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Teleport on X axis: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(238, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "To Area: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(189, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Trigger ID: ";
            // 
            // iw_tz
            // 
            this.iw_tz.BackColor = System.Drawing.Color.Gray;
            this.iw_tz.ForeColor = System.Drawing.Color.White;
            this.iw_tz.Location = new System.Drawing.Point(414, 242);
            this.iw_tz.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.iw_tz.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.iw_tz.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.iw_tz.Name = "iw_tz";
            this.iw_tz.Size = new System.Drawing.Size(182, 29);
            this.iw_tz.TabIndex = 4;
            // 
            // iw_ty
            // 
            this.iw_ty.BackColor = System.Drawing.Color.Gray;
            this.iw_ty.ForeColor = System.Drawing.Color.White;
            this.iw_ty.Location = new System.Drawing.Point(414, 194);
            this.iw_ty.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.iw_ty.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.iw_ty.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.iw_ty.Name = "iw_ty";
            this.iw_ty.Size = new System.Drawing.Size(182, 29);
            this.iw_ty.TabIndex = 3;
            // 
            // iw_tx
            // 
            this.iw_tx.BackColor = System.Drawing.Color.Gray;
            this.iw_tx.ForeColor = System.Drawing.Color.White;
            this.iw_tx.Location = new System.Drawing.Point(414, 146);
            this.iw_tx.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.iw_tx.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.iw_tx.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.iw_tx.Name = "iw_tx";
            this.iw_tx.Size = new System.Drawing.Size(182, 29);
            this.iw_tx.TabIndex = 2;
            // 
            // iw_area
            // 
            this.iw_area.BackColor = System.Drawing.Color.Gray;
            this.iw_area.ForeColor = System.Drawing.Color.White;
            this.iw_area.Location = new System.Drawing.Point(414, 98);
            this.iw_area.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.iw_area.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.iw_area.Name = "iw_area";
            this.iw_area.Size = new System.Drawing.Size(182, 29);
            this.iw_area.TabIndex = 1;
            // 
            // iw_trigger
            // 
            this.iw_trigger.BackColor = System.Drawing.Color.Gray;
            this.iw_trigger.ForeColor = System.Drawing.Color.White;
            this.iw_trigger.Location = new System.Drawing.Point(414, 50);
            this.iw_trigger.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.iw_trigger.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.iw_trigger.Name = "iw_trigger";
            this.iw_trigger.Size = new System.Drawing.Size(182, 29);
            this.iw_trigger.TabIndex = 0;
            // 
            // EditWarp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(746, 421);
            this.Controls.Add(this.panel_instWarp_controls);
            this.Controls.Add(this.panel_warp_controls);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.selectButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditWarp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Warp";
            this.Load += new System.EventHandler(this.EditWarp_Load);
            this.panel_warp_controls.ResumeLayout(false);
            this.panel_warp_controls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.w_warpToID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.w_areaID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.w_warpFrom)).EndInit();
            this.panel_instWarp_controls.ResumeLayout(false);
            this.panel_instWarp_controls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iw_tz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iw_ty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iw_tx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iw_area)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iw_trigger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Panel panel_warp_controls;
        private System.Windows.Forms.Panel panel_instWarp_controls;
        private System.Windows.Forms.NumericUpDown iw_trigger;
        private System.Windows.Forms.NumericUpDown iw_area;
        private System.Windows.Forms.NumericUpDown iw_tz;
        private System.Windows.Forms.NumericUpDown iw_ty;
        private System.Windows.Forms.NumericUpDown iw_tx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown w_areaID;
        private System.Windows.Forms.NumericUpDown w_warpFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox w_selectLevel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown w_warpToID;
    }
}