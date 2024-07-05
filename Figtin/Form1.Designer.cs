namespace Figtin
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
            pictureBox1 = new PictureBox();
            button_Atak = new Button();
            button_Inv = new Button();
            pictureBox2 = new PictureBox();
            Label_HP = new Label();
            Label_HP_2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resource1.PERS;
            pictureBox1.Location = new Point(-39, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 309);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button_Atak
            // 
            button_Atak.Location = new Point(18, 352);
            button_Atak.Name = "button_Atak";
            button_Atak.Size = new Size(101, 33);
            button_Atak.TabIndex = 1;
            button_Atak.Text = "Атака";
            button_Atak.UseVisualStyleBackColor = true;
            button_Atak.Click += button_Atak_Click;
            // 
            // button_Inv
            // 
            button_Inv.Location = new Point(18, 391);
            button_Inv.Name = "button_Inv";
            button_Inv.Size = new Size(101, 33);
            button_Inv.TabIndex = 2;
            button_Inv.Text = "Хилл";
            button_Inv.UseVisualStyleBackColor = true;
            button_Inv.Click += button_Inv_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Resource1.ApplicationFrameHost_uY5H9jBXRl;
            pictureBox2.Location = new Point(260, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(193, 309);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // Label_HP
            // 
            Label_HP.AutoSize = true;
            Label_HP.Location = new Point(12, 9);
            Label_HP.Name = "Label_HP";
            Label_HP.Size = new Size(26, 15);
            Label_HP.TabIndex = 4;
            Label_HP.Text = "HP:";
            // 
            // Label_HP_2
            // 
            Label_HP_2.AutoSize = true;
            Label_HP_2.Location = new Point(260, 9);
            Label_HP_2.Name = "Label_HP_2";
            Label_HP_2.Size = new Size(26, 15);
            Label_HP_2.TabIndex = 5;
            Label_HP_2.Text = "HP:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 450);
            Controls.Add(Label_HP_2);
            Controls.Add(Label_HP);
            Controls.Add(pictureBox2);
            Controls.Add(button_Inv);
            Controls.Add(button_Atak);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button_Atak;
        private Button button_Inv;
        private PictureBox pictureBox2;
        private Label Label_HP;
        private Label Label_HP_2;
        private System.Windows.Forms.Timer timer1;
    }
}
