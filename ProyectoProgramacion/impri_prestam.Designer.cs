namespace ProyectoProgramacion
{
    partial class impri_prestam
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.labase1DataSet = new ProyectoProgramacion.labase1DataSet();
            this.registroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registroTableAdapter = new ProyectoProgramacion.labase1DataSetTableAdapters.registroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.labase1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.registroBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoProgramacion.impri_presta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-3, -2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(630, 315);
            this.reportViewer1.TabIndex = 0;
            // 
            // labase1DataSet
            // 
            this.labase1DataSet.DataSetName = "labase1DataSet";
            this.labase1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registroBindingSource
            // 
            this.registroBindingSource.DataMember = "registro";
            this.registroBindingSource.DataSource = this.labase1DataSet;
            // 
            // registroTableAdapter
            // 
            this.registroTableAdapter.ClearBeforeFill = true;
            // 
            // impri_prestam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 309);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "impri_prestam";
            this.Text = "impri_prestam";
            this.Load += new System.EventHandler(this.impri_prestam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.labase1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource registroBindingSource;
        private labase1DataSet labase1DataSet;
        private labase1DataSetTableAdapters.registroTableAdapter registroTableAdapter;
    }
}