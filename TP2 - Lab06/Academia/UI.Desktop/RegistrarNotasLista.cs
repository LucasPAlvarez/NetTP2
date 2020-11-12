using Business.Entities;
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
using Util;

namespace UI.Desktop {
    public partial class RegistrarNotasLista : Form {
        public RegistrarNotasLista() {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            Close();
        }

        private void RegistrarNotasLista_Load(object sender, EventArgs e) {
            lblDocName.Text = CurrentUser.GetPersonaName();
            dgvCursos.DataSource = new CursoLogic().GetCursosByDocente(CurrentUser.GetUsrId());
        }

        private void btnElegir_Click(object sender, EventArgs e) {
            if(dgvCursos.SelectedRows.Count > 0) {
                //create a new window and send curso como input
                RegistrarNotasAlumnosLista lista = new RegistrarNotasAlumnosLista(((Curso)dgvCursos.SelectedRows[0].DataBoundItem).ID);
                lista.ShowDialog();
            }
        }
    }
}
