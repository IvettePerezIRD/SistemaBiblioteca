namespace ProyectoProgramacion
{
    partial class Form3
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
            this.button8 = new System.Windows.Forms.Button();
            this.lb_ruta_objetivo = new System.Windows.Forms.Label();
            this.lb_ruta_elemento_objetivo = new System.Windows.Forms.Label();
            this.lb_proceso = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lb_peso = new System.Windows.Forms.Label();
            this.lb_extencion = new System.Windows.Forms.Label();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(293, 284);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(56, 24);
            this.button8.TabIndex = 31;
            this.button8.Text = "Cerrar";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // lb_ruta_objetivo
            // 
            this.lb_ruta_objetivo.AutoSize = true;
            this.lb_ruta_objetivo.BackColor = System.Drawing.Color.Transparent;
            this.lb_ruta_objetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ruta_objetivo.Location = new System.Drawing.Point(37, 243);
            this.lb_ruta_objetivo.Name = "lb_ruta_objetivo";
            this.lb_ruta_objetivo.Size = new System.Drawing.Size(20, 16);
            this.lb_ruta_objetivo.TabIndex = 30;
            this.lb_ruta_objetivo.Text = "...";
            // 
            // lb_ruta_elemento_objetivo
            // 
            this.lb_ruta_elemento_objetivo.AutoSize = true;
            this.lb_ruta_elemento_objetivo.BackColor = System.Drawing.Color.Transparent;
            this.lb_ruta_elemento_objetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ruta_elemento_objetivo.Location = new System.Drawing.Point(52, 89);
            this.lb_ruta_elemento_objetivo.Name = "lb_ruta_elemento_objetivo";
            this.lb_ruta_elemento_objetivo.Size = new System.Drawing.Size(20, 16);
            this.lb_ruta_elemento_objetivo.TabIndex = 29;
            this.lb_ruta_elemento_objetivo.Text = "...";
            // 
            // lb_proceso
            // 
            this.lb_proceso.AutoSize = true;
            this.lb_proceso.BackColor = System.Drawing.Color.Transparent;
            this.lb_proceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_proceso.Location = new System.Drawing.Point(37, 272);
            this.lb_proceso.Name = "lb_proceso";
            this.lb_proceso.Size = new System.Drawing.Size(105, 25);
            this.lb_proceso.TabIndex = 28;
            this.lb_proceso.Text = "Proceso:";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(130, 218);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(87, 22);
            this.button7.TabIndex = 27;
            this.button7.Text = "Ver Archivo";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(236, 218);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 22);
            this.button6.TabIndex = 26;
            this.button6.Text = "Eliminar archivo";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // lb_peso
            // 
            this.lb_peso.AutoSize = true;
            this.lb_peso.BackColor = System.Drawing.Color.Transparent;
            this.lb_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_peso.Location = new System.Drawing.Point(37, 168);
            this.lb_peso.Name = "lb_peso";
            this.lb_peso.Size = new System.Drawing.Size(72, 25);
            this.lb_peso.TabIndex = 22;
            this.lb_peso.Text = "Peso:";
            // 
            // lb_extencion
            // 
            this.lb_extencion.AutoSize = true;
            this.lb_extencion.BackColor = System.Drawing.Color.Transparent;
            this.lb_extencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_extencion.Location = new System.Drawing.Point(37, 140);
            this.lb_extencion.Name = "lb_extencion";
            this.lb_extencion.Size = new System.Drawing.Size(123, 25);
            this.lb_extencion.TabIndex = 21;
            this.lb_extencion.Text = "Extención:";
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lb_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nombre.Location = new System.Drawing.Point(37, 114);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(100, 25);
            this.lb_nombre.TabIndex = 20;
            this.lb_nombre.Text = "Nombre:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Guardar Como";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Examinar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 31);
            this.label1.TabIndex = 32;
            this.label1.Text = "Busque sus notas a subir";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::ProyectoProgramacion.Properties.Resources.puntos_azules_1024x640;
            this.ClientSize = new System.Drawing.Size(357, 320);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.lb_ruta_objetivo);
            this.Controls.Add(this.lb_ruta_elemento_objetivo);
            this.Controls.Add(this.lb_proceso);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.lb_peso);
            this.Controls.Add(this.lb_extencion);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label lb_ruta_objetivo;
        private System.Windows.Forms.Label lb_ruta_elemento_objetivo;
        private System.Windows.Forms.Label lb_proceso;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lb_peso;
        private System.Windows.Forms.Label lb_extencion;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}