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
    public partial class InscripcionMateriaList : Form {
        public InscripcionMateriaList() {
            InitializeComponent();
        }

        private void InscripcionMateriaList_Load(object sender, EventArgs e) {
            lblAlNom.Text = CurrentUser.GetPersonaName();
            lblPlanNom.Text = CurrentUser.GetPlanName();

            dgvMaterias.DataSource = new MateriaLogic().MateriasAlumno(CurrentUser.GetUsrId());
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            InscripcionMateriaNueva imn = new InscripcionMateriaNueva();
            imn.ShowDialog();
        }
    }
}
