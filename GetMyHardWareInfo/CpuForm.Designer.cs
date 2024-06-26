namespace GetMyHardWareInfo
{
    partial class CpuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtManu = new System.Windows.Forms.Label();
            this.txtSN = new System.Windows.Forms.Label();
            this.txtUse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU Model      :";
            // 
            // txtModel
            // 
            this.txtModel.AutoSize = true;
            this.txtModel.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtModel.Location = new System.Drawing.Point(167, 27);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(101, 21);
            this.txtModel.TabIndex = 1;
            this.txtModel.Text = "Intel 14900K";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(24, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Manufacturer  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(24, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Serial Number :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(24, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Usage               :";
            // 
            // txtManu
            // 
            this.txtManu.AutoSize = true;
            this.txtManu.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtManu.Location = new System.Drawing.Point(167, 71);
            this.txtManu.Name = "txtManu";
            this.txtManu.Size = new System.Drawing.Size(101, 21);
            this.txtManu.TabIndex = 6;
            this.txtManu.Text = "Intel 14900K";
            // 
            // txtSN
            // 
            this.txtSN.AutoSize = true;
            this.txtSN.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSN.Location = new System.Drawing.Point(167, 111);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(101, 21);
            this.txtSN.TabIndex = 7;
            this.txtSN.Text = "Intel 14900K";
            // 
            // txtUse
            // 
            this.txtUse.AutoSize = true;
            this.txtUse.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUse.Location = new System.Drawing.Point(167, 154);
            this.txtUse.Name = "txtUse";
            this.txtUse.Size = new System.Drawing.Size(101, 21);
            this.txtUse.TabIndex = 9;
            this.txtUse.Text = "Intel 14900K";
            // 
            // CpuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.txtUse);
            this.Controls.Add(this.txtSN);
            this.Controls.Add(this.txtManu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label1);
            this.Name = "CpuForm";
            this.Text = "CpuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtManu;
        private System.Windows.Forms.Label txtSN;
        private System.Windows.Forms.Label txtUse;
    }
}