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
    public partial class PlanList : Form {
        public PlanList() {
            InitializeComponent();
        }

        private void Listar() {
            this.dgvPlan.AutoGenerateColumns = false;
            PlanLogic pl = new PlanLogic();
            this.dgvPlan.DataSource = pl.GetAll();
        }

        private void PlanList_Load(object sender, EventArgs e) {
            Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e) {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e) {
            PlanDetalle planDetalle = new PlanDetalle(ModoForm.Alta);
            planDetalle.ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e) {
            if(dgvPlan.SelectedRows.Count > 0) {
                int inputId = ((Plan)dgvPlan.SelectedRows[0].DataBoundItem).ID;
                PlanDetalle planDetalle = new PlanDetalle(inputId, ModoForm.Modificacion);
                planDetalle.ShowDialog();
                Listar();
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e) {
            if(dgvPlan.SelectedRows.Count > 0){
                int inputId = ((Plan)dgvPlan.SelectedRows[0].DataBoundItem).ID;
                PlanDetalle planDetalle = new PlanDetalle(inputId, ModoForm.Baja);
                planDetalle.ShowDialog();
                Listar();
            }
        }
    }
}
