
namespace PraktinisNR2
{
    partial class userTable
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.vardasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pavardeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elpastasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slaptazodisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKGroupIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.praktikanr2DataSet = new PraktinisNR2.praktikanr2DataSet();
            this.usertableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usertableTableAdapter = new PraktinisNR2.praktikanr2DataSetTableAdapters.usertableTableAdapter();
            this.groupsTableAdapter = new PraktinisNR2.praktikanr2DataSetTableAdapters.groupsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikanr2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usertableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vardasDataGridViewTextBoxColumn,
            this.pavardeDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.elpastasDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.slaptazodisDataGridViewTextBoxColumn,
            this.fKGroupIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usertableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(931, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(422, 136);
            this.button1.TabIndex = 1;
            this.button1.Text = "Trinti vartotojus";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(521, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(399, 136);
            this.button2.TabIndex = 2;
            this.button2.Text = "Patvirtinti pakeitimus/idejimus";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // vardasDataGridViewTextBoxColumn
            // 
            this.vardasDataGridViewTextBoxColumn.DataPropertyName = "Vardas";
            this.vardasDataGridViewTextBoxColumn.HeaderText = "Vardas";
            this.vardasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vardasDataGridViewTextBoxColumn.Name = "vardasDataGridViewTextBoxColumn";
            this.vardasDataGridViewTextBoxColumn.Width = 125;
            // 
            // pavardeDataGridViewTextBoxColumn
            // 
            this.pavardeDataGridViewTextBoxColumn.DataPropertyName = "Pavarde";
            this.pavardeDataGridViewTextBoxColumn.HeaderText = "Pavardė";
            this.pavardeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pavardeDataGridViewTextBoxColumn.Name = "pavardeDataGridViewTextBoxColumn";
            this.pavardeDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Rolė";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // elpastasDataGridViewTextBoxColumn
            // 
            this.elpastasDataGridViewTextBoxColumn.DataPropertyName = "el_pastas";
            this.elpastasDataGridViewTextBoxColumn.HeaderText = "el_pastas";
            this.elpastasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.elpastasDataGridViewTextBoxColumn.Name = "elpastasDataGridViewTextBoxColumn";
            this.elpastasDataGridViewTextBoxColumn.Width = 125;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Slapyvardis";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // slaptazodisDataGridViewTextBoxColumn
            // 
            this.slaptazodisDataGridViewTextBoxColumn.DataPropertyName = "Slaptazodis";
            this.slaptazodisDataGridViewTextBoxColumn.HeaderText = "Slaptažodis";
            this.slaptazodisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.slaptazodisDataGridViewTextBoxColumn.Name = "slaptazodisDataGridViewTextBoxColumn";
            this.slaptazodisDataGridViewTextBoxColumn.Width = 125;
            // 
            // fKGroupIDDataGridViewTextBoxColumn
            // 
            this.fKGroupIDDataGridViewTextBoxColumn.DataPropertyName = "FKGroupID";
            this.fKGroupIDDataGridViewTextBoxColumn.DataSource = this.groupsBindingSource;
            this.fKGroupIDDataGridViewTextBoxColumn.DisplayMember = "GroupName";
            this.fKGroupIDDataGridViewTextBoxColumn.HeaderText = "Grupė";
            this.fKGroupIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fKGroupIDDataGridViewTextBoxColumn.Name = "fKGroupIDDataGridViewTextBoxColumn";
            this.fKGroupIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fKGroupIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fKGroupIDDataGridViewTextBoxColumn.ValueMember = "PKGroupID";
            this.fKGroupIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "groups";
            this.groupsBindingSource.DataSource = this.praktikanr2DataSet;
            // 
            // praktikanr2DataSet
            // 
            this.praktikanr2DataSet.DataSetName = "praktikanr2DataSet";
            this.praktikanr2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usertableBindingSource
            // 
            this.usertableBindingSource.DataMember = "usertable";
            this.usertableBindingSource.DataSource = this.praktikanr2DataSet;
            // 
            // usertableTableAdapter
            // 
            this.usertableTableAdapter.ClearBeforeFill = true;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // userTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "userTable";
            this.Text = "userTable";
            this.Load += new System.EventHandler(this.userTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikanr2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usertableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private praktikanr2DataSet praktikanr2DataSet;
        private System.Windows.Forms.BindingSource usertableBindingSource;
        private praktikanr2DataSetTableAdapters.usertableTableAdapter usertableTableAdapter;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private praktikanr2DataSetTableAdapters.groupsTableAdapter groupsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn vardasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pavardeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elpastasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slaptazodisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn fKGroupIDDataGridViewTextBoxColumn;
    }
}