namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DMFES = new Button();
            TM = new Button();
            TK = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            GENDER = new TextBox();
            price = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            save = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // DMFES
            // 
            DMFES.Location = new Point(475, 282);
            DMFES.Name = "DMFES";
            DMFES.Size = new Size(87, 35);
            DMFES.TabIndex = 1;
            DMFES.Text = "NORMAL";
            DMFES.UseVisualStyleBackColor = true;
            DMFES.Click += button1_Click;
            // 
            // TM
            // 
            TM.Location = new Point(475, 240);
            TM.Name = "TM";
            TM.Size = new Size(87, 36);
            TM.TabIndex = 2;
            TM.Text = "Standing";
            TM.UseVisualStyleBackColor = true;
            TM.Click += TM_Click;
            // 
            // TK
            // 
            TK.BackColor = SystemColors.Info;
            TK.Location = new Point(475, 323);
            TK.Name = "TK";
            TK.Size = new Size(87, 35);
            TK.TabIndex = 3;
            TK.Text = "VIP";
            TK.UseVisualStyleBackColor = false;
            TK.Click += TK_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(454, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(334, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(435, 445);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // GENDER
            // 
            GENDER.Location = new Point(648, 240);
            GENDER.Name = "GENDER";
            GENDER.Size = new Size(100, 23);
            GENDER.TabIndex = 6;
            // 
            // price
            // 
            price.Location = new Point(648, 269);
            price.Name = "price";
            price.Size = new Size(100, 23);
            price.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(673, 215);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 8;
            label1.Text = "กรอกข้อมูล";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(492, 215);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 9;
            label2.Text = "เลือกบัตร";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(614, 248);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 10;
            label3.Text = "เพศ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(614, 272);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 11;
            label4.Text = "ราคา";
            // 
            // save
            // 
            save.Location = new Point(648, 298);
            save.Name = "save";
            save.Size = new Size(100, 23);
            save.TabIndex = 12;
            save.Text = "save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // button1
            // 
            button1.Location = new Point(651, 390);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Save csv";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(save);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(price);
            Controls.Add(GENDER);
            Controls.Add(pictureBox1);
            Controls.Add(TK);
            Controls.Add(TM);
            Controls.Add(DMFES);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button DMFES;
        private Button TM;
        private Button TK;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox GENDER;
        private TextBox price;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button save;
        private Button button1;
    }
}
