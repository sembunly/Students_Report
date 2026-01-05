namespace School_Report
{
    partial class frmTeacher
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
            this.teachersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hOMEWORKDataSet = new School_Report.HOMEWORKDataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.studentsTableAdapter = new School_Report.HOMEWORKDataSetTableAdapters.StudentsTableAdapter();
            this.TeachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOMEWORKDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter = new School_Report.HOMEWORKDataSetTableAdapters.TeachersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOMEWORKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOMEWORKDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // teachersBindingSource2
            // 
            this.teachersBindingSource2.DataMember = "Teachers";
            this.teachersBindingSource2.DataSource = this.hOMEWORKDataSet;
            // 
            // hOMEWORKDataSet
            // 
            this.hOMEWORKDataSet.DataSetName = "HOMEWORKDataSet";
            this.hOMEWORKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.hOMEWORKDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_Teacher";
            reportDataSource1.Value = this.TeachersBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "School_Report.Report_Teacher.rdlc";
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
            // TeachersBindingSource
            // 
            this.TeachersBindingSource.DataMember = "Teachers";
            this.TeachersBindingSource.DataSource = this.hOMEWORKDataSet;
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
            // frmTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmTeacher";
            this.Text = "Teacher Report";
            this.Load += new System.EventHandler(this.frmstudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOMEWORKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOMEWORKDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource1)).EndInit();
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
    }
}

