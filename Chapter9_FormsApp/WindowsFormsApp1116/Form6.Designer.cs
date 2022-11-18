namespace WindowsFormsApp1116 {
    partial class Form6 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnFileDialog = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnColorDialog = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(16, 23);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(460, 261);
            this.txtContent.TabIndex = 0;
            // 
            // btnFileDialog
            // 
            this.btnFileDialog.Location = new System.Drawing.Point(190, 346);
            this.btnFileDialog.Name = "btnFileDialog";
            this.btnFileDialog.Size = new System.Drawing.Size(107, 37);
            this.btnFileDialog.TabIndex = 1;
            this.btnFileDialog.Text = "파일 열기";
            this.btnFileDialog.UseVisualStyleBackColor = true;
            this.btnFileDialog.Click += new System.EventHandler(this.btnFileDialog_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 65);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 19);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "적용 버튼";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Controls.Add(this.txtContent);
            this.groupBox1.Controls.Add(this.btnFileDialog);
            this.groupBox1.Location = new System.Drawing.Point(28, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 407);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "연습문제 9.6 (4)";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(16, 300);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(460, 25);
            this.txtPath.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnColorDialog);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(568, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 407);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "연습문제 9.6 (5)";
            // 
            // btnColorDialog
            // 
            this.btnColorDialog.Location = new System.Drawing.Point(19, 331);
            this.btnColorDialog.Name = "btnColorDialog";
            this.btnColorDialog.Size = new System.Drawing.Size(131, 52);
            this.btnColorDialog.TabIndex = 4;
            this.btnColorDialog.Text = "글꼴 대화상자\r\n열기";
            this.btnColorDialog.UseVisualStyleBackColor = true;
            this.btnColorDialog.Click += new System.EventHandler(this.btnColorDialog_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(19, 108);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(109, 19);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "색 콤보박스";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 459);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnFileDialog;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnColorDialog;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox txtPath;
    }
}