namespace WinFormsApp006
{
    partial class CopyMainForm
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
            this.btnSrcFile = new System.Windows.Forms.Button();
            this.btnDstFile = new System.Windows.Forms.Button();
            this.lblSrcPath = new System.Windows.Forms.Label();
            this.lblDstPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSrcFile
            // 
            this.btnSrcFile.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSrcFile.Location = new System.Drawing.Point(73, 61);
            this.btnSrcFile.Name = "btnSrcFile";
            this.btnSrcFile.Size = new System.Drawing.Size(170, 122);
            this.btnSrcFile.TabIndex = 0;
            this.btnSrcFile.Text = "원본(Src)";
            this.btnSrcFile.UseVisualStyleBackColor = true;
            this.btnSrcFile.Click += new System.EventHandler(this.btnSrcFile_Click);
            // 
            // btnDstFile
            // 
            this.btnDstFile.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDstFile.Location = new System.Drawing.Point(73, 238);
            this.btnDstFile.Name = "btnDstFile";
            this.btnDstFile.Size = new System.Drawing.Size(170, 122);
            this.btnDstFile.TabIndex = 1;
            this.btnDstFile.Text = "복사(Dst)";
            this.btnDstFile.UseVisualStyleBackColor = true;
            this.btnDstFile.Click += new System.EventHandler(this.btnDstFile_Click);
            // 
            // lblSrcPath
            // 
            this.lblSrcPath.AutoSize = true;
            this.lblSrcPath.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSrcPath.Location = new System.Drawing.Point(313, 104);
            this.lblSrcPath.Name = "lblSrcPath";
            this.lblSrcPath.Size = new System.Drawing.Size(188, 37);
            this.lblSrcPath.TabIndex = 2;
            this.lblSrcPath.Text = "원본파일 경로";
            // 
            // lblDstPath
            // 
            this.lblDstPath.AutoSize = true;
            this.lblDstPath.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDstPath.Location = new System.Drawing.Point(313, 281);
            this.lblDstPath.Name = "lblDstPath";
            this.lblDstPath.Size = new System.Drawing.Size(188, 37);
            this.lblDstPath.TabIndex = 3;
            this.lblDstPath.Text = "복사파일 경로";
            // 
            // CopyMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.lblDstPath);
            this.Controls.Add(this.lblSrcPath);
            this.Controls.Add(this.btnDstFile);
            this.Controls.Add(this.btnSrcFile);
            this.Name = "CopyMainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSrcFile;
        private System.Windows.Forms.Button btnDstFile;
        private System.Windows.Forms.Label lblSrcPath;
        private System.Windows.Forms.Label lblDstPath;
    }
}

