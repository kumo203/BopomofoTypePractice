namespace BopomofoTypePractice
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 29);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(776, 104);
            textBox1.TabIndex = 0;
            textBox1.Text = "一生中我們會遇到各種各樣的困難許多時候勇敢地直面眼前的困難更有利於幫助我們解決問題";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 1;
            label1.Text = "ChineseText";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 141);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 2;
            label2.Text = "Bopomofo";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 164);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(775, 115);
            textBox2.TabIndex = 0;
            textBox2.TabStop = false;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(793, 250);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Keyboard_layout_Zhuyin;
            pictureBox1.Location = new Point(12, 285);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(786, 272);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 583);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(786, 27);
            textBox3.TabIndex = 5;
            textBox3.PreviewKeyDown += textBox3_PreviewKeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 560);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 2;
            label3.Text = "Input";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 616);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(786, 27);
            textBox4.TabIndex = 5;
            textBox4.TabStop = false;
            textBox4.PreviewKeyDown += textBox3_PreviewKeyDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 651);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "BopomofoTypePractice";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private PictureBox pictureBox1;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
    }
}
