using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;
using Util;

namespace UI.Desktop {
    public partial class UsuarioDesktop : ApplicationForm {

        public Usuario usuarioActual;

        public UsuarioDesktop() {
            InitializeComponent();
        }

        public UsuarioDesktop(ModoForm modo) : this() {
            this.modo = modo;
            
        }

        public UsuarioDesktop(int ID, ModoForm modo) : this() {
            this.modo = modo;
            UsuarioLogic ul = new UsuarioLogic();
            usuarioActual = ul.GetOne(ID);
            MapearDeDatos();
        }

        public override void MapearDeDatos() {
            this.txtID.Text = usuarioActual.ID.ToString();
            this.chkHabilitado.Checked = usuarioActual.Habilitado;
            //this.txtNombre.Text = usuarioActual.Nombre;
            //this.txtApellido.Text = usuarioActual.Apellido; Esto esta en la persona ver como agarrar datos de la persona
            this.txtUsuario.Text = usuarioActual.NombreUsuario;

            switch (modo) {
                case ModoForm.Alta:
                    this.txtClave.ReadOnly = false;
                    btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Modificacion:
                    this.txtClave.Text = usuarioActual.Clave;
                    this.txtClave.ReadOnly = true;
                    btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    this.txtClave.Text = usuarioActual.Clave;
                    this.txtClave.ReadOnly = true;
                    btnAceptar.Text = "Eliminar";
                    break;
                case ModoForm.Consulta:
                    this.txtClave.Text = usuarioActual.Clave;
                    this.txtClave.ReadOnly = true;
                    btnAceptar.Text = "Aceptar";
                    break;
            }

        }
        public override void MapearADatos() {
            switch (modo) {
                case ModoForm.Alta:
                    usuarioActual = new Usuario();
                    usuarioActual.State = BusinessEntity.States.New;
                    break;

                case ModoForm.Modificacion:
                    usuarioActual.State = BusinessEntity.States.Modified;
                    break;

                case ModoForm.Baja:
                    usuarioActual.State = BusinessEntity.States.Deleted;
                    break;
            }


            usuarioActual.Habilitado = this.chkHabilitado.Checked;
            usuarioActual.NombreUsuario = this.txtUsuario.Text;
            usuarioActual.Clave = this.txtClave.Text;
            usuarioActual.TipoUsuario = (TiposUsuarios)cmbTUsuario.SelectedIndex;
            usuarioActual.IdPersona = ((Persona)cmbPersonas.SelectedItem).ID;
            if(usuarioActual.TipoUsuario == TiposUsuarios.alumno) {
                usuarioActual.IdPlan = ((Plan)cmbPlan.SelectedItem).ID;
            }

        }
        public override void GuardarDatos() {
            MapearADatos();

            UsuarioLogic ul = new UsuarioLogic();
            ul.Save(usuarioActual);

        }
        public override bool Validar() { 
            //acumular los mensajes en una variable y notificar todo
            if(this.txtUsuario.Text == "" || this.txtClave.Text == "" || this.txtConfirmarClave.Text == "" 
                || this.cmbPersonas.SelectedIndex == -1 || this.cmbTUsuario.SelectedIndex == -1 ||
                (this.cmbPlan.Enabled == true && this.cmbPlan.SelectedIndex == -1)) {
                Notificar("Error", "hubo uno o mas componentes vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(this.txtClave.Text != this.txtConfirmarClave.Text) {
                Notificar("Error", "La clave no coicide con la confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(this.txtClave.Text.Length > 15) {
                Notificar("Error", "La clave es demasiado larga (maximo 15 caracteres)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true; 
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            if (Validar()) {
                GuardarDatos();
                this.Close();
            }
            
        }

        public void CargarPersonas() {
            cmbPersonas.DataSource = new PersonaLogic().GetAll();
            cmbPersonas.SelectedIndex = -1;

        }

        public void CargarTipos() {
            cmbTUsuario.Items.Add("Admin");
            cmbTUsuario.Items.Add("Alumno");
            cmbTUsuario.Items.Add("Persona");
            cmbTUsuario.SelectedIndex = -1;
        }

        public void CargarPlanes() {
            cmbPlan.DataSource = new PlanLogic().GetAll();
            cmbPlan.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            Close();
        }


        private void UsuarioDesktop_Load(object sender, EventArgs e) {
            CargarPersonas();
            CargarPlanes();
            CargarTipos();
        }

        private void cmbTUsuario_SelectedIndexChanged(object sender, EventArgs e) {
            if(cmbTUsuario.SelectedIndex == 1) {
                cmbPlan.Enabled = true;
            }
            else {
                cmbPlan.Enabled = false;
            }
        }
    }
}
