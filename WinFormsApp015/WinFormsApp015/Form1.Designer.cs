namespace WinFormsApp015
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSampleText = new System.Windows.Forms.TextBox();
            this.grpFont = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.cboFont = new System.Windows.Forms.ComboBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSampleText
            // 
            this.txtSampleText.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSampleText.Location = new System.Drawing.Point(79, 79);
            this.txtSampleText.Name = "txtSampleText";
            this.txtSampleText.Size = new System.Drawing.Size(622, 35);
            this.txtSampleText.TabIndex = 0;
            // 
            // grpFont
            // 
            this.grpFont.AutoSize = true;
            this.grpFont.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grpFont.Location = new System.Drawing.Point(416, 31);
            this.grpFont.Name = "grpFont";
            this.grpFont.Size = new System.Drawing.Size(69, 29);
            this.grpFont.TabIndex = 1;
            this.grpFont.Text = "굵게";
            this.grpFont.UseVisualStyleBackColor = true;
            this.grpFont.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkItalic.Location = new System.Drawing.Point(537, 31);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(88, 29);
            this.chkItalic.TabIndex = 2;
            this.chkItalic.Text = "이탤릭";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // cboFont
            // 
            this.cboFont.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboFont.FormattingEnabled = true;
            this.cboFont.Location = new System.Drawing.Point(79, 29);
            this.cboFont.Name = "cboFont";
            this.cboFont.Size = new System.Drawing.Size(311, 33);
            this.cboFont.TabIndex = 3;
            this.cboFont.SelectedIndexChanged += new System.EventHandler(this.cboFont_SelectedIndexChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(79, 147);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(622, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.progressBar1.Location = new System.Drawing.Point(79, 344);
            this.progressBar1.Maximum = 20;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBar1.Size = new System.Drawing.Size(622, 251);
            this.progressBar1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(79, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 64);
            this.button1.TabIndex = 8;
            this.button1.Text = "modal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(304, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 64);
            this.button2.TabIndex = 9;
            this.button2.Text = "modaless";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(537, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 64);
            this.button3.TabIndex = 10;
            this.button3.Text = "messageBox";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.cboFont);
            this.Controls.Add(this.chkItalic);
            this.Controls.Add(this.grpFont);
            this.Controls.Add(this.txtSampleText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSampleText;
        private System.Windows.Forms.CheckBox grpFont;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.ComboBox cboFont;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

