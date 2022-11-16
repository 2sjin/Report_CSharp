namespace WindowsFormsApp1116 {
    partial class Form1 {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.예제96ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.예제97ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.장ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 장ToolStripMenuItem
            // 
            this.장ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.예제96ToolStripMenuItem,
            this.예제97ToolStripMenuItem,
            this.toolStripMenuItem1});
            this.장ToolStripMenuItem.Name = "장ToolStripMenuItem";
            this.장ToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.장ToolStripMenuItem.Text = "9장";
            // 
            // 예제96ToolStripMenuItem
            // 
            this.예제96ToolStripMenuItem.Name = "예제96ToolStripMenuItem";
            this.예제96ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.예제96ToolStripMenuItem.Text = "예제 9-6";
            this.예제96ToolStripMenuItem.Click += new System.EventHandler(this.예제96ToolStripMenuItem_Click);
            // 
            // 예제97ToolStripMenuItem
            // 
            this.예제97ToolStripMenuItem.Name = "예제97ToolStripMenuItem";
            this.예제97ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.예제97ToolStripMenuItem.Text = "예제 9-7";
            this.예제97ToolStripMenuItem.Click += new System.EventHandler(this.예제97ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 예제96ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 예제97ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}

