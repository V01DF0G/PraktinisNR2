using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PraktinisNR2
{
    public partial class AdminControls : UserControl
    {
        public Panel das;
        Form _form = new userTable();
        public AdminControls(ref Panel asd)
        {
            InitializeComponent();
            das = asd;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            das.Controls.Clear();
            das.Controls.Add(new GroupControl());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            das.Controls.Clear();
            das.Controls.Add(new LectureControl());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            das.Controls.Clear();
            das.Controls.Add(new AssignLectureControl());
        }
    }
}
