namespace GetMyHardWareInfo
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
            this.cpuBtn = new System.Windows.Forms.Button();
            this.mbBtn = new System.Windows.Forms.Button();
            this.ramBtn = new System.Windows.Forms.Button();
            this.gpuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cpuBtn
            // 
            this.cpuBtn.Font = new System.Drawing.Font("한컴 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cpuBtn.Location = new System.Drawing.Point(45, 131);
            this.cpuBtn.Name = "cpuBtn";
            this.cpuBtn.Size = new System.Drawing.Size(140, 100);
            this.cpuBtn.TabIndex = 0;
            this.cpuBtn.Text = "CPU";
            this.cpuBtn.UseVisualStyleBackColor = true;
            this.cpuBtn.Click += new System.EventHandler(this.cpuBtn_Click);
            // 
            // mbBtn
            // 
            this.mbBtn.Font = new System.Drawing.Font("한컴 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mbBtn.Location = new System.Drawing.Point(222, 131);
            this.mbBtn.Name = "mbBtn";
            this.mbBtn.Size = new System.Drawing.Size(140, 100);
            this.mbBtn.TabIndex = 1;
            this.mbBtn.Text = "MotherBoard";
            this.mbBtn.UseVisualStyleBackColor = true;
            // 
            // ramBtn
            // 
            this.ramBtn.Font = new System.Drawing.Font("한컴 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ramBtn.Location = new System.Drawing.Point(415, 131);
            this.ramBtn.Name = "ramBtn";
            this.ramBtn.Size = new System.Drawing.Size(140, 100);
            this.ramBtn.TabIndex = 2;
            this.ramBtn.Text = "RAM";
            this.ramBtn.UseVisualStyleBackColor = true;
            // 
            // gpuBtn
            // 
            this.gpuBtn.Font = new System.Drawing.Font("한컴 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gpuBtn.Location = new System.Drawing.Point(600, 131);
            this.gpuBtn.Name = "gpuBtn";
            this.gpuBtn.Size = new System.Drawing.Size(140, 100);
            this.gpuBtn.TabIndex = 3;
            this.gpuBtn.Text = "GPU";
            this.gpuBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.gpuBtn);
            this.Controls.Add(this.ramBtn);
            this.Controls.Add(this.mbBtn);
            this.Controls.Add(this.cpuBtn);
            this.Name = "Form1";
            this.Text = "My HardWare INFO";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cpuBtn;
        private System.Windows.Forms.Button mbBtn;
        private System.Windows.Forms.Button ramBtn;
        private System.Windows.Forms.Button gpuBtn;
    }
}

