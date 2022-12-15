﻿namespace ParticleSystem
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
            this.lblEmitter = new System.Windows.Forms.Label();
            this.lblEmitterDirection = new System.Windows.Forms.Label();
            this.lblEmitterParticles = new System.Windows.Forms.Label();
            this.tbParticlesCount = new System.Windows.Forms.TrackBar();
            this.lblParticles = new System.Windows.Forms.Label();
            this.lblTeleport = new System.Windows.Forms.Label();
            this.lblRadiusTeleport = new System.Windows.Forms.Label();
            this.lblOutDirection = new System.Windows.Forms.Label();
            this.lblRadiusTP = new System.Windows.Forms.Label();
            this.lblDirectionTP = new System.Windows.Forms.Label();
            this.lblColorDit = new System.Windows.Forms.Label();
            this.lblRadiusColorDIt = new System.Windows.Forms.Label();
            this.lblRadiusCD = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblControl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTeleport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirectionTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbColorDit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbParticlesCount)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(12, 12);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(1190, 673);
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
            this.tbDirection.Location = new System.Drawing.Point(237, 763);
            this.tbDirection.Maximum = 359;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(205, 69);
            this.tbDirection.TabIndex = 1;
            this.tbDirection.Scroll += new System.EventHandler(this.tbDirection_Scroll);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(448, 763);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(22, 25);
            this.lblDirection.TabIndex = 2;
            this.lblDirection.Text = "0";
            // 
            // tbTeleport
            // 
            this.tbTeleport.Location = new System.Drawing.Point(517, 763);
            this.tbTeleport.Maximum = 100;
            this.tbTeleport.Name = "tbTeleport";
            this.tbTeleport.Size = new System.Drawing.Size(205, 69);
            this.tbTeleport.TabIndex = 3;
            this.tbTeleport.Value = 100;
            this.tbTeleport.Scroll += new System.EventHandler(this.tbTeleport_Scroll);
            // 
            // rbEmitter
            // 
            this.rbEmitter.AutoSize = true;
            this.rbEmitter.Checked = true;
            this.rbEmitter.Location = new System.Drawing.Point(12, 744);
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
            this.rbTeleport.Location = new System.Drawing.Point(12, 854);
            this.rbTeleport.Name = "rbTeleport";
            this.rbTeleport.Size = new System.Drawing.Size(100, 29);
            this.rbTeleport.TabIndex = 5;
            this.rbTeleport.Text = "Teleport";
            this.rbTeleport.UseVisualStyleBackColor = true;
            // 
            // tbDirectionTP
            // 
            this.tbDirectionTP.Location = new System.Drawing.Point(517, 838);
            this.tbDirectionTP.Maximum = 359;
            this.tbDirectionTP.Name = "tbDirectionTP";
            this.tbDirectionTP.Size = new System.Drawing.Size(205, 69);
            this.tbDirectionTP.TabIndex = 6;
            this.tbDirectionTP.Scroll += new System.EventHandler(this.tbDirectionTP_Scroll);
            // 
            // cbSnow
            // 
            this.cbSnow.AutoSize = true;
            this.cbSnow.Checked = true;
            this.cbSnow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSnow.Location = new System.Drawing.Point(1120, 701);
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
            this.rbColorDit.Location = new System.Drawing.Point(12, 784);
            this.rbColorDit.Name = "rbColorDit";
            this.rbColorDit.Size = new System.Drawing.Size(108, 29);
            this.rbColorDit.TabIndex = 8;
            this.rbColorDit.TabStop = true;
            this.rbColorDit.Text = "Color Dit";
            this.rbColorDit.UseVisualStyleBackColor = true;
            // 
            // tbColorDit
            // 
            this.tbColorDit.Location = new System.Drawing.Point(790, 763);
            this.tbColorDit.Maximum = 200;
            this.tbColorDit.Name = "tbColorDit";
            this.tbColorDit.Size = new System.Drawing.Size(193, 69);
            this.tbColorDit.TabIndex = 9;
            this.tbColorDit.Value = 200;
            this.tbColorDit.Scroll += new System.EventHandler(this.tbColorDit_Scroll);
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(873, 822);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(30, 30);
            this.buttonColor.TabIndex = 11;
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // rbCounter
            // 
            this.rbCounter.AutoSize = true;
            this.rbCounter.Location = new System.Drawing.Point(12, 819);
            this.rbCounter.Name = "rbCounter";
            this.rbCounter.Size = new System.Drawing.Size(100, 29);
            this.rbCounter.TabIndex = 12;
            this.rbCounter.TabStop = true;
            this.rbCounter.Text = "Counter";
            this.rbCounter.UseVisualStyleBackColor = true;
            // 
            // lblEmitter
            // 
            this.lblEmitter.AutoSize = true;
            this.lblEmitter.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmitter.Location = new System.Drawing.Point(303, 700);
            this.lblEmitter.Name = "lblEmitter";
            this.lblEmitter.Size = new System.Drawing.Size(88, 28);
            this.lblEmitter.TabIndex = 13;
            this.lblEmitter.Text = "Emitter";
            // 
            // lblEmitterDirection
            // 
            this.lblEmitterDirection.AutoSize = true;
            this.lblEmitterDirection.Location = new System.Drawing.Point(249, 735);
            this.lblEmitterDirection.Name = "lblEmitterDirection";
            this.lblEmitterDirection.Size = new System.Drawing.Size(83, 25);
            this.lblEmitterDirection.TabIndex = 14;
            this.lblEmitterDirection.Text = "Direction";
            // 
            // lblEmitterParticles
            // 
            this.lblEmitterParticles.AutoSize = true;
            this.lblEmitterParticles.Location = new System.Drawing.Point(249, 810);
            this.lblEmitterParticles.Name = "lblEmitterParticles";
            this.lblEmitterParticles.Size = new System.Drawing.Size(75, 25);
            this.lblEmitterParticles.TabIndex = 15;
            this.lblEmitterParticles.Text = "Particles";
            // 
            // tbParticlesCount
            // 
            this.tbParticlesCount.Location = new System.Drawing.Point(237, 838);
            this.tbParticlesCount.Name = "tbParticlesCount";
            this.tbParticlesCount.Size = new System.Drawing.Size(205, 69);
            this.tbParticlesCount.TabIndex = 16;
            this.tbParticlesCount.Value = 10;
            this.tbParticlesCount.Scroll += new System.EventHandler(this.tbParticlesCount_Scroll);
            // 
            // lblParticles
            // 
            this.lblParticles.AutoSize = true;
            this.lblParticles.Location = new System.Drawing.Point(448, 838);
            this.lblParticles.Name = "lblParticles";
            this.lblParticles.Size = new System.Drawing.Size(32, 25);
            this.lblParticles.TabIndex = 17;
            this.lblParticles.Text = "10";
            // 
            // lblTeleport
            // 
            this.lblTeleport.AutoSize = true;
            this.lblTeleport.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTeleport.Location = new System.Drawing.Point(590, 700);
            this.lblTeleport.Name = "lblTeleport";
            this.lblTeleport.Size = new System.Drawing.Size(101, 28);
            this.lblTeleport.TabIndex = 18;
            this.lblTeleport.Text = "Teleport";
            // 
            // lblRadiusTeleport
            // 
            this.lblRadiusTeleport.AutoSize = true;
            this.lblRadiusTeleport.Location = new System.Drawing.Point(529, 735);
            this.lblRadiusTeleport.Name = "lblRadiusTeleport";
            this.lblRadiusTeleport.Size = new System.Drawing.Size(65, 25);
            this.lblRadiusTeleport.TabIndex = 19;
            this.lblRadiusTeleport.Text = "Radius";
            // 
            // lblOutDirection
            // 
            this.lblOutDirection.AutoSize = true;
            this.lblOutDirection.Location = new System.Drawing.Point(529, 810);
            this.lblOutDirection.Name = "lblOutDirection";
            this.lblOutDirection.Size = new System.Drawing.Size(116, 25);
            this.lblOutDirection.TabIndex = 20;
            this.lblOutDirection.Text = "Out direction";
            // 
            // lblRadiusTP
            // 
            this.lblRadiusTP.AutoSize = true;
            this.lblRadiusTP.Location = new System.Drawing.Point(728, 763);
            this.lblRadiusTP.Name = "lblRadiusTP";
            this.lblRadiusTP.Size = new System.Drawing.Size(42, 25);
            this.lblRadiusTP.TabIndex = 21;
            this.lblRadiusTP.Text = "100";
            // 
            // lblDirectionTP
            // 
            this.lblDirectionTP.AutoSize = true;
            this.lblDirectionTP.Location = new System.Drawing.Point(728, 838);
            this.lblDirectionTP.Name = "lblDirectionTP";
            this.lblDirectionTP.Size = new System.Drawing.Size(22, 25);
            this.lblDirectionTP.TabIndex = 22;
            this.lblDirectionTP.Text = "0";
            // 
            // lblColorDit
            // 
            this.lblColorDit.AutoSize = true;
            this.lblColorDit.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblColorDit.Location = new System.Drawing.Point(841, 700);
            this.lblColorDit.Name = "lblColorDit";
            this.lblColorDit.Size = new System.Drawing.Size(104, 28);
            this.lblColorDit.TabIndex = 23;
            this.lblColorDit.Text = "Color dit";
            // 
            // lblRadiusColorDIt
            // 
            this.lblRadiusColorDIt.AutoSize = true;
            this.lblRadiusColorDIt.Location = new System.Drawing.Point(799, 735);
            this.lblRadiusColorDIt.Name = "lblRadiusColorDIt";
            this.lblRadiusColorDIt.Size = new System.Drawing.Size(65, 25);
            this.lblRadiusColorDIt.TabIndex = 24;
            this.lblRadiusColorDIt.Text = "Radius";
            // 
            // lblRadiusCD
            // 
            this.lblRadiusCD.AutoSize = true;
            this.lblRadiusCD.Location = new System.Drawing.Point(989, 763);
            this.lblRadiusCD.Name = "lblRadiusCD";
            this.lblRadiusCD.Size = new System.Drawing.Size(42, 25);
            this.lblRadiusCD.TabIndex = 25;
            this.lblRadiusCD.Text = "100";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(799, 822);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(55, 25);
            this.lblColor.TabIndex = 26;
            this.lblColor.Text = "Color";
            // 
            // lblControl
            // 
            this.lblControl.AutoSize = true;
            this.lblControl.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblControl.Location = new System.Drawing.Point(12, 700);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(91, 28);
            this.lblControl.TabIndex = 27;
            this.lblControl.Text = "Control";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 917);
            this.Controls.Add(this.lblControl);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblRadiusCD);
            this.Controls.Add(this.lblRadiusColorDIt);
            this.Controls.Add(this.lblColorDit);
            this.Controls.Add(this.lblDirectionTP);
            this.Controls.Add(this.lblRadiusTP);
            this.Controls.Add(this.lblOutDirection);
            this.Controls.Add(this.lblRadiusTeleport);
            this.Controls.Add(this.lblTeleport);
            this.Controls.Add(this.lblParticles);
            this.Controls.Add(this.tbParticlesCount);
            this.Controls.Add(this.lblEmitterParticles);
            this.Controls.Add(this.lblEmitterDirection);
            this.Controls.Add(this.lblEmitter);
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
            ((System.ComponentModel.ISupportInitialize)(this.tbParticlesCount)).EndInit();
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
        private Label lblEmitter;
        private Label lblEmitterDirection;
        private Label lblEmitterParticles;
        private TrackBar tbParticlesCount;
        private Label lblParticles;
        private Label lblTeleport;
        private Label lblRadiusTeleport;
        private Label lblOutDirection;
        private Label lblRadiusTP;
        private Label lblDirectionTP;
        private Label lblColorDit;
        private Label lblRadiusColorDIt;
        private Label lblRadiusCD;
        private Label lblColor;
        private Label lblControl;
    }
}