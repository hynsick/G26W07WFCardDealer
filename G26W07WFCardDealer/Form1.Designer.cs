namespace G26W07WFCardDealer
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
            Card1 = new PictureBox();
            btnDeal = new Button();
            Card2 = new PictureBox();
            Card3 = new PictureBox();
            Card4 = new PictureBox();
            Card5 = new PictureBox();
            ResultLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)Card1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Card2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Card3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Card4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Card5).BeginInit();
            SuspendLayout();
            // 
            // Card1
            // 
            Card1.Image = Properties.Resources.red_joker;
            Card1.Location = new Point(-17, 2);
            Card1.Margin = new Padding(4);
            Card1.Name = "Card1";
            Card1.Size = new Size(406, 493);
            Card1.SizeMode = PictureBoxSizeMode.Zoom;
            Card1.TabIndex = 0;
            Card1.TabStop = false;
            // 
            // btnDeal
            // 
            btnDeal.Location = new Point(12, 502);
            btnDeal.Name = "btnDeal";
            btnDeal.Size = new Size(1265, 74);
            btnDeal.TabIndex = 1;
            btnDeal.Text = "카드분배";
            btnDeal.UseVisualStyleBackColor = true;
            btnDeal.Click += OnDeal;
            // 
            // Card2
            // 
            Card2.Image = Properties.Resources.red_joker;
            Card2.Location = new Point(353, 2);
            Card2.Margin = new Padding(4);
            Card2.Name = "Card2";
            Card2.Size = new Size(406, 493);
            Card2.SizeMode = PictureBoxSizeMode.Zoom;
            Card2.TabIndex = 2;
            Card2.TabStop = false;
            // 
            // Card3
            // 
            Card3.Image = Properties.Resources.red_joker;
            Card3.Location = new Point(708, 2);
            Card3.Margin = new Padding(4);
            Card3.Name = "Card3";
            Card3.Size = new Size(406, 493);
            Card3.SizeMode = PictureBoxSizeMode.Zoom;
            Card3.TabIndex = 3;
            Card3.TabStop = false;
            // 
            // Card4
            // 
            Card4.Image = Properties.Resources.red_joker;
            Card4.Location = new Point(1098, -8);
            Card4.Margin = new Padding(4);
            Card4.Name = "Card4";
            Card4.Size = new Size(406, 493);
            Card4.SizeMode = PictureBoxSizeMode.Zoom;
            Card4.TabIndex = 4;
            Card4.TabStop = false;
            // 
            // Card5
            // 
            Card5.Image = Properties.Resources.red_joker;
            Card5.Location = new Point(1456, 2);
            Card5.Margin = new Padding(4);
            Card5.Name = "Card5";
            Card5.Size = new Size(406, 493);
            Card5.SizeMode = PictureBoxSizeMode.Zoom;
            Card5.TabIndex = 5;
            Card5.TabStop = false;
            // 
            // ResultLabel
            // 
            ResultLabel.BackColor = SystemColors.MenuHighlight;
            ResultLabel.Font = new Font("맑은 고딕", 12F);
            ResultLabel.Location = new Point(1299, 502);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(518, 80);
            ResultLabel.TabIndex = 6;
            ResultLabel.Text = "결과";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1829, 576);
            Controls.Add(ResultLabel);
            Controls.Add(Card5);
            Controls.Add(Card4);
            Controls.Add(Card3);
            Controls.Add(Card2);
            Controls.Add(btnDeal);
            Controls.Add(Card1);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "카드딜러";
            ((System.ComponentModel.ISupportInitialize)Card1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Card2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Card3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Card4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Card5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Card1;
        private Button btnDeal;
        private PictureBox Card2;
        private PictureBox Card3;
        private PictureBox Card4;
        private PictureBox Card5;
        private Label ResultLabel;
    }
}
