namespace ExifRenamer
{
    partial class Form1
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
            this.btnRun = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumDeltaSecond = new System.Windows.Forms.NumericUpDown();
            this.NumDeltaMinute = new System.Windows.Forms.NumericUpDown();
            this.NumDeltaHour = new System.Windows.Forms.NumericUpDown();
            this.NumDeltaDay = new System.Windows.Forms.NumericUpDown();
            this.labelDay = new System.Windows.Forms.Label();
            this.dropFormat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumDeltaSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDeltaMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDeltaHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDeltaDay)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(291, 12);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(180, 41);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Rename";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(258, 20);
            this.txtPath.TabIndex = 1;
            this.txtPath.Text = "C:\\Photos";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 210);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(840, 249);
            this.txtLog.TabIndex = 2;
            this.txtLog.Text = "LOG";
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(291, 59);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(180, 41);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NumDeltaSecond);
            this.groupBox1.Controls.Add(this.NumDeltaMinute);
            this.groupBox1.Controls.Add(this.NumDeltaHour);
            this.groupBox1.Controls.Add(this.NumDeltaDay);
            this.groupBox1.Controls.Add(this.labelDay);
            this.groupBox1.Location = new System.Drawing.Point(690, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 126);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DateTime Delta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Seconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Minutes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hours";
            // 
            // NumDeltaSecond
            // 
            this.NumDeltaSecond.Location = new System.Drawing.Point(80, 94);
            this.NumDeltaSecond.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumDeltaSecond.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.NumDeltaSecond.Name = "NumDeltaSecond";
            this.NumDeltaSecond.Size = new System.Drawing.Size(50, 20);
            this.NumDeltaSecond.TabIndex = 10;
            // 
            // NumDeltaMinute
            // 
            this.NumDeltaMinute.Location = new System.Drawing.Point(80, 68);
            this.NumDeltaMinute.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumDeltaMinute.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.NumDeltaMinute.Name = "NumDeltaMinute";
            this.NumDeltaMinute.Size = new System.Drawing.Size(50, 20);
            this.NumDeltaMinute.TabIndex = 9;
            // 
            // NumDeltaHour
            // 
            this.NumDeltaHour.Location = new System.Drawing.Point(80, 44);
            this.NumDeltaHour.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumDeltaHour.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.NumDeltaHour.Name = "NumDeltaHour";
            this.NumDeltaHour.Size = new System.Drawing.Size(50, 20);
            this.NumDeltaHour.TabIndex = 7;
            // 
            // NumDeltaDay
            // 
            this.NumDeltaDay.Location = new System.Drawing.Point(80, 18);
            this.NumDeltaDay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumDeltaDay.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.NumDeltaDay.Name = "NumDeltaDay";
            this.NumDeltaDay.Size = new System.Drawing.Size(50, 20);
            this.NumDeltaDay.TabIndex = 6;
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(6, 20);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(31, 13);
            this.labelDay.TabIndex = 8;
            this.labelDay.Text = "Days";
            // 
            // dropFormat
            // 
            this.dropFormat.FormattingEnabled = true;
            this.dropFormat.Items.AddRange(new object[] {
            "yyyy-MM-dd HH.mm.ss_",
            "yyyy-MM-dd_HHmmss_"});
            this.dropFormat.Location = new System.Drawing.Point(291, 146);
            this.dropFormat.Name = "dropFormat";
            this.dropFormat.Size = new System.Drawing.Size(180, 21);
            this.dropFormat.TabIndex = 6;
            this.dropFormat.Text = "yyyy-MM-dd_HHmmss_";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Prefix";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 466);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(868, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 488);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dropFormat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnRun);
            this.Name = "Form1";
            this.Text = "ExifRenamer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumDeltaSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDeltaMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDeltaHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDeltaDay)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown NumDeltaHour;
        private System.Windows.Forms.NumericUpDown NumDeltaDay;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.NumericUpDown NumDeltaSecond;
        private System.Windows.Forms.NumericUpDown NumDeltaMinute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dropFormat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}

