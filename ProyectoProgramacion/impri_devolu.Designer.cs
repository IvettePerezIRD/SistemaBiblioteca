namespace ProyectoProgramacion
{
    partial class impri_devolu
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
            this.devolucionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.devolucionTableAdapter = new ProyectoProgramacion.labase1DataSetTableAdapters.devolucionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.labase1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devolucionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.devolucionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoProgramacion.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(606, 291);
            this.reportViewer1.TabIndex = 0;
            // 
            // labase1DataSet
            // 
            this.labase1DataSet.DataSetName = "labase1DataSet";
            this.labase1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // devolucionBindingSource
            // 
            this.devolucionBindingSource.DataMember = "devolucion";
            this.devolucionBindingSource.DataSource = this.labase1DataSet;
            // 
            // devolucionTableAdapter
            // 
            this.devolucionTableAdapter.ClearBeforeFill = true;
            // 
            // impri_devolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 288);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "impri_devolu";
            this.Text = "impri_devolu";
            this.Load += new System.EventHandler(this.impri_devolu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.labase1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devolucionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource devolucionBindingSource;
        private labase1DataSet labase1DataSet;
        private labase1DataSetTableAdapters.devolucionTableAdapter devolucionTableAdapter;
    }
}