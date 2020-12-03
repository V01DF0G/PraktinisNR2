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
    public partial class LectureControl : UserControl
    {
        public LectureControl()
        {
            this.Dock = DockStyle.Fill;
            InitializeComponent();
            this.lecturetableTableAdapter.Fill(this.praktikanr2DataSet.lecturetable);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lecturetableTableAdapter.Adapter.Update(this.praktikanr2DataSet.lecturetable);
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[i].Index);
            }
            this.lecturetableTableAdapter.Adapter.Update(this.praktikanr2DataSet.lecturetable);
            dataGridView1.Update();
        }

        private void LectureControl_Load(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.marksTableAdapter.FillBy(this.praktikanr2DataSet.marks);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
