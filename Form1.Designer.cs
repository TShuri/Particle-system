namespace ParticleSystem
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
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbDirection = new System.Windows.Forms.TrackBar();
            this.lblDirection = new System.Windows.Forms.Label();
            this.tbTeleport = new System.Windows.Forms.TrackBar();
            this.rbEmitter = new System.Windows.Forms.RadioButton();
            this.rbTeleport = new System.Windows.Forms.RadioButton();
            this.tbDirectionTP = new System.Windows.Forms.TrackBar();
            this.cbSnow = new System.Windows.Forms.CheckBox();
            this.rbColorDit = new System.Windows.Forms.RadioButton();
            this.tbColorDit = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonColor = new System.Windows.Forms.Button();
            this.rbCounter = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTeleport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirectionTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbColorDit)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(12, 12);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(1190, 709);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseDoubleClick);
            this.picDisplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseDown);
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbDirection
            // 
            this.tbDirection.Location = new System.Drawing.Point(12, 727);
            this.tbDirection.Maximum = 359;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(205, 69);
            this.tbDirection.TabIndex = 1;
            this.tbDirection.Scroll += new System.EventHandler(this.tbDirection_Scroll);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(223, 727);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(22, 25);
            this.lblDirection.TabIndex = 2;
            this.lblDirection.Text = "0";
            // 
            // tbTeleport
            // 
            this.tbTeleport.Location = new System.Drawing.Point(304, 727);
            this.tbTeleport.Maximum = 100;
            this.tbTeleport.Name = "tbTeleport";
            this.tbTeleport.Size = new System.Drawing.Size(156, 69);
            this.tbTeleport.TabIndex = 3;
            this.tbTeleport.Scroll += new System.EventHandler(this.tbTeleport_Scroll);
            // 
            // rbEmitter
            // 
            this.rbEmitter.AutoSize = true;
            this.rbEmitter.Checked = true;
            this.rbEmitter.Location = new System.Drawing.Point(799, 727);
            this.rbEmitter.Name = "rbEmitter";
            this.rbEmitter.Size = new System.Drawing.Size(93, 29);
            this.rbEmitter.TabIndex = 4;
            this.rbEmitter.TabStop = true;
            this.rbEmitter.Text = "Emitter";
            this.rbEmitter.UseVisualStyleBackColor = true;
            // 
            // rbTeleport
            // 
            this.rbTeleport.AutoSize = true;
            this.rbTeleport.Location = new System.Drawing.Point(898, 727);
            this.rbTeleport.Name = "rbTeleport";
            this.rbTeleport.Size = new System.Drawing.Size(100, 29);
            this.rbTeleport.TabIndex = 5;
            this.rbTeleport.Text = "Teleport";
            this.rbTeleport.UseVisualStyleBackColor = true;
            // 
            // tbDirectionTP
            // 
            this.tbDirectionTP.Location = new System.Drawing.Point(304, 771);
            this.tbDirectionTP.Maximum = 359;
            this.tbDirectionTP.Name = "tbDirectionTP";
            this.tbDirectionTP.Size = new System.Drawing.Size(156, 69);
            this.tbDirectionTP.TabIndex = 6;
            this.tbDirectionTP.Scroll += new System.EventHandler(this.tbDirectionTP_Scroll);
            // 
            // cbSnow
            // 
            this.cbSnow.AutoSize = true;
            this.cbSnow.Checked = true;
            this.cbSnow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSnow.Location = new System.Drawing.Point(799, 762);
            this.cbSnow.Name = "cbSnow";
            this.cbSnow.Size = new System.Drawing.Size(82, 29);
            this.cbSnow.TabIndex = 7;
            this.cbSnow.Text = "Snow";
            this.cbSnow.UseVisualStyleBackColor = true;
            this.cbSnow.CheckedChanged += new System.EventHandler(this.cbSnow_CheckedChanged);
            // 
            // rbColorDit
            // 
            this.rbColorDit.AutoSize = true;
            this.rbColorDit.Location = new System.Drawing.Point(1004, 727);
            this.rbColorDit.Name = "rbColorDit";
            this.rbColorDit.Size = new System.Drawing.Size(108, 29);
            this.rbColorDit.TabIndex = 8;
            this.rbColorDit.TabStop = true;
            this.rbColorDit.Text = "Color Dit";
            this.rbColorDit.UseVisualStyleBackColor = true;
            // 
            // tbColorDit
            // 
            this.tbColorDit.Location = new System.Drawing.Point(500, 727);
            this.tbColorDit.Maximum = 200;
            this.tbColorDit.Name = "tbColorDit";
            this.tbColorDit.Size = new System.Drawing.Size(156, 69);
            this.tbColorDit.TabIndex = 9;
            this.tbColorDit.Scroll += new System.EventHandler(this.tbColorDit_Scroll);
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(662, 727);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(30, 30);
            this.buttonColor.TabIndex = 11;
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // rbCounter
            // 
            this.rbCounter.AutoSize = true;
            this.rbCounter.Location = new System.Drawing.Point(1118, 728);
            this.rbCounter.Name = "rbCounter";
            this.rbCounter.Size = new System.Drawing.Size(100, 29);
            this.rbCounter.TabIndex = 12;
            this.rbCounter.TabStop = true;
            this.rbCounter.Text = "Counter";
            this.rbCounter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 881);
            this.Controls.Add(this.rbCounter);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.tbColorDit);
            this.Controls.Add(this.rbColorDit);
            this.Controls.Add(this.cbSnow);
            this.Controls.Add(this.tbDirectionTP);
            this.Controls.Add(this.rbTeleport);
            this.Controls.Add(this.rbEmitter);
            this.Controls.Add(this.tbTeleport);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.tbDirection);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTeleport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirectionTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbColorDit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private TrackBar tbDirection;
        private Label lblDirection;
        private TrackBar tbTeleport;
        private RadioButton rbEmitter;
        private RadioButton rbTeleport;
        private TrackBar tbDirectionTP;
        private CheckBox cbSnow;
        private RadioButton rbColorDit;
        private TrackBar tbColorDit;
        private ColorDialog colorDialog1;
        private Button buttonColor;
        private RadioButton rbCounter;
    }
}