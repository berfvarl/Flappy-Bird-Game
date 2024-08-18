namespace FlappyBirdGame
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BoruUst = new PictureBox();
            BoruAlt = new PictureBox();
            Flappy = new PictureBox();
            Zemin = new PictureBox();
            ScoreTxt = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)BoruUst).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BoruAlt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Flappy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Zemin).BeginInit();
            SuspendLayout();
            // 
            // BoruUst
            // 
            BoruUst.Image = (Image)resources.GetObject("BoruUst.Image");
            BoruUst.Location = new Point(626, 1);
            BoruUst.Name = "BoruUst";
            BoruUst.Size = new Size(125, 112);
            BoruUst.SizeMode = PictureBoxSizeMode.StretchImage;
            BoruUst.TabIndex = 0;
            BoruUst.TabStop = false;
            // 
            // BoruAlt
            // 
            BoruAlt.Image = (Image)resources.GetObject("BoruAlt.Image");
            BoruAlt.Location = new Point(436, 320);
            BoruAlt.Name = "BoruAlt";
            BoruAlt.Size = new Size(125, 116);
            BoruAlt.SizeMode = PictureBoxSizeMode.StretchImage;
            BoruAlt.TabIndex = 1;
            BoruAlt.TabStop = false;
            // 
            // Flappy
            // 
            Flappy.Image = (Image)resources.GetObject("Flappy.Image");
            Flappy.Location = new Point(-2, 177);
            Flappy.Name = "Flappy";
            Flappy.Size = new Size(108, 62);
            Flappy.SizeMode = PictureBoxSizeMode.StretchImage;
            Flappy.TabIndex = 2;
            Flappy.TabStop = false;
            // 
            // Zemin
            // 
            Zemin.Image = (Image)resources.GetObject("Zemin.Image");
            Zemin.Location = new Point(-2, 433);
            Zemin.Name = "Zemin";
            Zemin.Size = new Size(804, 62);
            Zemin.SizeMode = PictureBoxSizeMode.StretchImage;
            Zemin.TabIndex = 3;
            Zemin.TabStop = false;
            // 
            // ScoreTxt
            // 
            ScoreTxt.AutoSize = true;
            ScoreTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ScoreTxt.Location = new Point(12, 21);
            ScoreTxt.Name = "ScoreTxt";
            ScoreTxt.Size = new Size(94, 25);
            ScoreTxt.TabIndex = 4;
            ScoreTxt.Text = "Score: 0";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer1.Tick += GameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(800, 533);
            Controls.Add(ScoreTxt);
            Controls.Add(Zemin);
            Controls.Add(Flappy);
            Controls.Add(BoruAlt);
            Controls.Add(BoruUst);
            Name = "Form1";
            Text = " ";
            KeyDown += gamekeyisdown;
            KeyUp += gamekeyisup;
            ((System.ComponentModel.ISupportInitialize)BoruUst).EndInit();
            ((System.ComponentModel.ISupportInitialize)BoruAlt).EndInit();
            ((System.ComponentModel.ISupportInitialize)Flappy).EndInit();
            ((System.ComponentModel.ISupportInitialize)Zemin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox BoruUst;
        private PictureBox BoruAlt;
        private PictureBox Flappy;
        private PictureBox Zemin;
        private Label ScoreTxt;
        private System.Windows.Forms.Timer timer1;
        //private System.Windows.Forms.Timer GameTimer;
        //private System.Windows.Forms.Timer GameTimer;
    }
}
