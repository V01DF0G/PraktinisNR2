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
    public partial class MarkControl : UserControl
    {
        public MarkControl()
        {
            this.Dock = DockStyle.Fill;
            InitializeComponent();
            this.dataGridView1.DataSource = (this.praktikanr2DataSet.marks);
            this.marksTableAdapter.FillByLecturerID(this.praktikanr2DataSet.marks, LoggedInWindow.UserID);
            //this.groupsTableAdapter.Fill(this.praktikanr2DataSet.groups);
            this.usertableTableAdapter.Fill(this.praktikanr2DataSet.usertable);
            this.lecturesettableTableAdapter.Fill(this.praktikanr2DataSet.lecturesettable);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.marksTableAdapter.Adapter.Update(this.praktikanr2DataSet.marks);
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[i].Index);
            }
            this.marksTableAdapter.Adapter.Update(this.praktikanr2DataSet.marks);
            dataGridView1.Update();
        }

        private void LectureControl_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //this.marksTableAdapter.FillByLecturerID(this.praktikanr2DataSet.marks, new System.Nullable<int>(((int)(System.Convert.ChangeType(valueToolStripTextBox.Text, typeof(int))))));


    }
}
