
namespace PrototipoModeloPlataforma.Vistas
{
    partial class Asistencias
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
            this.marcar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lunes = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.martes = new System.Windows.Forms.ListBox();
            this.miercoles = new System.Windows.Forms.ListBox();
            this.jueves = new System.Windows.Forms.ListBox();
            this.viernes = new System.Windows.Forms.ListBox();
            this.sabado = new System.Windows.Forms.ListBox();
            this.domingo = new System.Windows.Forms.ListBox();
            this.cmbcurso = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // marcar
            // 
            this.marcar.Location = new System.Drawing.Point(465, 299);
            this.marcar.Name = "marcar";
            this.marcar.Size = new System.Drawing.Size(150, 23);
            this.marcar.TabIndex = 0;
            this.marcar.Text = "Marcar Asistencia";
            this.marcar.UseVisualStyleBackColor = true;
            this.marcar.Click += new System.EventHandler(this.marcar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lunes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Martes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Miercoles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jueves";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Viernes";
            // 
            // lunes
            // 
            this.lunes.FormattingEnabled = true;
            this.lunes.ItemHeight = 15;
            this.lunes.Location = new System.Drawing.Point(22, 70);
            this.lunes.Name = "lunes";
            this.lunes.Size = new System.Drawing.Size(74, 199);
            this.lunes.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sabado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(547, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Domingo";
            // 
            // martes
            // 
            this.martes.FormattingEnabled = true;
            this.martes.ItemHeight = 15;
            this.martes.Location = new System.Drawing.Point(113, 70);
            this.martes.Name = "martes";
            this.martes.Size = new System.Drawing.Size(74, 199);
            this.martes.TabIndex = 4;
            // 
            // miercoles
            // 
            this.miercoles.FormattingEnabled = true;
            this.miercoles.ItemHeight = 15;
            this.miercoles.Location = new System.Drawing.Point(198, 70);
            this.miercoles.Name = "miercoles";
            this.miercoles.Size = new System.Drawing.Size(74, 199);
            this.miercoles.TabIndex = 4;
            // 
            // jueves
            // 
            this.jueves.FormattingEnabled = true;
            this.jueves.ItemHeight = 15;
            this.jueves.Location = new System.Drawing.Point(283, 70);
            this.jueves.Name = "jueves";
            this.jueves.Size = new System.Drawing.Size(74, 199);
            this.jueves.TabIndex = 4;
            this.jueves.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // viernes
            // 
            this.viernes.FormattingEnabled = true;
            this.viernes.ItemHeight = 15;
            this.viernes.Location = new System.Drawing.Point(370, 70);
            this.viernes.Name = "viernes";
            this.viernes.Size = new System.Drawing.Size(74, 199);
            this.viernes.TabIndex = 4;
            // 
            // sabado
            // 
            this.sabado.FormattingEnabled = true;
            this.sabado.ItemHeight = 15;
            this.sabado.Location = new System.Drawing.Point(454, 70);
            this.sabado.Name = "sabado";
            this.sabado.Size = new System.Drawing.Size(74, 199);
            this.sabado.TabIndex = 4;
            // 
            // domingo
            // 
            this.domingo.FormattingEnabled = true;
            this.domingo.ItemHeight = 15;
            this.domingo.Location = new System.Drawing.Point(541, 70);
            this.domingo.Name = "domingo";
            this.domingo.Size = new System.Drawing.Size(74, 199);
            this.domingo.TabIndex = 4;
            // 
            // cmbcurso
            // 
            this.cmbcurso.FormattingEnabled = true;
            this.cmbcurso.Location = new System.Drawing.Point(177, 300);
            this.cmbcurso.Name = "cmbcurso";
            this.cmbcurso.Size = new System.Drawing.Size(267, 23);
            this.cmbcurso.TabIndex = 5;
            // 
            // Asistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(641, 349);
            this.Controls.Add(this.cmbcurso);
            this.Controls.Add(this.domingo);
            this.Controls.Add(this.sabado);
            this.Controls.Add(this.viernes);
            this.Controls.Add(this.jueves);
            this.Controls.Add(this.miercoles);
            this.Controls.Add(this.martes);
            this.Controls.Add(this.lunes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.marcar);
            this.Name = "Asistencias";
            this.Text = "Asistencias";
            this.Load += new System.EventHandler(this.Asistencias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button marcar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lunes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox martes;
        private System.Windows.Forms.ListBox miercoles;
        private System.Windows.Forms.ListBox jueves;
        private System.Windows.Forms.ListBox viernes;
        private System.Windows.Forms.ListBox sabado;
        private System.Windows.Forms.ListBox domingo;
        private System.Windows.Forms.ComboBox cmbcurso;
    }
}