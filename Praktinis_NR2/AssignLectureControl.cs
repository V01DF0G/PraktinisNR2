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
    public partial class AssignLectureControl : UserControl
    {
        public AssignLectureControl()
        {
            this.Dock = DockStyle.Fill;
            InitializeComponent();
            this.lecturesettableTableAdapter.Fill(this.praktikanr2DataSet.lecturesettable);
            this.groupsTableAdapter.Fill(this.praktikanr2DataSet.groups);
            this.usertableTableAdapter.Fill(this.praktikanr2DataSet.usertable);
            this.lecturetableTableAdapter.Fill(this.praktikanr2DataSet.lecturetable);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lecturesettableTableAdapter.Adapter.Update(this.praktikanr2DataSet.lecturesettable);
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[i].Index);
            }
            this.lecturesettableTableAdapter.Adapter.Update(this.praktikanr2DataSet.lecturesettable);
            dataGridView1.Update();
        }

        private void LectureControl_Load(object sender, EventArgs e)
        {

        }
    }
}
