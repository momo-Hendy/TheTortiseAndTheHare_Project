namespace TheTortiseAndTheHare_Project
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChangeTColor = new System.Windows.Forms.Button();
            this.btnChangeHColor = new System.Windows.Forms.Button();
            this.rbPictureMode = new System.Windows.Forms.RadioButton();
            this.rbDrawMode = new System.Windows.Forms.RadioButton();
            this.tmrRaceSpeed = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbFast = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbSlow = new System.Windows.Forms.RadioButton();
            this.cdChangeColor = new System.Windows.Forms.ColorDialog();
            this.pbTortoise = new System.Windows.Forms.PictureBox();
            this.pbHare = new System.Windows.Forms.PictureBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTortoise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHare)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(229, 280);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(149, 55);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 250);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(426, 280);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(149, 55);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(655, 280);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(149, 55);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChangeTColor);
            this.groupBox1.Controls.Add(this.btnChangeHColor);
            this.groupBox1.Controls.Add(this.rbPictureMode);
            this.groupBox1.Controls.Add(this.rbDrawMode);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(827, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 228);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Draw Mode";
            // 
            // btnChangeTColor
            // 
            this.btnChangeTColor.Location = new System.Drawing.Point(65, 163);
            this.btnChangeTColor.Name = "btnChangeTColor";
            this.btnChangeTColor.Size = new System.Drawing.Size(272, 48);
            this.btnChangeTColor.TabIndex = 3;
            this.btnChangeTColor.Text = "Change Tortoise Color";
            this.btnChangeTColor.UseVisualStyleBackColor = true;
            this.btnChangeTColor.Click += new System.EventHandler(this.btnChangeTColor_Click);
            // 
            // btnChangeHColor
            // 
            this.btnChangeHColor.Location = new System.Drawing.Point(65, 109);
            this.btnChangeHColor.Name = "btnChangeHColor";
            this.btnChangeHColor.Size = new System.Drawing.Size(272, 48);
            this.btnChangeHColor.TabIndex = 2;
            this.btnChangeHColor.Text = "Change Hare Color";
            this.btnChangeHColor.UseVisualStyleBackColor = true;
            this.btnChangeHColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // rbPictureMode
            // 
            this.rbPictureMode.AutoSize = true;
            this.rbPictureMode.Location = new System.Drawing.Point(32, 72);
            this.rbPictureMode.Name = "rbPictureMode";
            this.rbPictureMode.Size = new System.Drawing.Size(109, 33);
            this.rbPictureMode.TabIndex = 1;
            this.rbPictureMode.TabStop = true;
            this.rbPictureMode.Text = "Picture";
            this.rbPictureMode.UseVisualStyleBackColor = true;
            // 
            // rbDrawMode
            // 
            this.rbDrawMode.AutoSize = true;
            this.rbDrawMode.Location = new System.Drawing.Point(32, 33);
            this.rbDrawMode.Name = "rbDrawMode";
            this.rbDrawMode.Size = new System.Drawing.Size(90, 33);
            this.rbDrawMode.TabIndex = 0;
            this.rbDrawMode.TabStop = true;
            this.rbDrawMode.Text = "Draw";
            this.rbDrawMode.UseVisualStyleBackColor = true;
            // 
            // tmrRaceSpeed
            // 
            this.tmrRaceSpeed.Tick += new System.EventHandler(this.tmrRaceSpeed_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbFast);
            this.groupBox2.Controls.Add(this.rbNormal);
            this.groupBox2.Controls.Add(this.rbSlow);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(107, 354);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 170);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Speed Mode";
            // 
            // rbFast
            // 
            this.rbFast.AutoSize = true;
            this.rbFast.Location = new System.Drawing.Point(32, 111);
            this.rbFast.Name = "rbFast";
            this.rbFast.Size = new System.Drawing.Size(80, 33);
            this.rbFast.TabIndex = 2;
            this.rbFast.TabStop = true;
            this.rbFast.Text = "Fast";
            this.rbFast.UseVisualStyleBackColor = true;
            this.rbFast.CheckedChanged += new System.EventHandler(this.rbFast_CheckedChanged);
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(32, 72);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(113, 33);
            this.rbNormal.TabIndex = 1;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // rbSlow
            // 
            this.rbSlow.AutoSize = true;
            this.rbSlow.Location = new System.Drawing.Point(32, 33);
            this.rbSlow.Name = "rbSlow";
            this.rbSlow.Size = new System.Drawing.Size(88, 33);
            this.rbSlow.TabIndex = 0;
            this.rbSlow.TabStop = true;
            this.rbSlow.Text = "Slow";
            this.rbSlow.UseVisualStyleBackColor = true;
            this.rbSlow.CheckedChanged += new System.EventHandler(this.rbSlow_CheckedChanged);
            // 
            // pbTortoise
            // 
            this.pbTortoise.BackColor = System.Drawing.Color.Transparent;
            this.pbTortoise.Location = new System.Drawing.Point(12, 12);
            this.pbTortoise.Name = "pbTortoise";
            this.pbTortoise.Size = new System.Drawing.Size(61, 55);
            this.pbTortoise.TabIndex = 6;
            this.pbTortoise.TabStop = false;
            // 
            // pbHare
            // 
            this.pbHare.Location = new System.Drawing.Point(12, 63);
            this.pbHare.Name = "pbHare";
            this.pbHare.Size = new System.Drawing.Size(61, 55);
            this.pbHare.TabIndex = 7;
            this.pbHare.TabStop = false;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(438, 465);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(80, 21);
            this.hScrollBar1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1217, 559);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.pbHare);
            this.Controls.Add(this.pbTortoise);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Tortoise v. Hare";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTortoise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHare)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPictureMode;
        private System.Windows.Forms.RadioButton rbDrawMode;
        private System.Windows.Forms.Timer tmrRaceSpeed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbSlow;
        private System.Windows.Forms.RadioButton rbFast;
        private System.Windows.Forms.Button btnChangeHColor;
        private System.Windows.Forms.ColorDialog cdChangeColor;
        private System.Windows.Forms.Button btnChangeTColor;
        private System.Windows.Forms.PictureBox pbTortoise;
        private System.Windows.Forms.PictureBox pbHare;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}

