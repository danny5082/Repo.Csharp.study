namespace WinFormsApp001
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
            btn_bigbutton = new Button();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            btn_finifh = new Button();
            SuspendLayout();
            // 
            // btn_bigbutton
            // 
            btn_bigbutton.Location = new Point(29, 25);
            btn_bigbutton.Name = "btn_bigbutton";
            btn_bigbutton.Size = new Size(347, 149);
            btn_bigbutton.TabIndex = 0;
            btn_bigbutton.Text = "왕버튼";
            btn_bigbutton.UseVisualStyleBackColor = true;
            btn_bigbutton.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(403, 25);
            button1.Name = "button1";
            button1.Size = new Size(349, 149);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(29, 226);
            button2.Name = "button2";
            button2.Size = new Size(347, 99);
            button2.TabIndex = 2;
            button2.Text = "절대 누르지 마세요";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(403, 226);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(349, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(29, 351);
            button3.Name = "button3";
            button3.Size = new Size(347, 105);
            button3.TabIndex = 4;
            button3.Text = "내용지우기";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btn_finifh
            // 
            btn_finifh.Location = new Point(403, 351);
            btn_finifh.Name = "btn_finifh";
            btn_finifh.Size = new Size(349, 105);
            btn_finifh.TabIndex = 5;
            btn_finifh.Text = "종료버튼";
            btn_finifh.UseVisualStyleBackColor = true;
            btn_finifh.Click += btn_finifh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 508);
            Controls.Add(btn_finifh);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btn_bigbutton);
            Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_bigbutton;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
        private Button btn_finifh;
    }
}