
namespace PrototipoModeloPlataforma.Vistas
{
    partial class SAE
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
            this.comboProblemas = new System.Windows.Forms.ComboBox();
            this.informacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboProblemas
            // 
            this.comboProblemas.FormattingEnabled = true;
            this.comboProblemas.Location = new System.Drawing.Point(33, 57);
            this.comboProblemas.Name = "comboProblemas";
            this.comboProblemas.Size = new System.Drawing.Size(449, 23);
            this.comboProblemas.TabIndex = 0;
            // 
            // informacion
            // 
            this.informacion.Location = new System.Drawing.Point(33, 86);
            this.informacion.Multiline = true;
            this.informacion.Name = "informacion";
            this.informacion.Size = new System.Drawing.Size(449, 171);
            this.informacion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reportar un Error:";
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(407, 272);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(75, 23);
            this.report.TabIndex = 3;
            this.report.Text = "Reportar";
            this.report.UseVisualStyleBackColor = true;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // SAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(526, 317);
            this.Controls.Add(this.report);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.informacion);
            this.Controls.Add(this.comboProblemas);
            this.Name = "SAE";
            this.Text = "SAE";
            this.Load += new System.EventHandler(this.SAE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboProblemas;
        private System.Windows.Forms.TextBox informacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button report;
    }
}