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
    public partial class PersonasList : Form {
        public PersonasList() {
            InitializeComponent();
        }

        private void Listar() {
            dgvProfesores.AutoGenerateColumns = false;
            PersonaLogic pl = new PersonaLogic();
            dgvProfesores.DataSource = pl.GetAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e) {
            Listar();
        }

        private void ProfesoresList_Load(object sender, EventArgs e) {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e) {
            PersonaDetalle perDetalle = new PersonaDetalle(ModoForm.Alta/*, TiposPersonas.docente*/);
            perDetalle.ShowDialog();
            Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e) {
            if (this.dgvProfesores.SelectedRows.Count > 0) {
                int alumnoId = ((Persona)dgvProfesores.SelectedRows[0].DataBoundItem).ID;
                PersonaDetalle perDetalle = new PersonaDetalle(alumnoId, ModoForm.Baja);
                perDetalle.ShowDialog();
                Listar();
            }
        }

        private void tsbEditar_Click(object sender, EventArgs e) {
            if (this.dgvProfesores.SelectedRows.Count > 0) {
                int alumnoId = ((Persona)dgvProfesores.SelectedRows[0].DataBoundItem).ID;
                PersonaDetalle perDetalle = new PersonaDetalle(alumnoId, ModoForm.Modificacion);
                perDetalle.ShowDialog();
                Listar();
            }
        }
    }
}
