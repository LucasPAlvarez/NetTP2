using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop {
    public partial class Usuarios : Form {
        private ToolStripContainer tcUsuarios;
        private TableLayoutPanel tlUsuarios;
        private DataGridView dgvUsuarios;
        private Button btnActualizar;
        private Button btnSalir;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbEditar;
        private ToolStripButton tsbEliminar;
        private DataGridViewTextBoxColumn id_usuario;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn nombre_usuario;
        private DataGridViewTextBoxColumn email;
        private DataGridViewCheckBoxColumn habilitado;
        private TableLayoutPanel tableLayoutPanel1;
        private CheckBox cboxAlumnos;
        private CheckBox cboxProfesores;
        private CheckBox cboxAdmin;
        private ToolStrip tsUsuarios;

        public Usuarios() {
            InitializeComponent();
        }

        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.tcUsuarios = new System.Windows.Forms.ToolStripContainer();
            this.tlUsuarios = new System.Windows.Forms.TableLayoutPanel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilitado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cboxAlumnos = new System.Windows.Forms.CheckBox();
            this.cboxProfesores = new System.Windows.Forms.CheckBox();
            this.cboxAdmin = new System.Windows.Forms.CheckBox();
            this.tsUsuarios = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tcUsuarios.ContentPanel.SuspendLayout();
            this.tcUsuarios.TopToolStripPanel.SuspendLayout();
            this.tcUsuarios.SuspendLayout();
            this.tlUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tsUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcUsuarios
            // 
            // 
            // tcUsuarios.ContentPanel
            // 
            this.tcUsuarios.ContentPanel.Controls.Add(this.tlUsuarios);
            this.tcUsuarios.ContentPanel.Size = new System.Drawing.Size(691, 369);
            this.tcUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tcUsuarios.Name = "tcUsuarios";
            this.tcUsuarios.Size = new System.Drawing.Size(691, 394);
            this.tcUsuarios.TabIndex = 0;
            this.tcUsuarios.Text = "toolStripContainer1";
            // 
            // tcUsuarios.TopToolStripPanel
            // 
            this.tcUsuarios.TopToolStripPanel.Controls.Add(this.tsUsuarios);
            // 
            // tlUsuarios
            // 
            this.tlUsuarios.ColumnCount = 2;
            this.tlUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlUsuarios.Controls.Add(this.btnActualizar, 0, 2);
            this.tlUsuarios.Controls.Add(this.btnSalir, 1, 2);
            this.tlUsuarios.Controls.Add(this.dgvUsuarios, 0, 1);
            this.tlUsuarios.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tlUsuarios.Name = "tlUsuarios";
            this.tlUsuarios.RowCount = 3;
            this.tlUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlUsuarios.Size = new System.Drawing.Size(691, 369);
            this.tlUsuarios.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(532, 343);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(613, 343);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_usuario,
            this.nombre,
            this.apellido,
            this.nombre_usuario,
            this.email,
            this.habilitado});
            this.tlUsuarios.SetColumnSpan(this.dgvUsuarios, 2);
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(3, 33);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(685, 304);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // id_usuario
            // 
            this.id_usuario.DataPropertyName = "id_usuario";
            this.id_usuario.HeaderText = "ID";
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // nombre_usuario
            // 
            this.nombre_usuario.DataPropertyName = "nombre_usuario";
            this.nombre_usuario.HeaderText = "Usuario";
            this.nombre_usuario.Name = "nombre_usuario";
            this.nombre_usuario.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "EMail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // habilitado
            // 
            this.habilitado.DataPropertyName = "habilitado";
            this.habilitado.HeaderText = "Habilitado";
            this.habilitado.Name = "habilitado";
            this.habilitado.ReadOnly = true;
            this.habilitado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.habilitado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.cboxAlumnos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboxProfesores, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboxAdmin, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(604, 24);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // cboxAlumnos
            // 
            this.cboxAlumnos.AutoSize = true;
            this.cboxAlumnos.Checked = true;
            this.cboxAlumnos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxAlumnos.Location = new System.Drawing.Point(3, 3);
            this.cboxAlumnos.Name = "cboxAlumnos";
            this.cboxAlumnos.Size = new System.Drawing.Size(66, 17);
            this.cboxAlumnos.TabIndex = 0;
            this.cboxAlumnos.Text = "Alumnos";
            this.cboxAlumnos.UseVisualStyleBackColor = true;
            this.cboxAlumnos.CheckedChanged += new System.EventHandler(this.cboxAlumnos_CheckedChanged);
            // 
            // cboxProfesores
            // 
            this.cboxProfesores.AutoSize = true;
            this.cboxProfesores.Checked = true;
            this.cboxProfesores.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxProfesores.Location = new System.Drawing.Point(75, 3);
            this.cboxProfesores.Name = "cboxProfesores";
            this.cboxProfesores.Size = new System.Drawing.Size(76, 17);
            this.cboxProfesores.TabIndex = 1;
            this.cboxProfesores.Text = "Profesores";
            this.cboxProfesores.UseVisualStyleBackColor = true;
            this.cboxProfesores.CheckedChanged += new System.EventHandler(this.cboxProfesores_CheckedChanged);
            // 
            // cboxAdmin
            // 
            this.cboxAdmin.AutoSize = true;
            this.cboxAdmin.Checked = true;
            this.cboxAdmin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxAdmin.Location = new System.Drawing.Point(157, 3);
            this.cboxAdmin.Name = "cboxAdmin";
            this.cboxAdmin.Size = new System.Drawing.Size(55, 17);
            this.cboxAdmin.TabIndex = 2;
            this.cboxAdmin.Text = "Admin";
            this.cboxAdmin.UseVisualStyleBackColor = true;
            this.cboxAdmin.CheckedChanged += new System.EventHandler(this.cboxAdmin_CheckedChanged);
            // 
            // tsUsuarios
            // 
            this.tsUsuarios.Dock = System.Windows.Forms.DockStyle.None;
            this.tsUsuarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsUsuarios.Location = new System.Drawing.Point(3, 0);
            this.tsUsuarios.Name = "tsUsuarios";
            this.tsUsuarios.Size = new System.Drawing.Size(112, 25);
            this.tsUsuarios.TabIndex = 0;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "toolStripButton1";
            this.tsbNuevo.ToolTipText = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "toolStripButton1";
            this.tsbEditar.ToolTipText = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "toolStripButton2";
            this.tsbEliminar.ToolTipText = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // Usuarios
            // 
            this.ClientSize = new System.Drawing.Size(691, 394);
            this.Controls.Add(this.tcUsuarios);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.tcUsuarios.ContentPanel.ResumeLayout(false);
            this.tcUsuarios.TopToolStripPanel.ResumeLayout(false);
            this.tcUsuarios.TopToolStripPanel.PerformLayout();
            this.tcUsuarios.ResumeLayout(false);
            this.tcUsuarios.PerformLayout();
            this.tlUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tsUsuarios.ResumeLayout(false);
            this.tsUsuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        public void Listar() {
            this.dgvUsuarios.AutoGenerateColumns = false;
            UsuarioLogic ul = new UsuarioLogic();
            this.dgvUsuarios.DataSource = ul.getAllChecked(cboxAlumnos.Checked, cboxProfesores.Checked, cboxAdmin.Checked);
        }

        private void Usuarios_Load(object sender, EventArgs e) {
            Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e) {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e) {
            UsuarioDesktop ud = new UsuarioDesktop(ModoForm.Alta);
            ud.ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e) {
            if (dgvUsuarios.SelectedRows.Count > 0) {
                int ID = ((DataRowView)dgvUsuarios.SelectedRows[0].DataBoundItem).Row.Field<int>("id_usuario");

                UsuarioDesktop ud = new UsuarioDesktop(ID, ModoForm.Modificacion);
                ud.ShowDialog();
                Listar();
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e) {
            if (dgvUsuarios.SelectedRows.Count > 0) {
                int ID = ((Usuario)dgvUsuarios.SelectedRows[0].DataBoundItem).ID;

                UsuarioDesktop ud = new UsuarioDesktop(ID, ModoForm.Baja);
                ud.ShowDialog();
                Listar();
            }
        }

        private void cboxAlumnos_CheckedChanged(object sender, EventArgs e) {
            if (AllOff()) {
                cboxAlumnos.Checked = true;
            }
            else {
                Listar();
            }
        }

        private void cboxProfesores_CheckedChanged(object sender, EventArgs e) {
            if (AllOff()) {
                cboxProfesores.Checked = true;
            }
            else {
                Listar();
            }
        }

        private void cboxAdmin_CheckedChanged(object sender, EventArgs e) {
            if (AllOff()) {
                cboxAdmin.Checked = true;
            }
            else {
                Listar();
            }
        }

        public bool AllOff() {
            return !(cboxAlumnos.Checked || cboxProfesores.Checked || cboxAdmin.Checked);
        }
    }
}
