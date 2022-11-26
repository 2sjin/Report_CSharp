using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter10_Chapter11_FormsApp {
    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();
        }

        private void 예제104ToolStripMenuItem_Click(object sender, EventArgs e) {
            Form10_4 frm10_4 = new Form10_4();
            frm10_4.ShowDialog();
        }

        private void 예제109ToolStripMenuItem_Click(object sender, EventArgs e) {
            Form10_9 frm10_9 = new Form10_9();
            frm10_9.ShowDialog();
        }

        private void 예제118ToolStripMenuItem_Click(object sender, EventArgs e) {
            Form11_8 frm11_8 = new Form11_8();
            frm11_8.ShowDialog();
        }


        private void 학생관리프로그램ToolStripMenuItem_Click(object sender, EventArgs e) {
            FormStudentManager frmStdManager = new FormStudentManager();
            frmStdManager.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) {
            FontDialog fontDialog1 = new FontDialog();
            fontDialog1.ShowColor = true;       // 색상 선택 콤보박스 활성화 
            // fontDialog1.ShowApply = true;    // 적용 버튼 활성화 
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
            textBox1.ForeColor = fontDialog1.Color;
        }
    }
}
