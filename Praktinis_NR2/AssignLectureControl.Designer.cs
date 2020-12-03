
namespace PraktinisNR2
{
    partial class AssignLectureControl
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
            this.usertableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.praktikanr2DataSet = new PraktinisNR2.praktikanr2DataSet();
            this.lecturetableBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.groupsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lecturesettableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lecturesettableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lecturesettableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lecturetableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usertableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupsTableAdapter = new PraktinisNR2.praktikanr2DataSetTableAdapters.groupsTableAdapter();
            this.usertableTableAdapter = new PraktinisNR2.praktikanr2DataSetTableAdapters.usertableTableAdapter();
            this.lecturetableTableAdapter = new PraktinisNR2.praktikanr2DataSetTableAdapters.lecturetableTableAdapter();
            this.lecturetableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lecturetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lecturetableBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.lecturesettableTableAdapter = new PraktinisNR2.praktikanr2DataSetTableAdapters.lecturesettableTableAdapter();
            this.lectureSetIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FKUserID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fKLectureIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fKGroupIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usertableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikanr2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturetableBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturesettableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturesettableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturesettableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturetableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usertableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturetableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturetableBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lectureSetIDDataGridViewTextBoxColumn,
            this.FKUserID,
            this.fKLectureIDDataGridViewTextBoxColumn,
            this.fKGroupIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lecturesettableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(428, 159);
            this.dataGridView1.TabIndex = 0;
            // 
            // usertableBindingSource1
            // 
            this.usertableBindingSource1.DataMember = "usertable";
            this.usertableBindingSource1.DataSource = this.praktikanr2DataSet;
            // 
            // praktikanr2DataSet
            // 
            this.praktikanr2DataSet.DataSetName = "praktikanr2DataSet";
            this.praktikanr2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lecturetableBindingSource4
            // 
            this.lecturetableBindingSource4.DataMember = "lecturetable";
            this.lecturetableBindingSource4.DataSource = this.praktikanr2DataSet;
            // 
            // groupsBindingSource1
            // 
            this.groupsBindingSource1.DataMember = "groups";
            this.groupsBindingSource1.DataSource = this.praktikanr2DataSet;
            // 
            // lecturesettableBindingSource
            // 
            this.lecturesettableBindingSource.DataMember = "lecturesettable";
            this.lecturesettableBindingSource.DataSource = this.praktikanr2DataSet;
            // 
            // lecturesettableBindingSource2
            // 
            this.lecturesettableBindingSource2.DataMember = "lecturesettable";
            this.lecturesettableBindingSource2.DataSource = this.praktikanr2DataSet;
            // 
            // lecturesettableBindingSource1
            // 
            this.lecturesettableBindingSource1.DataMember = "lecturesettable";
            this.lecturesettableBindingSource1.DataSource = this.praktikanr2DataSet;
            // 
            // lecturetableBindingSource2
            // 
            this.lecturetableBindingSource2.DataMember = "lecturetable";
            this.lecturetableBindingSource2.DataSource = this.praktikanr2DataSet;
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "groups";
            this.groupsBindingSource.DataSource = this.praktikanr2DataSet;
            // 
            // usertableBindingSource
            // 
            this.usertableBindingSource.DataMember = "usertable";
            this.usertableBindingSource.DataSource = this.praktikanr2DataSet;
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
            this.button1.Size = new System.Drawing.Size(428, 44);
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
            this.button2.Size = new System.Drawing.Size(428, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ištrinti Paskaita";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // usertableTableAdapter
            // 
            this.usertableTableAdapter.ClearBeforeFill = true;
            // 
            // lecturetableTableAdapter
            // 
            this.lecturetableTableAdapter.ClearBeforeFill = true;
            // 
            // lecturetableBindingSource1
            // 
            this.lecturetableBindingSource1.DataMember = "lecturetable";
            this.lecturetableBindingSource1.DataSource = this.praktikanr2DataSet;
            // 
            // lecturetableBindingSource
            // 
            this.lecturetableBindingSource.DataMember = "lecturetable";
            this.lecturetableBindingSource.DataSource = this.praktikanr2DataSet;
            // 
            // lecturetableBindingSource3
            // 
            this.lecturetableBindingSource3.DataMember = "lecturetable";
            this.lecturetableBindingSource3.DataSource = this.praktikanr2DataSet;
            // 
            // lecturesettableTableAdapter
            // 
            this.lecturesettableTableAdapter.ClearBeforeFill = true;
            // 
            // lectureSetIDDataGridViewTextBoxColumn
            // 
            this.lectureSetIDDataGridViewTextBoxColumn.DataPropertyName = "LectureSetID";
            this.lectureSetIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.lectureSetIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lectureSetIDDataGridViewTextBoxColumn.Name = "lectureSetIDDataGridViewTextBoxColumn";
            // 
            // FKUserID
            // 
            this.FKUserID.DataPropertyName = "FKUserID";
            this.FKUserID.DataSource = this.usertableBindingSource1;
            this.FKUserID.DisplayMember = "Pavarde";
            this.FKUserID.HeaderText = "Dėstytojas";
            this.FKUserID.MinimumWidth = 6;
            this.FKUserID.Name = "FKUserID";
            this.FKUserID.ValueMember = "PKUserID";
            // 
            // fKLectureIDDataGridViewTextBoxColumn
            // 
            this.fKLectureIDDataGridViewTextBoxColumn.DataPropertyName = "FKLectureID";
            this.fKLectureIDDataGridViewTextBoxColumn.DataSource = this.lecturetableBindingSource4;
            this.fKLectureIDDataGridViewTextBoxColumn.DisplayMember = "Lecture_Name";
            this.fKLectureIDDataGridViewTextBoxColumn.HeaderText = "Paskaita";
            this.fKLectureIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fKLectureIDDataGridViewTextBoxColumn.Name = "fKLectureIDDataGridViewTextBoxColumn";
            this.fKLectureIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fKLectureIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fKLectureIDDataGridViewTextBoxColumn.ValueMember = "Lecture_Name";
            // 
            // fKGroupIDDataGridViewTextBoxColumn
            // 
            this.fKGroupIDDataGridViewTextBoxColumn.DataPropertyName = "FKGroupID";
            this.fKGroupIDDataGridViewTextBoxColumn.DataSource = this.groupsBindingSource1;
            this.fKGroupIDDataGridViewTextBoxColumn.DisplayMember = "GroupName";
            this.fKGroupIDDataGridViewTextBoxColumn.HeaderText = "Grupes Pavadinimas";
            this.fKGroupIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fKGroupIDDataGridViewTextBoxColumn.Name = "fKGroupIDDataGridViewTextBoxColumn";
            this.fKGroupIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fKGroupIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fKGroupIDDataGridViewTextBoxColumn.ValueMember = "PKGroupID";
            // 
            // AssignLectureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AssignLectureControl";
            this.Size = new System.Drawing.Size(428, 292);
            this.Load += new System.EventHandler(this.LectureControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usertableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikanr2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturetableBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturesettableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturesettableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturesettableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturetableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usertableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturetableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturetableBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource lecturetableBindingSource;
        private praktikanr2DataSet praktikanr2DataSet;
        private System.Windows.Forms.BindingSource lecturetableBindingSource1;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private System.Windows.Forms.BindingSource usertableBindingSource;
        private System.Windows.Forms.BindingSource lecturesettableBindingSource;
        private praktikanr2DataSetTableAdapters.groupsTableAdapter groupsTableAdapter;
        private praktikanr2DataSetTableAdapters.usertableTableAdapter usertableTableAdapter;
        private System.Windows.Forms.BindingSource lecturetableBindingSource2;
        private praktikanr2DataSetTableAdapters.lecturetableTableAdapter lecturetableTableAdapter;
        private System.Windows.Forms.BindingSource lecturetableBindingSource4;
        private System.Windows.Forms.BindingSource groupsBindingSource1;
        private System.Windows.Forms.BindingSource usertableBindingSource1;
        private System.Windows.Forms.BindingSource lecturesettableBindingSource1;
        private System.Windows.Forms.BindingSource lecturetableBindingSource3;
        private praktikanr2DataSetTableAdapters.lecturesettableTableAdapter lecturesettableTableAdapter;
        private System.Windows.Forms.BindingSource lecturesettableBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lectureSetIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn FKUserID;
        private System.Windows.Forms.DataGridViewComboBoxColumn fKLectureIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn fKGroupIDDataGridViewTextBoxColumn;
    }
}
