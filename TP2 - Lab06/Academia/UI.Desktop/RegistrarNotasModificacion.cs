using Business.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop {
    public partial class RegistrarNotasModificacion : Form {

        int myCursoId;

        public RegistrarNotasModificacion(int cursoId) {
            InitializeComponent();
            myCursoId = cursoId;
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            if(txtCond.Text != "" && txtNota.Text != "") {
                new CursoLogic().CambiarNota(myCursoId, txtCond.Text, int.Parse(txtNota.Text));
                Close();
            }
            else {
                MessageBox.Show("campos vacios");
            }
        }
    }
}
