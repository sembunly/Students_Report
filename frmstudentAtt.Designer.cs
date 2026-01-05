namespace School_Report
{
    partial class frmstudentAtt
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hOMEWORKDataSet = new School_Report.HOMEWORKDataSet();
            this.staffsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            this.booksTableAdapter = new School_Report.HOMEWORKDataSetTableAdapters.BooksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOMEWORKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOMEWORKDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataMember = "Books";
            this.booksBindingSource1.DataSource = this.hOMEWORKDataSet;
            // 
            // hOMEWORKDataSet
            // 
            this.hOMEWORKDataSet.DataSetName = "HOMEWORKDataSet";
            this.hOMEWORKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffsBindingSource1
            // 
            this.staffsBindingSource1.DataMember = "Staffs";
            this.staffsBindingSource1.DataSource = this.hOMEWORKDataSet;
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
            reportDataSource2.Name = "DataSet_Books";
            reportDataSource2.Value = this.booksBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "School_Report.StudentAttendance.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(771, 366);
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
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // frmstudentAtt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 366);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmstudentAtt";
            this.Text = "Teacher Report";
            this.Load += new System.EventHandler(this.frmstudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOMEWORKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOMEWORKDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksBindingSource)).EndInit();
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

