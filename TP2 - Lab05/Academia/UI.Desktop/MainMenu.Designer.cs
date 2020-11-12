namespace UI.Desktop {
    partial class MainMenu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemUsrName = new System.Windows.Forms.ToolStripMenuItem();
            this.misDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.btnEspecialidades = new System.Windows.Forms.Button();
            this.btnPlanes = new System.Windows.Forms.Button();
            this.btnComisiones = new System.Windows.Forms.Button();
            this.btnProfesores = new System.Windows.Forms.Button();
            this.btnCurso = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.titleListas = new System.Windows.Forms.Label();
            this.divider1 = new System.Windows.Forms.Label();
            this.titleAlumnos = new System.Windows.Forms.Label();
            this.divider2 = new System.Windows.Forms.Label();
            this.btnInscripcion = new System.Windows.Forms.Button();
            this.titleProfesores = new System.Windows.Forms.Label();
            this.divider3 = new System.Windows.Forms.Label();
            this.btnNotas = new System.Windows.Forms.Button();
            this.btnReporteCurso = new System.Windows.Forms.Button();
            this.btnReportePlanes = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(3, 26);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(169, 44);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(525, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmItemUsrName,
            this.misDatosToolStripMenuItem,
            this.tsmItemLogOut});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // tsmItemUsrName
            // 
            this.tsmItemUsrName.Checked = true;
            this.tsmItemUsrName.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.tsmItemUsrName.ForeColor = System.Drawing.Color.Green;
            this.tsmItemUsrName.Name = "tsmItemUsrName";
            this.tsmItemUsrName.Size = new System.Drawing.Size(126, 22);
            this.tsmItemUsrName.Text = "Usr_name";
            // 
            // misDatosToolStripMenuItem
            // 
            this.misDatosToolStripMenuItem.Name = "misDatosToolStripMenuItem";
            this.misDatosToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.misDatosToolStripMenuItem.Text = "Mis Datos";
            // 
            // tsmItemLogOut
            // 
            this.tsmItemLogOut.Name = "tsmItemLogOut";
            this.tsmItemLogOut.Size = new System.Drawing.Size(126, 22);
            this.tsmItemLogOut.Text = "Log Out";
            this.tsmItemLogOut.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Location = new System.Drawing.Point(178, 26);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(169, 44);
            this.btnAlumnos.TabIndex = 3;
            this.btnAlumnos.Text = "Alumnos";
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // btnEspecialidades
            // 
            this.btnEspecialidades.Location = new System.Drawing.Point(3, 76);
            this.btnEspecialidades.Name = "btnEspecialidades";
            this.btnEspecialidades.Size = new System.Drawing.Size(169, 44);
            this.btnEspecialidades.TabIndex = 4;
            this.btnEspecialidades.Text = "Especialidades";
            this.btnEspecialidades.UseVisualStyleBackColor = true;
            this.btnEspecialidades.Click += new System.EventHandler(this.btnEspecialidades_Click);
            // 
            // btnPlanes
            // 
            this.btnPlanes.Location = new System.Drawing.Point(178, 76);
            this.btnPlanes.Name = "btnPlanes";
            this.btnPlanes.Size = new System.Drawing.Size(169, 44);
            this.btnPlanes.TabIndex = 5;
            this.btnPlanes.Text = "Planes";
            this.btnPlanes.UseVisualStyleBackColor = true;
            this.btnPlanes.Click += new System.EventHandler(this.btnPlanes_Click);
            // 
            // btnComisiones
            // 
            this.btnComisiones.Location = new System.Drawing.Point(178, 126);
            this.btnComisiones.Name = "btnComisiones";
            this.btnComisiones.Size = new System.Drawing.Size(169, 44);
            this.btnComisiones.TabIndex = 6;
            this.btnComisiones.Text = "Comisiones";
            this.btnComisiones.UseVisualStyleBackColor = true;
            this.btnComisiones.Click += new System.EventHandler(this.btnComisiones_Click);
            // 
            // btnProfesores
            // 
            this.btnProfesores.Location = new System.Drawing.Point(353, 26);
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Size = new System.Drawing.Size(169, 44);
            this.btnProfesores.TabIndex = 7;
            this.btnProfesores.Text = "Profesores";
            this.btnProfesores.UseVisualStyleBackColor = true;
            this.btnProfesores.Click += new System.EventHandler(this.btnProfesores_Click);
            // 
            // btnCurso
            // 
            this.btnCurso.Location = new System.Drawing.Point(353, 76);
            this.btnCurso.Name = "btnCurso";
            this.btnCurso.Size = new System.Drawing.Size(169, 44);
            this.btnCurso.TabIndex = 8;
            this.btnCurso.Text = "Curso";
            this.btnCurso.UseVisualStyleBackColor = true;
            this.btnCurso.Click += new System.EventHandler(this.btnCurso_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.titleListas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPlanes, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAlumnos, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnEspecialidades, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCurso, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnUsuarios, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.divider1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnProfesores, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnComisiones, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.titleAlumnos, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.divider2, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnInscripcion, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.titleProfesores, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.divider3, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.btnNotas, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.btnReporteCurso, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.btnReportePlanes, 2, 12);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(525, 352);
            this.tableLayoutPanel1.TabIndex = 9;
            this.tableLayoutPanel1.TabStop = true;
            // 
            // titleListas
            // 
            this.titleListas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleListas.AutoSize = true;
            this.titleListas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleListas.Location = new System.Drawing.Point(59, 0);
            this.titleListas.Name = "titleListas";
            this.titleListas.Size = new System.Drawing.Size(57, 20);
            this.titleListas.TabIndex = 9;
            this.titleListas.Text = "Listas";
            // 
            // divider1
            // 
            this.divider1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.divider1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.divider1, 3);
            this.divider1.Dock = System.Windows.Forms.DockStyle.Top;
            this.divider1.Location = new System.Drawing.Point(3, 20);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(534, 3);
            this.divider1.TabIndex = 10;
            // 
            // titleAlumnos
            // 
            this.titleAlumnos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleAlumnos.AutoSize = true;
            this.titleAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleAlumnos.Location = new System.Drawing.Point(48, 183);
            this.titleAlumnos.Name = "titleAlumnos";
            this.titleAlumnos.Size = new System.Drawing.Size(78, 20);
            this.titleAlumnos.TabIndex = 11;
            this.titleAlumnos.Text = "Alumnos";
            // 
            // divider2
            // 
            this.divider2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.divider2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.divider2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.divider2, 3);
            this.divider2.Cursor = System.Windows.Forms.Cursors.Default;
            this.divider2.Location = new System.Drawing.Point(3, 203);
            this.divider2.Name = "divider2";
            this.divider2.Size = new System.Drawing.Size(534, 3);
            this.divider2.TabIndex = 12;
            this.divider2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInscripcion
            // 
            this.btnInscripcion.Location = new System.Drawing.Point(3, 209);
            this.btnInscripcion.Name = "btnInscripcion";
            this.btnInscripcion.Size = new System.Drawing.Size(169, 44);
            this.btnInscripcion.TabIndex = 13;
            this.btnInscripcion.Text = "Inscripcion a materia";
            this.btnInscripcion.UseVisualStyleBackColor = true;
            // 
            // titleProfesores
            // 
            this.titleProfesores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleProfesores.AutoSize = true;
            this.titleProfesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleProfesores.Location = new System.Drawing.Point(39, 266);
            this.titleProfesores.Name = "titleProfesores";
            this.titleProfesores.Size = new System.Drawing.Size(96, 20);
            this.titleProfesores.TabIndex = 14;
            this.titleProfesores.Text = "Profesores";
            // 
            // divider3
            // 
            this.divider3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.divider3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.divider3, 3);
            this.divider3.Dock = System.Windows.Forms.DockStyle.Top;
            this.divider3.Location = new System.Drawing.Point(3, 286);
            this.divider3.Name = "divider3";
            this.divider3.Size = new System.Drawing.Size(534, 3);
            this.divider3.TabIndex = 15;
            // 
            // btnNotas
            // 
            this.btnNotas.Location = new System.Drawing.Point(3, 292);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(169, 44);
            this.btnNotas.TabIndex = 16;
            this.btnNotas.Text = "Registrar nota";
            this.btnNotas.UseVisualStyleBackColor = true;
            // 
            // btnReporteCurso
            // 
            this.btnReporteCurso.Location = new System.Drawing.Point(178, 292);
            this.btnReporteCurso.Name = "btnReporteCurso";
            this.btnReporteCurso.Size = new System.Drawing.Size(169, 44);
            this.btnReporteCurso.TabIndex = 17;
            this.btnReporteCurso.Text = "Reporte de Curso";
            this.btnReporteCurso.UseVisualStyleBackColor = true;
            // 
            // btnReportePlanes
            // 
            this.btnReportePlanes.Location = new System.Drawing.Point(353, 292);
            this.btnReportePlanes.Name = "btnReportePlanes";
            this.btnReportePlanes.Size = new System.Drawing.Size(169, 44);
            this.btnReportePlanes.TabIndex = 18;
            this.btnReportePlanes.Text = "Reporte de planes";
            this.btnReportePlanes.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 376);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmItemLogOut;
        private System.Windows.Forms.ToolStripMenuItem misDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmItemUsrName;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Button btnEspecialidades;
        private System.Windows.Forms.Button btnPlanes;
        private System.Windows.Forms.Button btnComisiones;
        private System.Windows.Forms.Button btnProfesores;
        private System.Windows.Forms.Button btnCurso;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label titleListas;
        private System.Windows.Forms.Label divider1;
        private System.Windows.Forms.Label titleAlumnos;
        private System.Windows.Forms.Label divider2;
        private System.Windows.Forms.Button btnInscripcion;
        private System.Windows.Forms.Label titleProfesores;
        private System.Windows.Forms.Label divider3;
        private System.Windows.Forms.Button btnNotas;
        private System.Windows.Forms.Button btnReporteCurso;
        private System.Windows.Forms.Button btnReportePlanes;
    }
}