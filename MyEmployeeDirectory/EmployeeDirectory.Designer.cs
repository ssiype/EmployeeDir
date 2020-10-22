namespace MyEmployeeDirectory
{
    partial class EmployeeDirectory
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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.rTxtBxDirLabel = new System.Windows.Forms.RichTextBox();
            this.tblLayPanbtns = new System.Windows.Forms.TableLayoutPanel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tableLayoutPanelEmpInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.RichTextBox();
            this.txtBxTitle = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.myEmployeeDBDataSet = new MyEmployeeDirectory.MyEmployeeDBDataSet();
            this.employeeInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeInfoTableAdapter = new MyEmployeeDirectory.MyEmployeeDBDataSetTableAdapters.EmployeeInfoTableAdapter();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tblLayPanbtns.SuspendLayout();
            this.tableLayoutPanelEmpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myEmployeeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tableLayoutPanelMain.ColumnCount = 3;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.3401F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.46193F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.19797F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Controls.Add(this.rTxtBxDirLabel, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tblLayPanbtns, 1, 5);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelEmpInfo, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.dataGridView1, 1, 3);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 7;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.06982F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.93412F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.267453F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.13962F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.06981F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.25172F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.267453F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanelMain.TabIndex = 0;

            // 
            // rTxtBxDirLabel
            // 
            this.rTxtBxDirLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTxtBxDirLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtBxDirLabel.Location = new System.Drawing.Point(117, 3);
            this.rTxtBxDirLabel.Multiline = false;
            this.rTxtBxDirLabel.Name = "rTxtBxDirLabel";
            this.rTxtBxDirLabel.ReadOnly = true;
            this.rTxtBxDirLabel.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rTxtBxDirLabel.Size = new System.Drawing.Size(573, 52);
            this.rTxtBxDirLabel.TabIndex = 6;
            this.rTxtBxDirLabel.Text = "Employee Directory";
            // 
            // tblLayPanbtns
            // 
            this.tblLayPanbtns.ColumnCount = 3;
            this.tblLayPanbtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tblLayPanbtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tblLayPanbtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tblLayPanbtns.Controls.Add(this.btnUpdate, 1, 0);
            this.tblLayPanbtns.Controls.Add(this.btnDelete, 2, 0);
            this.tblLayPanbtns.Controls.Add(this.btnInsert, 0, 0);
            this.tblLayPanbtns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayPanbtns.Location = new System.Drawing.Point(117, 339);
            this.tblLayPanbtns.Name = "tblLayPanbtns";
            this.tblLayPanbtns.RowCount = 1;
            this.tblLayPanbtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayPanbtns.Size = new System.Drawing.Size(573, 89);
            this.tblLayPanbtns.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.Location = new System.Drawing.Point(192, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(188, 83);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Location = new System.Drawing.Point(386, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(184, 83);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInsert.Location = new System.Drawing.Point(3, 3);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(183, 83);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tableLayoutPanelEmpInfo
            // 
            this.tableLayoutPanelEmpInfo.ColumnCount = 2;
            this.tableLayoutPanelEmpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelEmpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelEmpInfo.Controls.Add(this.lblEmpName, 0, 0);
            this.tableLayoutPanelEmpInfo.Controls.Add(this.lblJobTitle, 0, 1);
            this.tableLayoutPanelEmpInfo.Controls.Add(this.txtBxName, 1, 0);
            this.tableLayoutPanelEmpInfo.Controls.Add(this.txtBxTitle, 1, 1);
            this.tableLayoutPanelEmpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelEmpInfo.Location = new System.Drawing.Point(117, 61);
            this.tableLayoutPanelEmpInfo.Name = "tableLayoutPanelEmpInfo";
            this.tableLayoutPanelEmpInfo.RowCount = 2;
            this.tableLayoutPanelEmpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelEmpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelEmpInfo.Size = new System.Drawing.Size(573, 83);
            this.tableLayoutPanelEmpInfo.TabIndex = 7;
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpName.Location = new System.Drawing.Point(3, 0);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(165, 41);
            this.lblEmpName.TabIndex = 2;
            this.lblEmpName.Text = "Name";
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblJobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobTitle.Location = new System.Drawing.Point(3, 41);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(165, 42);
            this.lblJobTitle.TabIndex = 3;
            this.lblJobTitle.Text = "Job Title";
            // 
            // txtBxName
            // 
            this.txtBxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxName.Location = new System.Drawing.Point(174, 3);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtBxName.Size = new System.Drawing.Size(396, 35);
            this.txtBxName.TabIndex = 4;
            this.txtBxName.Text = "";
            // 
            // txtBxTitle
            // 
            this.txtBxTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBxTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxTitle.Location = new System.Drawing.Point(174, 44);
            this.txtBxTitle.Name = "txtBxTitle";
            this.txtBxTitle.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtBxTitle.Size = new System.Drawing.Size(396, 36);
            this.txtBxTitle.TabIndex = 5;
            this.txtBxTitle.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameCol,
            this.TitleCol,
            this.ColId});
            this.dataGridView1.DataSource = this.employeeInfoBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(117, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.tableLayoutPanelMain.SetRowSpan(this.dataGridView1, 2);
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(573, 169);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // NameCol
            // 
            this.NameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameCol.DataPropertyName = "EmployeeName";
            this.NameCol.HeaderText = "Name";
            this.NameCol.MinimumWidth = 8;
            this.NameCol.Name = "NameCol";
            // 
            // TitleCol
            // 
            this.TitleCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TitleCol.DataPropertyName = "JobTitle";
            this.TitleCol.HeaderText = "Job Title";
            this.TitleCol.MinimumWidth = 8;
            this.TitleCol.Name = "TitleCol";
            // 
            // ColId
            // 
            this.ColId.DataPropertyName = "Id";
            this.ColId.HeaderText = "Id";
            this.ColId.MinimumWidth = 8;
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Visible = false;
            this.ColId.Width = 150;
            // 
            // employeeInfoBindingSource1
            // 
            this.employeeInfoBindingSource1.DataMember = "EmployeeInfo";
            this.employeeInfoBindingSource1.DataSource = this.myEmployeeDBDataSet;
            // 
            // myEmployeeDBDataSet
            // 
            this.myEmployeeDBDataSet.DataSetName = "MyEmployeeDBDataSet";
            this.myEmployeeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeInfoBindingSource
            // 
            this.employeeInfoBindingSource.DataMember = "EmployeeInfo";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            // 
            // employeeInfoTableAdapter
            // 
            this.employeeInfoTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "EmployeeDirectory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Directory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeDirectory_FormClosed);
            this.Load += new System.EventHandler(this.EmployeeDirectory_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tblLayPanbtns.ResumeLayout(false);
            this.tableLayoutPanelEmpInfo.ResumeLayout(false);
            this.tableLayoutPanelEmpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myEmployeeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tblLayPanbtns;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.BindingSource employeesBindingSource;

        
        private System.Windows.Forms.BindingSource employeeInfoBindingSource;
        private MyEmployeeDBDataSet myEmployeeDBDataSet;
        private System.Windows.Forms.BindingSource employeeInfoBindingSource1;
        private MyEmployeeDBDataSetTableAdapters.EmployeeInfoTableAdapter employeeInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.RichTextBox rTxtBxDirLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelEmpInfo;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.RichTextBox txtBxName;
        private System.Windows.Forms.RichTextBox txtBxTitle;
    }
}

