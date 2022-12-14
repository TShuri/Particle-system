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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTeleport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirectionTP)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(12, 12);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(1296, 751);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseClick);
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
            this.tbDirection.Location = new System.Drawing.Point(12, 769);
            this.tbDirection.Maximum = 359;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(205, 69);
            this.tbDirection.TabIndex = 1;
            this.tbDirection.Scroll += new System.EventHandler(this.tbDirection_Scroll);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(223, 769);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(0, 25);
            this.lblDirection.TabIndex = 2;
            // 
            // tbTeleport
            // 
            this.tbTeleport.Location = new System.Drawing.Point(304, 769);
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
            this.rbEmitter.Location = new System.Drawing.Point(500, 769);
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
            this.rbTeleport.Location = new System.Drawing.Point(599, 769);
            this.rbTeleport.Name = "rbTeleport";
            this.rbTeleport.Size = new System.Drawing.Size(100, 29);
            this.rbTeleport.TabIndex = 5;
            this.rbTeleport.Text = "Teleport";
            this.rbTeleport.UseVisualStyleBackColor = true;
            // 
            // tbDirectionTP
            // 
            this.tbDirectionTP.Location = new System.Drawing.Point(304, 813);
            this.tbDirectionTP.Maximum = 359;
            this.tbDirectionTP.Name = "tbDirectionTP";
            this.tbDirectionTP.Size = new System.Drawing.Size(156, 69);
            this.tbDirectionTP.TabIndex = 6;
            this.tbDirectionTP.Scroll += new System.EventHandler(this.tbDirectionTP_Scroll);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(705, 770);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 29);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Snow";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 881);
            this.Controls.Add(this.checkBox1);
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
        private CheckBox checkBox1;
    }
}