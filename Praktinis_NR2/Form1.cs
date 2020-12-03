using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SQLData;
namespace PraktinisNR2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //SQLData.SQLQuery.connectToSql();
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SQLQuery.LoginwithSql(textBox1.Text, textBox2.Text))
            {
                LoggedInWindow a = new LoggedInWindow(textBox1.Text);
                a.Show();
            }
        }
    }
}
