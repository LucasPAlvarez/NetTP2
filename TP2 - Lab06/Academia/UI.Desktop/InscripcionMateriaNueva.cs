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
    public partial class InscripcionMateriaNueva : Form {
        public InscripcionMateriaNueva() {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            if (ValidarInput()) {
                AlumnoInscripcion nuevoAlIns = new AlumnoInscripcion();
                nuevoAlIns.idAlumno = CurrentUser.GetUsrId();
                nuevoAlIns.idCurso = ((Curso)cmbCurso.SelectedItem).ID;
                nuevoAlIns.condicion = "cursando";
                new CursoLogic().GuardarInscripcio(nuevoAlIns);
            }
        }

        private bool ValidarInput() {

            return cmbCurso.SelectedIndex != -1;
        }

        private void InscripcionMateriaNueva_Load(object sender, EventArgs e) {
            cmbCurso.DataSource = new CursoLogic().GetAll();
            cmbCurso.SelectedIndex = -1;

        }
    }
}
