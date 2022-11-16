namespace WindowsFormsApp {
    partial class Form2App {
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBringToFront = new System.Windows.Forms.Button();
            this.btnSendToBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Location = new System.Drawing.Point(77, 57);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(366, 110);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(215, 100);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(298, 99);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AliceBlue;
            this.button3.Location = new System.Drawing.Point(247, 131);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(403, 132);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnBringToFront
            // 
            this.btnBringToFront.Location = new System.Drawing.Point(77, 345);
            this.btnBringToFront.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBringToFront.Name = "btnBringToFront";
            this.btnBringToFront.Size = new System.Drawing.Size(245, 55);
            this.btnBringToFront.TabIndex = 3;
            this.btnBringToFront.Text = "BringToFront";
            this.btnBringToFront.UseVisualStyleBackColor = true;
            this.btnBringToFront.Click += new System.EventHandler(this.btnBringToFront_Click);
            // 
            // btnSendToBack
            // 
            this.btnSendToBack.Location = new System.Drawing.Point(405, 345);
            this.btnSendToBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSendToBack.Name = "btnSendToBack";
            this.btnSendToBack.Size = new System.Drawing.Size(245, 55);
            this.btnSendToBack.TabIndex = 4;
            this.btnSendToBack.Text = "SendToBack";
            this.btnSendToBack.UseVisualStyleBackColor = true;
            this.btnSendToBack.Click += new System.EventHandler(this.btnSendToBack_Click);
            // 
            // Form2App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 445);
            this.Controls.Add(this.btnSendToBack);
            this.Controls.Add(this.btnBringToFront);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2App";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBringToFront;
        private System.Windows.Forms.Button btnSendToBack;
    }
}