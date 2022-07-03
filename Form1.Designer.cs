
namespace GameFairy
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.life3 = new System.Windows.Forms.PictureBox();
            this.life2 = new System.Windows.Forms.PictureBox();
            this.life1 = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            this.game_timer = new System.Windows.Forms.Timer(this.components);
            this.fairy = new System.Windows.Forms.PictureBox();
            this.mountain = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.extraheart = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fairy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraheart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.life3);
            this.panel1.Controls.Add(this.life2);
            this.panel1.Controls.Add(this.life1);
            this.panel1.Location = new System.Drawing.Point(12, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 38);
            this.panel1.TabIndex = 3;
            // 
            // life3
            // 
            this.life3.Image = global::GameFairy.Properties.Resources.download__2__removebg_preview;
            this.life3.Location = new System.Drawing.Point(103, 3);
            this.life3.Name = "life3";
            this.life3.Size = new System.Drawing.Size(44, 31);
            this.life3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life3.TabIndex = 0;
            this.life3.TabStop = false;
            // 
            // life2
            // 
            this.life2.Image = global::GameFairy.Properties.Resources.download__2__removebg_preview;
            this.life2.Location = new System.Drawing.Point(53, 3);
            this.life2.Name = "life2";
            this.life2.Size = new System.Drawing.Size(44, 31);
            this.life2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life2.TabIndex = 0;
            this.life2.TabStop = false;
            // 
            // life1
            // 
            this.life1.Image = global::GameFairy.Properties.Resources.download__2__removebg_preview;
            this.life1.Location = new System.Drawing.Point(3, 4);
            this.life1.Name = "life1";
            this.life1.Size = new System.Drawing.Size(44, 31);
            this.life1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life1.TabIndex = 0;
            this.life1.TabStop = false;
            // 
            // score
            // 
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(423, 407);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(100, 23);
            this.score.TabIndex = 4;
            this.score.Text = "Score:";
            // 
            // game_timer
            // 
            this.game_timer.Enabled = true;
            this.game_timer.Interval = 20;
            this.game_timer.Tick += new System.EventHandler(this.game_timeTick);
            // 
            // fairy
            // 
            this.fairy.Image = global::GameFairy.Properties.Resources.images__2__removebg_preview;
            this.fairy.Location = new System.Drawing.Point(23, 70);
            this.fairy.Name = "fairy";
            this.fairy.Size = new System.Drawing.Size(71, 62);
            this.fairy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fairy.TabIndex = 2;
            this.fairy.TabStop = false;
            // 
            // mountain
            // 
            this.mountain.Image = global::GameFairy.Properties.Resources.download__1__removebg_preview;
            this.mountain.Location = new System.Drawing.Point(290, 205);
            this.mountain.Name = "mountain";
            this.mountain.Size = new System.Drawing.Size(112, 250);
            this.mountain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mountain.TabIndex = 1;
            this.mountain.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::GameFairy.Properties.Resources._360_F_295552536_UmzQGSIzycVkA3pbercVnTl8P6rmLLxf;
            this.ground.Location = new System.Drawing.Point(2, 395);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(698, 60);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(7, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 78);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // extraheart
            // 
            this.extraheart.Image = global::GameFairy.Properties.Resources.download__2__removebg_preview;
            this.extraheart.Location = new System.Drawing.Point(358, 101);
            this.extraheart.Name = "extraheart";
            this.extraheart.Size = new System.Drawing.Size(44, 31);
            this.extraheart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.extraheart.TabIndex = 0;
            this.extraheart.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 446);
            this.Controls.Add(this.extraheart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.score);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fairy);
            this.Controls.Add(this.mountain);
            this.Controls.Add(this.ground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydownevent);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyupevent);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.life3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fairy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraheart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox mountain;
        private System.Windows.Forms.PictureBox fairy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox life1;
        private System.Windows.Forms.PictureBox life3;
        private System.Windows.Forms.PictureBox life2;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Timer game_timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox extraheart;
    }
}

