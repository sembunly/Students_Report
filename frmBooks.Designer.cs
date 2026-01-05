namespace School_Report
{
    partial class frmBooks
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.staffsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hOMEWORKDataSet = new School_Report.HOMEWORKDataSet();
            this.TeachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.studentsTableAdapter = new School_Report.HOMEWORKDataSetTableAdapters.StudentsTableAdapter();
            this.hOMEWORKDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter = new School_Report.HOMEWORKDataSetTableAdapters.TeachersTableAdapter();
            this.StaffsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffsTableAdapter = new School_Report.HOMEWORKDataSetTableAdapters.StaffsTableAdapter();
            this.BooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new School_Report.HOMEWORKDataSetTableAdapters.BooksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.staffsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOMEWORKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOMEWORKDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // staffsBindingSource1
            // 
            this.staffsBindingSource1.DataMember = "Staffs";
            this.staffsBindingSource1.DataSource = this.hOMEWORKDataSet;
            // 
            // hOMEWORKDataSet
            // 
            this.hOMEWORKDataSet.DataSetName = "HOMEWORKDataSet";
            this.hOMEWORKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TeachersBindingSource
            // 
            this.TeachersBindingSource.DataMember = "Teachers";
            this.TeachersBindingSource.DataSource = this.hOMEWORKDataSet;
            // 
            // teachersBindingSource2
            // 
            this.teachersBindingSource2.DataMember = "Teachers";
            this.teachersBindingSource2.DataSource = this.hOMEWORKDataSet;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.hOMEWORKDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_Books";
            reportDataSource1.Value = this.booksBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "School_Report.Report_Books.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1203, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // hOMEWORKDataSetBindingSource
            // 
            this.hOMEWORKDataSetBindingSource.DataSource = this.hOMEWORKDataSet;
            this.hOMEWORKDataSetBindingSource.Position = 0;
            // 
            // teachersBindingSource1
            // 
            this.teachersBindingSource1.DataMember = "Teachers";
            this.teachersBindingSource1.DataSource = this.hOMEWORKDataSet;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // StaffsBindingSource
            // 
            this.StaffsBindingSource.DataMember = "Staffs";
            this.StaffsBindingSource.DataSource = this.hOMEWORKDataSet;
            // 
            // staffsTableAdapter
            // 
            this.staffsTableAdapter.ClearBeforeFill = true;
            // 
            // BooksBindingSource
            // 
            this.BooksBindingSource.DataMember = "Books";
            this.BooksBindingSource.DataSource = this.hOMEWORKDataSet;
            // 
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataMember = "Books";
            this.booksBindingSource1.DataSource = this.hOMEWORKDataSet;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmBooks";
            this.Text = "Teacher Report";
            this.Load += new System.EventHandler(this.frmstudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOMEWORKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOMEWORKDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private HOMEWORKDataSet hOMEWORKDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private HOMEWORKDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.BindingSource TeachersBindingSource;
        private System.Windows.Forms.BindingSource hOMEWORKDataSetBindingSource;
        private System.Windows.Forms.BindingSource teachersBindingSource1;
        private HOMEWORKDataSetTableAdapters.TeachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.BindingSource teachersBindingSource2;
        private System.Windows.Forms.BindingSource StaffsBindingSource;
        private System.Windows.Forms.BindingSource staffsBindingSource1;
        private HOMEWORKDataSetTableAdapters.StaffsTableAdapter staffsTableAdapter;
        private System.Windows.Forms.BindingSource BooksBindingSource;
        private System.Windows.Forms.BindingSource booksBindingSource1;
        private HOMEWORKDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
    }
}

