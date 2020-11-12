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
    public partial class EspecialidadesList : Form {
        public EspecialidadesList() {
            InitializeComponent();
        }

        private void Listar() {
            this.dgvEspecialidades.AutoGenerateColumns = false;
            EspecialidadLogic el = new EspecialidadLogic();
            this.dgvEspecialidades.DataSource = el.GetAll();
        }

        private void EspecialidadesList_Load(object sender, EventArgs e) {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e) {
            this.Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e) {
            EspecialidadesDetalle espDetalle = new EspecialidadesDetalle(ModoForm.Alta);
            espDetalle.ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e) {
            if (dgvEspecialidades.SelectedRows.Count == 1) {
                int inputId = ((Especialidad)dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
                EspecialidadesDetalle espDetalle = new EspecialidadesDetalle(inputId, ModoForm.Modificacion);
                espDetalle.ShowDialog();
                Listar();
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e) {
            if (dgvEspecialidades.SelectedRows.Count == 1) {
                int inputId = ((Especialidad)dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
                EspecialidadesDetalle espDetalle = new EspecialidadesDetalle(inputId, ModoForm.Baja);
                espDetalle.ShowDialog();
                Listar();
            }
        }
    }
}
