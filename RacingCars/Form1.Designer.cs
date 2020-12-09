
namespace RacingCars
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.line1 = new System.Windows.Forms.PictureBox();
            this.line2 = new System.Windows.Forms.PictureBox();
            this.line3 = new System.Windows.Forms.PictureBox();
            this.lineLeft = new System.Windows.Forms.PictureBox();
            this.lineRight = new System.Windows.Forms.PictureBox();
            this.Gamer = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.police1 = new System.Windows.Forms.PictureBox();
            this.police2 = new System.Windows.Forms.PictureBox();
            this.police3 = new System.Windows.Forms.PictureBox();
            this.GameOver = new System.Windows.Forms.Label();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.coin3 = new System.Windows.Forms.PictureBox();
            this.coin4 = new System.Windows.Forms.PictureBox();
            this.coin5 = new System.Windows.Forms.PictureBox();
            this.coin2 = new System.Windows.Forms.PictureBox();
            this.pointsCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.line1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gamer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.police1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.police2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.police3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
            this.SuspendLayout();
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.line1.Location = new System.Drawing.Point(178, 1);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(10, 121);
            this.line1.TabIndex = 0;
            this.line1.TabStop = false;
            this.line1.Click += new System.EventHandler(this.line1_Click);
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.line2.Location = new System.Drawing.Point(178, 167);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(10, 121);
            this.line2.TabIndex = 1;
            this.line2.TabStop = false;
            this.line2.Click += new System.EventHandler(this.line2_Click);
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.line3.Location = new System.Drawing.Point(178, 341);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(10, 121);
            this.line3.TabIndex = 2;
            this.line3.TabStop = false;
            this.line3.Click += new System.EventHandler(this.line3_Click);
            // 
            // lineLeft
            // 
            this.lineLeft.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lineLeft.Location = new System.Drawing.Point(0, -1);
            this.lineLeft.Name = "lineLeft";
            this.lineLeft.Size = new System.Drawing.Size(10, 468);
            this.lineLeft.TabIndex = 3;
            this.lineLeft.TabStop = false;
            this.lineLeft.Click += new System.EventHandler(this.lineLeft_Click);
            // 
            // lineRight
            // 
            this.lineRight.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lineRight.Location = new System.Drawing.Point(375, -1);
            this.lineRight.Name = "lineRight";
            this.lineRight.Size = new System.Drawing.Size(10, 468);
            this.lineRight.TabIndex = 4;
            this.lineRight.TabStop = false;
            this.lineRight.Click += new System.EventHandler(this.lineRight_Click);
            // 
            // Gamer
            // 
            this.Gamer.Image = ((System.Drawing.Image)(resources.GetObject("Gamer.Image")));
            this.Gamer.Location = new System.Drawing.Point(87, 341);
            this.Gamer.Name = "Gamer";
            this.Gamer.Size = new System.Drawing.Size(35, 80);
            this.Gamer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Gamer.TabIndex = 5;
            this.Gamer.TabStop = false;
            this.Gamer.Click += new System.EventHandler(this.Gamer_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // police1
            // 
            this.police1.Image = ((System.Drawing.Image)(resources.GetObject("police1.Image")));
            this.police1.Location = new System.Drawing.Point(236, 330);
            this.police1.Name = "police1";
            this.police1.Size = new System.Drawing.Size(39, 34);
            this.police1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.police1.TabIndex = 6;
            this.police1.TabStop = false;
            // 
            // police2
            // 
            this.police2.Image = ((System.Drawing.Image)(resources.GetObject("police2.Image")));
            this.police2.Location = new System.Drawing.Point(272, 75);
            this.police2.Name = "police2";
            this.police2.Size = new System.Drawing.Size(38, 32);
            this.police2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.police2.TabIndex = 7;
            this.police2.TabStop = false;
            // 
            // police3
            // 
            this.police3.Image = ((System.Drawing.Image)(resources.GetObject("police3.Image")));
            this.police3.Location = new System.Drawing.Point(301, 223);
            this.police3.Name = "police3";
            this.police3.Size = new System.Drawing.Size(42, 38);
            this.police3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.police3.TabIndex = 8;
            this.police3.TabStop = false;
            // 
            // GameOver
            // 
            this.GameOver.AutoSize = true;
            this.GameOver.BackColor = System.Drawing.Color.Yellow;
            this.GameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GameOver.ForeColor = System.Drawing.Color.Red;
            this.GameOver.Location = new System.Drawing.Point(80, 127);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(219, 37);
            this.GameOver.TabIndex = 9;
            this.GameOver.Text = "GAME OVER";
            // 
            // coin1
            // 
            this.coin1.Image = ((System.Drawing.Image)(resources.GetObject("coin1.Image")));
            this.coin1.Location = new System.Drawing.Point(68, 237);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(26, 24);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin1.TabIndex = 10;
            this.coin1.TabStop = false;
            // 
            // coin3
            // 
            this.coin3.Image = ((System.Drawing.Image)(resources.GetObject("coin3.Image")));
            this.coin3.Location = new System.Drawing.Point(226, 36);
            this.coin3.Name = "coin3";
            this.coin3.Size = new System.Drawing.Size(26, 24);
            this.coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin3.TabIndex = 11;
            this.coin3.TabStop = false;
            // 
            // coin4
            // 
            this.coin4.Image = ((System.Drawing.Image)(resources.GetObject("coin4.Image")));
            this.coin4.Location = new System.Drawing.Point(106, 49);
            this.coin4.Name = "coin4";
            this.coin4.Size = new System.Drawing.Size(26, 24);
            this.coin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin4.TabIndex = 12;
            this.coin4.TabStop = false;
            // 
            // coin5
            // 
            this.coin5.Image = ((System.Drawing.Image)(resources.GetObject("coin5.Image")));
            this.coin5.Location = new System.Drawing.Point(194, 213);
            this.coin5.Name = "coin5";
            this.coin5.Size = new System.Drawing.Size(26, 24);
            this.coin5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin5.TabIndex = 13;
            this.coin5.TabStop = false;
            // 
            // coin2
            // 
            this.coin2.Image = ((System.Drawing.Image)(resources.GetObject("coin2.Image")));
            this.coin2.Location = new System.Drawing.Point(317, 371);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(26, 24);
            this.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin2.TabIndex = 14;
            this.coin2.TabStop = false;
            // 
            // pointsCounter
            // 
            this.pointsCounter.AutoSize = true;
            this.pointsCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pointsCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pointsCounter.Location = new System.Drawing.Point(16, 9);
            this.pointsCounter.Name = "pointsCounter";
            this.pointsCounter.Size = new System.Drawing.Size(69, 20);
            this.pointsCounter.TabIndex = 15;
            this.pointsCounter.Text = "Points: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.pointsCounter);
            this.Controls.Add(this.coin2);
            this.Controls.Add(this.coin5);
            this.Controls.Add(this.coin4);
            this.Controls.Add(this.coin3);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.GameOver);
            this.Controls.Add(this.police3);
            this.Controls.Add(this.police2);
            this.Controls.Add(this.police1);
            this.Controls.Add(this.Gamer);
            this.Controls.Add(this.lineRight);
            this.Controls.Add(this.lineLeft);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.line1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gamer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.police1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.police2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.police3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox line1;
        private System.Windows.Forms.PictureBox line2;
        private System.Windows.Forms.PictureBox line3;
        private System.Windows.Forms.PictureBox lineLeft;
        private System.Windows.Forms.PictureBox lineRight;
        private System.Windows.Forms.PictureBox Gamer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox police1;
        private System.Windows.Forms.PictureBox police2;
        private System.Windows.Forms.PictureBox police3;
        private System.Windows.Forms.Label GameOver;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.PictureBox coin3;
        private System.Windows.Forms.PictureBox coin4;
        private System.Windows.Forms.PictureBox coin5;
        private System.Windows.Forms.PictureBox coin2;
        private System.Windows.Forms.Label pointsCounter;
    }
}

