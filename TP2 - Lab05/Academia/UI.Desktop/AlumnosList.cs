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
    public partial class AlumnosList : Form {
        public AlumnosList() {
            InitializeComponent();
        }

        public void Listar() {
            this.dgvAlumnos.AutoGenerateColumns = false;
            PersonaLogic pl = new PersonaLogic();
            this.dgvAlumnos.DataSource = pl.GetAllAlumnos();
            
        }

        private void AlumnosList_Load(object sender, EventArgs e) {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e) {
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e) {
            if (this.dgvAlumnos.SelectedRows.Count > 0) {
                int alumnoId = ((Persona)dgvAlumnos.SelectedRows[0].DataBoundItem).ID;
                PersonaDetalle perDetalle = new PersonaDetalle(alumnoId, ModoForm.Baja);
                perDetalle.ShowDialog();
                Listar();
            }
        }

        private void tsbEditar_Click(object sender, EventArgs e) {
            if (this.dgvAlumnos.SelectedRows.Count > 0) {
                int alumnoId = ((Persona)dgvAlumnos.SelectedRows[0].DataBoundItem).ID;
                PersonaDetalle perDetalle = new PersonaDetalle(alumnoId, ModoForm.Modificacion);
                perDetalle.ShowDialog();
                Listar();
            }
        }

        private void tsbNuevo_Click(object sender, EventArgs e) {
            PersonaDetalle perDetalle = new PersonaDetalle(ModoForm.Alta, TiposPersonas.alumno);
            perDetalle.ShowDialog();
            Listar();
        }
    }
}
