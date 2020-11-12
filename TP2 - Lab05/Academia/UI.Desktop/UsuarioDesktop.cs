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
            this.txtNombre.Text = usuarioActual.Nombre;
            this.txtApellido.Text = usuarioActual.Apellido;
            this.txtUsuario.Text = usuarioActual.NombreUsuario;
            this.txtEmail.Text = usuarioActual.EMail;

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
            usuarioActual.Nombre = this.txtNombre.Text;
            usuarioActual.Apellido = this.txtApellido.Text;
            usuarioActual.NombreUsuario = this.txtUsuario.Text;
            usuarioActual.EMail = this.txtEmail.Text;
            usuarioActual.Clave = this.txtClave.Text;

            

        }
        public override void GuardarDatos() {
            MapearADatos();

            UsuarioLogic ul = new UsuarioLogic();
            ul.Save(usuarioActual);

        }
        public override bool Validar() { 
            //acumular los mensajes en una variable y notificar todo
            if(this.txtNombre.Text == "" || this.txtApellido.Text == "" || this.txtUsuario.Text == "" || this.txtEmail.Text == "" || this.txtClave.Text == "" || this.txtConfirmarClave.Text == "") {
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
            //chequear que el mail sea de un formato correcto
            if (!Validaciones.EsMailValido(this.txtEmail.Text)) {
                Notificar("Error", "El email no es valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
