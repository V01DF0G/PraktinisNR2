using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SQLData;

namespace PraktinisNR2
{
    public partial class GroupControl : UserControl
    {
        public GroupControl()
        {
            this.Dock = DockStyle.Fill;
            InitializeComponent();
            dataGridView1.DataSource = SQLQuery.ListGroups();
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[0].HeaderText = "Grupes_ID";
            dataGridView1.Columns[1].HeaderText = "Grupes_Pavadinimas";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLQuery.UpdateTable("groups",dataGridView1);
            dataGridView1.DataSource = SQLQuery.ListGroups();
            dataGridView1.Update();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            for(int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[i].Index);
            }
            SQLQuery.UpdateTable("groups",dataGridView1);
            dataGridView1.DataSource = SQLQuery.ListGroups();
            dataGridView1.Update();
        }
    }
}
