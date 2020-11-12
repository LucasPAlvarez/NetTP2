using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace UI.Web {
    public partial class Usuarios : System.Web.UI.Page {

        UsuarioLogic _logic;
        private UsuarioLogic Logic {
            get {
                if(_logic == null) {
                    _logic = new UsuarioLogic();
                }
                return _logic;
            }
        }

        public FormModes FormMode {
            get { return (FormModes)this.ViewState["FormMode"]; }
            set { this.ViewState["FormMode"] = value; }
        }

        public Usuario Entity {
            get;
            set;
        }

        private int SelectedID {
            get {
                if(this.ViewState["SelectedID"] != null) {
                    return (int)this.ViewState["SelectedID"];
                }
                else {
                    return 0;
                }
            }
            set {
                this.ViewState["SelectedID"] = value;
            }
        }

        private bool IsEntitySelected {
            get {
                return this.SelectedID != 0; 
            }
        }

        private void LoadGrid() {
            this.gridView.DataSource = this.Logic.GetAll();
            this.gridView.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e) {
            LoadGrid();
        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e) {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }

        private void LoadForm(int id) {
            this.Entity = this.Logic.GetOne(id);
            //this.nombreTextBox.Text = this.Entity.Nombre;
            //this.apellidoTextBox.Text = this.Entity.Apellido;
            //this.emailTextBox.Text = this.Entity.EMail;
            this.habilitadoTextBox.Checked = this.Entity.Habilitado;
            this.nombreUsuarioTextBox.Text = this.Entity.NombreUsuario;

        }

        private void LoadEntity(Usuario usuario) {
           // usuario.Nombre = this.nombreTextBox.Text;
            //usuario.Apellido = this.apellidoTextBox.Text;
            //usuario.EMail = this.emailTextBox.Text;
            usuario.Habilitado = this.habilitadoTextBox.Checked;
            usuario.NombreUsuario = this.nombreUsuarioTextBox.Text;
        }

        private void SaveEntity(Usuario usuario) {
            this.Logic.Save(usuario);
        }

        private void DeleteEntity(int id) {
            this.Logic.Delete(id);
        }

        private void EnableForm(bool enable) {
            this.nombreTextBox.Enabled = enable;
            this.apellidoTextBox.Enabled = enable;
            this.emailTextBox.Enabled = enable;
            this.nombreUsuarioTextBox.Enabled = enable;
            this.claveTextBox.Visible = enable;
            this.claveLabel.Visible = enable;
            this.repetirClaveTextBox.Visible = enable;
            this.repetirClaveLabel.Visible = enable;
        }

        private void ClearForm() {
            this.nombreTextBox.Text = string.Empty;
            this.apellidoTextBox.Text = string.Empty;
            this.emailTextBox.Text = string.Empty;
            this.habilitadoTextBox.Checked = false;
            this.nombreUsuarioTextBox.Text = string.Empty;
        }

        protected void editarLinkButton_Click(object sender, EventArgs e) {
            if (this.IsEntitySelected) {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.EnableForm(true);
                this.LoadForm(this.SelectedID);
            }
        }

        protected void eliminarLinkButton_Click(object sender, EventArgs e) {
            if (this.IsEntitySelected) {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Baja;
                this.EnableForm(false);
                this.LoadForm(this.SelectedID);
            }
        }
        protected void nuevoLinkButton_Click(object sender, EventArgs e) {
            this.formPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableForm(true);
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e) {
            switch (this.FormMode) {
                case FormModes.Alta:
                    this.Entity = new Usuario();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    break;
                case FormModes.Baja:
                    this.DeleteEntity(this.SelectedID);
                    break;
                case FormModes.Modificacion:
                    this.Entity = new Usuario();
                    Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    break;
            }
            this.LoadGrid();

            this.formPanel.Visible = false;
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e) {
            this.formPanel.Visible = false;
        }
    }

    public enum FormModes {
        Alta,
        Baja,
        Modificacion
    }
}