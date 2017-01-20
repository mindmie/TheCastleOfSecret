namespace JAMGame
{
    partial class JAMGameView
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
            this.Warming = new System.Windows.Forms.Label();
            this.ScreenShot = new System.Windows.Forms.PictureBox();
            this.Playgame = new System.Windows.Forms.Button();
            this.Level = new System.Windows.Forms.Label();
            this.numCross = new System.Windows.Forms.Label();
            this.numTorch = new System.Windows.Forms.Label();
            this.HWP = new System.Windows.Forms.PictureBox();
            this.Next = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenShot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HWP)).BeginInit();
            this.SuspendLayout();
            // 
            // Warming
            // 
            this.Warming.AutoSize = true;
            this.Warming.BackColor = System.Drawing.Color.Transparent;
            this.Warming.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Warming.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Warming.Location = new System.Drawing.Point(1396, 646);
            this.Warming.MaximumSize = new System.Drawing.Size(436, 392);
            this.Warming.Name = "Warming";
            this.Warming.Size = new System.Drawing.Size(98, 24);
            this.Warming.TabIndex = 1;
            this.Warming.Text = "WARM!!!!";
            this.Warming.Visible = false;
            this.Warming.Click += new System.EventHandler(this.Warming_Click);
            // 
            // ScreenShot
            // 
            this.ScreenShot.Location = new System.Drawing.Point(1242, 347);
            this.ScreenShot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ScreenShot.Name = "ScreenShot";
            this.ScreenShot.Size = new System.Drawing.Size(89, 40);
            this.ScreenShot.TabIndex = 3;
            this.ScreenShot.TabStop = false;
            this.ScreenShot.Click += new System.EventHandler(this.ScreenShot_Click);
            // 
            // Playgame
            // 
            this.Playgame.BackColor = System.Drawing.Color.Black;
            this.Playgame.Location = new System.Drawing.Point(1242, 415);
            this.Playgame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Playgame.Name = "Playgame";
            this.Playgame.Size = new System.Drawing.Size(67, 18);
            this.Playgame.TabIndex = 4;
            this.Playgame.UseVisualStyleBackColor = false;
            this.Playgame.Visible = false;
            this.Playgame.Click += new System.EventHandler(this.Playgame_Click);
            // 
            // Level
            // 
            this.Level.AutoSize = true;
            this.Level.BackColor = System.Drawing.Color.Transparent;
            this.Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level.Location = new System.Drawing.Point(1671, 287);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(206, 91);
            this.Level.TabIndex = 5;
            this.Level.Text = "level";
            this.Level.Visible = false;
            // 
            // numCross
            // 
            this.numCross.AutoSize = true;
            this.numCross.BackColor = System.Drawing.Color.Transparent;
            this.numCross.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCross.Location = new System.Drawing.Point(1476, 908);
            this.numCross.Name = "numCross";
            this.numCross.Size = new System.Drawing.Size(178, 69);
            this.numCross.TabIndex = 6;
            this.numCross.Text = "cross";
            this.numCross.Visible = false;
            // 
            // numTorch
            // 
            this.numTorch.AutoSize = true;
            this.numTorch.BackColor = System.Drawing.Color.Transparent;
            this.numTorch.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTorch.Location = new System.Drawing.Point(1714, 908);
            this.numTorch.Name = "numTorch";
            this.numTorch.Size = new System.Drawing.Size(188, 69);
            this.numTorch.TabIndex = 7;
            this.numTorch.Text = "Torch";
            this.numTorch.Visible = false;
            // 
            // HWP
            // 
            this.HWP.BackgroundImage = global::JAMGame.Properties.Resources.Ask;
            this.HWP.Location = new System.Drawing.Point(1864, 87);
            this.HWP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HWP.Name = "HWP";
            this.HWP.Size = new System.Drawing.Size(118, 90);
            this.HWP.TabIndex = 9;
            this.HWP.TabStop = false;
            this.HWP.Visible = false;
            this.HWP.Click += new System.EventHandler(this.HWP_Click);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.Tan;
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.Location = new System.Drawing.Point(1456, 1059);
            this.Next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(175, 63);
            this.Next.TabIndex = 10;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Visible = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tan;
            this.button1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1677, 100);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 93);
            this.button1.TabIndex = 11;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // JAMGameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::JAMGame.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(1482, 836);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.HWP);
            this.Controls.Add(this.numTorch);
            this.Controls.Add(this.numCross);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.Playgame);
            this.Controls.Add(this.ScreenShot);
            this.Controls.Add(this.Warming);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "JAMGameView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.JAMGameView_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ScreenShot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HWP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Warming;
        private System.Windows.Forms.PictureBox ScreenShot;
        private System.Windows.Forms.Button Playgame;
        private System.Windows.Forms.Label Level;
        private System.Windows.Forms.Label numCross;
        private System.Windows.Forms.Label numTorch;
        private System.Windows.Forms.PictureBox HWP;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button button1;
    }
}

