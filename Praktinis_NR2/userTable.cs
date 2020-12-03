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
    public partial class userTable : Form
    {
        public userTable()
        {
            InitializeComponent();
        }

        private void userTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'praktikanr2DataSet.groups' table. You can move, or remove it, as needed.
            this.groupsTableAdapter.Fill(this.praktikanr2DataSet.groups);
            // TODO: This line of code loads data into the 'praktikanr2DataSet.usertable' table. You can move, or remove it, as needed.
            this.usertableTableAdapter.Fill(this.praktikanr2DataSet.usertable);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.usertableTableAdapter.Adapter.Update(this.praktikanr2DataSet.usertable);
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[i].Index);
            }
            this.usertableTableAdapter.Adapter.Update(this.praktikanr2DataSet.usertable);
            dataGridView1.Update();
        }
    }
}
