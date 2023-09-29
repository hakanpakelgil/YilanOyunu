namespace YilanOyunu
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
            pnlSaha = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            lblPuan = new Label();
            SuspendLayout();
            // 
            // pnlSaha
            // 
            pnlSaha.BackColor = SystemColors.ActiveCaptionText;
            pnlSaha.Location = new Point(12, 51);
            pnlSaha.Name = "pnlSaha";
            pnlSaha.Size = new Size(450, 450);
            pnlSaha.TabIndex = 0;
            pnlSaha.Paint += pnlSaha_Paint;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 200;
            timer1.Tick += timer1_Tick;
            // 
            // lblPuan
            // 
            lblPuan.BackColor = Color.FromArgb(0, 192, 0);
            lblPuan.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPuan.Location = new Point(21, 8);
            lblPuan.Name = "lblPuan";
            lblPuan.Size = new Size(438, 35);
            lblPuan.TabIndex = 1;
            lblPuan.Text = "Puan : 00000";
            lblPuan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 513);
            Controls.Add(lblPuan);
            Controls.Add(pnlSaha);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yılan Oyunu";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSaha;
        private System.Windows.Forms.Timer timer1;
        private Label lblPuan;
    }
}