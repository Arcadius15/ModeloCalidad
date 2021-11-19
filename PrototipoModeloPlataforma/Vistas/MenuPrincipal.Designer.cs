
namespace PrototipoModeloPlataforma.Vistas
{
    partial class MenuPrincipal
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
            this.SAEbtn = new System.Windows.Forms.Button();
            this.asistencias = new System.Windows.Forms.Button();
            this.amigos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cursos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.grupo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SAEbtn
            // 
            this.SAEbtn.Location = new System.Drawing.Point(713, 379);
            this.SAEbtn.Name = "SAEbtn";
            this.SAEbtn.Size = new System.Drawing.Size(75, 59);
            this.SAEbtn.TabIndex = 0;
            this.SAEbtn.Text = "SAE";
            this.SAEbtn.UseVisualStyleBackColor = true;
            // 
            // asistencias
            // 
            this.asistencias.Location = new System.Drawing.Point(12, 322);
            this.asistencias.Name = "asistencias";
            this.asistencias.Size = new System.Drawing.Size(171, 67);
            this.asistencias.TabIndex = 1;
            this.asistencias.Text = "Ver Asistencias";
            this.asistencias.UseVisualStyleBackColor = true;
            this.asistencias.Click += new System.EventHandler(this.asistencias_Click);
            // 
            // amigos
            // 
            this.amigos.FormattingEnabled = true;
            this.amigos.ItemHeight = 15;
            this.amigos.Location = new System.Drawing.Point(668, 57);
            this.amigos.Name = "amigos";
            this.amigos.Size = new System.Drawing.Size(120, 259);
            this.amigos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(668, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amigos";
            // 
            // cursos
            // 
            this.cursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cursos.Location = new System.Drawing.Point(12, 57);
            this.cursos.Name = "cursos";
            this.cursos.RowTemplate.Height = 25;
            this.cursos.Size = new System.Drawing.Size(171, 259);
            this.cursos.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrototipoModeloPlataforma.Properties.Resources.idat;
            this.pictureBox1.Location = new System.Drawing.Point(227, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 333);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(296, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Aular Virtual IDAT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cursos";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bienvenido: ";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(90, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(47, 15);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Usuario";
            this.lblUser.Click += new System.EventHandler(this.label3_Click);
            // 
            // grupo
            // 
            this.grupo.Location = new System.Drawing.Point(668, 322);
            this.grupo.Name = "grupo";
            this.grupo.Size = new System.Drawing.Size(120, 32);
            this.grupo.TabIndex = 0;
            this.grupo.Text = "Formar Grupo";
            this.grupo.UseVisualStyleBackColor = true;
            this.grupo.Click += new System.EventHandler(this.grupo_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cursos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amigos);
            this.Controls.Add(this.asistencias);
            this.Controls.Add(this.grupo);
            this.Controls.Add(this.SAEbtn);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.cursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SAEbtn;
        private System.Windows.Forms.Button asistencias;
        private System.Windows.Forms.ListBox amigos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView cursos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button grupo;
    }
}