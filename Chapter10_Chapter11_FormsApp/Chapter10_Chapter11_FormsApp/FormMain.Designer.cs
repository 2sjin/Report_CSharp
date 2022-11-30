namespace Chapter10_Chapter11_FormsApp {
    partial class FormMain {
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
            this.예제자유ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.예제109ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wkdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.예제118ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.학생관리프로그램ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.장ToolStripMenuItem,
            this.wkdToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(508, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 장ToolStripMenuItem
            // 
            this.장ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.예제자유ToolStripMenuItem,
            this.예제109ToolStripMenuItem});
            this.장ToolStripMenuItem.Name = "장ToolStripMenuItem";
            this.장ToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.장ToolStripMenuItem.Text = "10장";
            // 
            // 예제자유ToolStripMenuItem
            // 
            this.예제자유ToolStripMenuItem.Name = "예제자유ToolStripMenuItem";
            this.예제자유ToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.예제자유ToolStripMenuItem.Text = "예제 10-4 변형";
            this.예제자유ToolStripMenuItem.Click += new System.EventHandler(this.예제104ToolStripMenuItem_Click);
            // 
            // 예제109ToolStripMenuItem
            // 
            this.예제109ToolStripMenuItem.Name = "예제109ToolStripMenuItem";
            this.예제109ToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.예제109ToolStripMenuItem.Text = "예제 10-9";
            this.예제109ToolStripMenuItem.Click += new System.EventHandler(this.예제109ToolStripMenuItem_Click);
            // 
            // wkdToolStripMenuItem
            // 
            this.wkdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.예제118ToolStripMenuItem,
            this.학생관리프로그램ToolStripMenuItem});
            this.wkdToolStripMenuItem.Name = "wkdToolStripMenuItem";
            this.wkdToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.wkdToolStripMenuItem.Text = "11장";
            // 
            // 예제118ToolStripMenuItem
            // 
            this.예제118ToolStripMenuItem.Name = "예제118ToolStripMenuItem";
            this.예제118ToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.예제118ToolStripMenuItem.Text = "예제 11-8";
            this.예제118ToolStripMenuItem.Click += new System.EventHandler(this.예제118ToolStripMenuItem_Click);
            // 
            // 학생관리프로그램ToolStripMenuItem
            // 
            this.학생관리프로그램ToolStripMenuItem.Name = "학생관리프로그램ToolStripMenuItem";
            this.학생관리프로그램ToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.학생관리프로그램ToolStripMenuItem.Text = "학생관리 프로그램(파일 처리)";
            this.학생관리프로그램ToolStripMenuItem.Click += new System.EventHandler(this.학생관리프로그램ToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 75);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(484, 247);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "예제 9-9는 메인 From에 구현하였습니다.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(484, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "글꼴 변경";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "9장 보충(예제 9-9)";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 393);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 예제109ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 예제자유ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem wkdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 예제118ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 학생관리프로그램ToolStripMenuItem;
    }
}

