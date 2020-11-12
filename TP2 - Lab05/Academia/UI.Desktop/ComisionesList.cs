﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop {
    public partial class ComisionesList : Form {
        public ComisionesList() {
            InitializeComponent();
        }

        private void Listar() {
            dgvComisiones.AutoGenerateColumns = false;
            ComisionLogic cl = new ComisionLogic();
            dgvComisiones.DataSource = cl.GetAll();
        }

        private void ComisionesList_Load(object sender, EventArgs e) {
            Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e) {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e) {
            ComisionesDetalle comDetalle = new ComisionesDetalle(ModoForm.Alta);
            comDetalle.ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e) {
            if (this.dgvComisiones.SelectedRows.Count > 0) {
                int idInput = ((Comision)this.dgvComisiones.SelectedRows[0].DataBoundItem).ID;
                ComisionesDetalle comDetalle = new ComisionesDetalle(idInput, ModoForm.Modificacion);
                comDetalle.ShowDialog();
                Listar();
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e) {
            if (this.dgvComisiones.SelectedRows.Count > 0) {
                int idInput = ((Comision)this.dgvComisiones.SelectedRows[0].DataBoundItem).ID;
                ComisionesDetalle comDetalle = new ComisionesDetalle(idInput, ModoForm.Baja);
                comDetalle.ShowDialog();
                Listar();
            }
        }
    }
}
