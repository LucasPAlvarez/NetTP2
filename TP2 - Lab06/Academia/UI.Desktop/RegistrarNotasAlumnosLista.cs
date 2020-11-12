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
    public partial class RegistrarNotasAlumnosLista : Form {

        int myCursoId;

        public RegistrarNotasAlumnosLista(int cursoId) {
            InitializeComponent();
            myCursoId = cursoId;
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnElegir_Click(object sender, EventArgs e) {
            if(dgvAlumnos.SelectedRows.Count > 0) {
                //crear una ventana para modificar la ota y el estado
            }
        }

        private void RegistrarNotasAlumnosLista_Load(object sender, EventArgs e) {
            dgvAlumnos.DataSource = new CursoLogic().GetAlumnosEnCurso(myCursoId);
        }
    }
}
