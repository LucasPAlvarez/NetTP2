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
using Util;

namespace UI.Desktop {
    public partial class UsuarioLogIn : Form {
        public UsuarioLogIn() {
            InitializeComponent();
        }

        //lo converti en un singleton para poder volver a mostrarlo cuando se haga un log out
        //del menu principal peroo si se cierra se cierra todo
        public static UsuarioLogIn logIn {
            get {
                if(_logIn == null) {
                    _logIn = new UsuarioLogIn();
                }
                return _logIn;
            }
        }

        private static UsuarioLogIn _logIn;

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }

        private void btnLogIn_Click(object sender, EventArgs e) {
            if(this.txtBoxUser.Text != "" && this.txtBoxPass.Text != "") {
                UsuarioLogic ul = new UsuarioLogic();
                Usuario currentUser = ul.GetByUserName(this.txtBoxUser.Text);

                if (currentUser != null) {
                    if (currentUser.Clave.Equals(this.txtBoxPass.Text)) {
                        //abrir menu y cerrar esto
                        CurrentUser.SetUsuario(currentUser);
                        MainMenu main = new MainMenu();
                        UsuarioLogIn.logIn.Hide();
                        main.ShowDialog();
                        main.Activate();

                    }
                    else {
                        MessageBox.Show("El nombre de usuario o contraseña que inreso es incorrecto.\n intentelo de nuevo", "Campo Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {
                    MessageBox.Show("El nombre de usuario o contraseña que inreso es incorrecto.\n intentelo de nuevo", "Campo Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("No ingreso usuario o contraseña.\nPorfabor ingreselos antes de apretar Log In", "Campo Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void txtBoxPass_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                btnLogIn_Click(sender, e);
            }
        }

        private void txtBoxUser_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                txtBoxPass.Focus();
            }
        }
    }
}
