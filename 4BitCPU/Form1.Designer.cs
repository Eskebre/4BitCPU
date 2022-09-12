namespace _4BitCPU
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lbxRAM = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrTick = new System.Windows.Forms.Timer(this.components);
            this.rtbProgram = new System.Windows.Forms.RichTextBox();
            this.btnTick = new System.Windows.Forms.Button();
            this.tbrClockSpeed = new System.Windows.Forms.TrackBar();
            this.cbxClockEnabled = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbrClockSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(503, 17);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 24);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lbxRAM
            // 
            this.lbxRAM.FormattingEnabled = true;
            this.lbxRAM.ItemHeight = 15;
            this.lbxRAM.Items.AddRange(new object[] {
            "0",
            "0",
            "0",
            "0",
            "0",
            "0",
            "0",
            "0",
            "0",
            "0",
            "0",
            "0",
            "0",
            "0",
            "0",
            "0"});
            this.lbxRAM.Location = new System.Drawing.Point(12, 12);
            this.lbxRAM.Name = "lbxRAM";
            this.lbxRAM.Size = new System.Drawing.Size(120, 244);
            this.lbxRAM.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // tmrTick
            // 
            this.tmrTick.Interval = 50;
            this.tmrTick.Tick += new System.EventHandler(this.tmrTick_Tick);
            // 
            // rtbProgram
            // 
            this.rtbProgram.DetectUrls = false;
            this.rtbProgram.Location = new System.Drawing.Point(276, 17);
            this.rtbProgram.MaxLength = 512;
            this.rtbProgram.Multiline = false;
            this.rtbProgram.Name = "rtbProgram";
            this.rtbProgram.Size = new System.Drawing.Size(221, 143);
            this.rtbProgram.TabIndex = 3;
            this.rtbProgram.Text = "";
            // 
            // btnTick
            // 
            this.btnTick.Location = new System.Drawing.Point(12, 262);
            this.btnTick.Name = "btnTick";
            this.btnTick.Size = new System.Drawing.Size(75, 23);
            this.btnTick.TabIndex = 4;
            this.btnTick.Text = "Tick";
            this.btnTick.UseVisualStyleBackColor = true;
            this.btnTick.Click += new System.EventHandler(this.tmrTick_Tick);
            // 
            // tbrClockSpeed
            // 
            this.tbrClockSpeed.Location = new System.Drawing.Point(12, 321);
            this.tbrClockSpeed.Maximum = 500;
            this.tbrClockSpeed.Minimum = 50;
            this.tbrClockSpeed.Name = "tbrClockSpeed";
            this.tbrClockSpeed.Size = new System.Drawing.Size(193, 45);
            this.tbrClockSpeed.TabIndex = 5;
            this.tbrClockSpeed.Value = 50;
            this.tbrClockSpeed.Scroll += new System.EventHandler(this.tbrClockSpeed_Scroll);
            // 
            // cbxClockEnabled
            // 
            this.cbxClockEnabled.AutoSize = true;
            this.cbxClockEnabled.Location = new System.Drawing.Point(22, 360);
            this.cbxClockEnabled.Name = "cbxClockEnabled";
            this.cbxClockEnabled.Size = new System.Drawing.Size(56, 19);
            this.cbxClockEnabled.TabIndex = 6;
            this.cbxClockEnabled.Text = "Clock";
            this.cbxClockEnabled.UseVisualStyleBackColor = true;
            this.cbxClockEnabled.CheckedChanged += new System.EventHandler(this.cbxClockEnabled_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxClockEnabled);
            this.Controls.Add(this.tbrClockSpeed);
            this.Controls.Add(this.btnTick);
            this.Controls.Add(this.rtbProgram);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxRAM);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Nibble";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbrClockSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLoad;
        private ListBox lbxRAM;
        private Label label1;
        private System.Windows.Forms.Timer tmrTick;
        private RichTextBox rtbProgram;
        private Button btnTick;
        private TrackBar tbrClockSpeed;
        private CheckBox cbxClockEnabled;
    }
}