namespace WindowsFormsApp
{
    partial class MainForm
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
            this.btnEx7_5 = new System.Windows.Forms.Button();
            this.btnEx7_6 = new System.Windows.Forms.Button();
            this.btnCh7_6_2 = new System.Windows.Forms.Button();
            this.btnCh7_6_3 = new System.Windows.Forms.Button();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.btnDateTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEx7_5
            // 
            this.btnEx7_5.Location = new System.Drawing.Point(23, 46);
            this.btnEx7_5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEx7_5.Name = "btnEx7_5";
            this.btnEx7_5.Size = new System.Drawing.Size(211, 98);
            this.btnEx7_5.TabIndex = 0;
            this.btnEx7_5.Text = "PaintEventApp 열기\r\n\r\n예제 7-5";
            this.btnEx7_5.UseVisualStyleBackColor = true;
            this.btnEx7_5.Click += new System.EventHandler(this.btnEx7_5_Click);
            // 
            // btnEx7_6
            // 
            this.btnEx7_6.Location = new System.Drawing.Point(23, 165);
            this.btnEx7_6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEx7_6.Name = "btnEx7_6";
            this.btnEx7_6.Size = new System.Drawing.Size(211, 156);
            this.btnEx7_6.TabIndex = 1;
            this.btnEx7_6.Text = "MoveResizeApp 열기\r\n\r\n예제 7-6\r\n연습문제 7.6 (1)\r\n";
            this.btnEx7_6.UseVisualStyleBackColor = true;
            this.btnEx7_6.Click += new System.EventHandler(this.btnEx7_6_Click);
            // 
            // btnCh7_6_2
            // 
            this.btnCh7_6_2.Location = new System.Drawing.Point(254, 46);
            this.btnCh7_6_2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCh7_6_2.Name = "btnCh7_6_2";
            this.btnCh7_6_2.Size = new System.Drawing.Size(229, 98);
            this.btnCh7_6_2.TabIndex = 3;
            this.btnCh7_6_2.Text = "Form2 열기\r\n\r\n연습문제 7.6 (2)";
            this.btnCh7_6_2.UseVisualStyleBackColor = true;
            this.btnCh7_6_2.Click += new System.EventHandler(this.btnCh7_6_2_Click);
            // 
            // btnCh7_6_3
            // 
            this.btnCh7_6_3.Location = new System.Drawing.Point(254, 165);
            this.btnCh7_6_3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCh7_6_3.Name = "btnCh7_6_3";
            this.btnCh7_6_3.Size = new System.Drawing.Size(229, 156);
            this.btnCh7_6_3.TabIndex = 4;
            this.btnCh7_6_3.Text = "Form3 열기\r\n\r\n연습문제 7.6 (3)\r\n연습문제 7.6 (4)\r\n연습문제 7.6 (5)\r\n";
            this.btnCh7_6_3.UseVisualStyleBackColor = true;
            this.btnCh7_6_3.Click += new System.EventHandler(this.btnCh7_6_3_Click);
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(211, 398);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(97, 15);
            this.labelDateTime.TabIndex = 5;
            this.labelDateTime.Text = "labelDateTime";
            // 
            // btnDateTime
            // 
            this.btnDateTime.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDateTime.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDateTime.Location = new System.Drawing.Point(23, 361);
            this.btnDateTime.Name = "btnDateTime";
            this.btnDateTime.Size = new System.Drawing.Size(164, 88);
            this.btnDateTime.TabIndex = 6;
            this.btnDateTime.Text = "현재시각 갱신\r\n\r\n연습문제 7.6 (6)";
            this.btnDateTime.UseVisualStyleBackColor = false;
            this.btnDateTime.Click += new System.EventHandler(this.btnDateTime_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 477);
            this.Controls.Add(this.btnDateTime);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.btnCh7_6_3);
            this.Controls.Add(this.btnCh7_6_2);
            this.Controls.Add(this.btnEx7_6);
            this.Controls.Add(this.btnEx7_5);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEx7_5;
        private System.Windows.Forms.Button btnEx7_6;
        private System.Windows.Forms.Button btnCh7_6_2;
        private System.Windows.Forms.Button btnCh7_6_3;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Button btnDateTime;
    }
}

