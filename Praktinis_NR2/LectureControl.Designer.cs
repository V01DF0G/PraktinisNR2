
namespace PraktinisNR2
{
    partial class LectureControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.marksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.praktikanr2DataSet = new PraktinisNR2.praktikanr2DataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lecturetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marksTableAdapter = new PraktinisNR2.praktikanr2DataSetTableAdapters.marksTableAdapter();
            this.tableAdapterManager = new PraktinisNR2.praktikanr2DataSetTableAdapters.TableAdapterManager();
            this.lecturetableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lecturetableTableAdapter = new PraktinisNR2.praktikanr2DataSetTableAdapters.lecturetableTableAdapter();
            this.lectureNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikanr2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturetableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lectureNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lecturetableBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(448, 159);
            this.dataGridView1.TabIndex = 0;
            // 
            // marksBindingSource
            // 
            this.marksBindingSource.DataMember = "marks";
            this.marksBindingSource.DataSource = this.praktikanr2DataSet;
            // 
            // praktikanr2DataSet
            // 
            this.praktikanr2DataSet.DataSetName = "praktikanr2DataSet";
            this.praktikanr2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(0, 211);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(448, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Patvirtinti pakeitimus";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button2.Location = new System.Drawing.Point(0, 161);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(448, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ištrinti Paskaita";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lecturetableBindingSource
            // 
            this.lecturetableBindingSource.DataMember = "lecturetable";
            this.lecturetableBindingSource.DataSource = this.praktikanr2DataSet;
            // 
            // marksTableAdapter
            // 
            this.marksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.groupsTableAdapter = null;
            this.tableAdapterManager.lecturesettableTableAdapter = null;
            this.tableAdapterManager.lecturetableTableAdapter = null;
            this.tableAdapterManager.marksTableAdapter = this.marksTableAdapter;
            this.tableAdapterManager.UpdateOrder = PraktinisNR2.praktikanr2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usertableTableAdapter = null;
            // 
            // lecturetableBindingSource1
            // 
            this.lecturetableBindingSource1.DataMember = "lecturetable";
            this.lecturetableBindingSource1.DataSource = this.praktikanr2DataSet;
            // 
            // lecturetableTableAdapter
            // 
            this.lecturetableTableAdapter.ClearBeforeFill = true;
            // 
            // lectureNameDataGridViewTextBoxColumn
            // 
            this.lectureNameDataGridViewTextBoxColumn.DataPropertyName = "Lecture_Name";
            this.lectureNameDataGridViewTextBoxColumn.HeaderText = "Paskaitos pavadinimas";
            this.lectureNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lectureNameDataGridViewTextBoxColumn.Name = "lectureNameDataGridViewTextBoxColumn";
            // 
            // LectureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LectureControl";
            this.Size = new System.Drawing.Size(448, 292);
            this.Load += new System.EventHandler(this.LectureControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikanr2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturetableBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource lecturetableBindingSource;
        private praktikanr2DataSet praktikanr2DataSet;
        private praktikanr2DataSetTableAdapters.marksTableAdapter marksTableAdapter;
        private praktikanr2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource marksBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn lectureNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lecturetableBindingSource1;
        private praktikanr2DataSetTableAdapters.lecturetableTableAdapter lecturetableTableAdapter;
    }
}
