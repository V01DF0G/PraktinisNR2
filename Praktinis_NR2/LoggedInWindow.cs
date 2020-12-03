using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using SQLData;

namespace PraktinisNR2
{
    public partial class LoggedInWindow : Form
    {
        DataTable usertable = new DataTable();
        public static int UserID;
        public LoggedInWindow(string Username)
        {
            InitializeComponent();
            SQLQuery.InsertDataFromSql(Username, ref usertable);
            UserID = (int)usertable.Rows[0][0];
            name.Text = usertable.Rows[0][1].ToString();
            surname.Text = usertable.Rows[0][2].ToString();
            email.Text = usertable.Rows[0][4].ToString();
            username.Text = usertable.Rows[0][5].ToString();
            role.Text = usertable.Rows[0][3].ToString();


            if(role.Text == "Admin")
            {
                tableLayoutPanel1.Controls.Add(new AdminControls(ref panel1));
            }
            if (role.Text == "Lecturer")
            {
                tableLayoutPanel1.Controls.Add(new LecturerControl(ref panel1));
            }
            if (role.Text == "Student")
            {
                tableLayoutPanel1.Controls.Add(new StudentControl(ref panel1));
            }
        }

        private void name_Click(object sender, EventArgs e)
        {

        }
    }
}
