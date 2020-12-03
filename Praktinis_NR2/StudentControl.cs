using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktinisNR2
{
    public partial class StudentControl : UserControl
    {
        public Panel das;
        public StudentControl(ref Panel asd)
        {
            InitializeComponent();
            das = asd;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            das.Controls.Clear();
            das.Controls.Add(new MarkView());
        }
    }
}
