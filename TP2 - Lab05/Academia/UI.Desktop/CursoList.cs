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
    public partial class CursoList : Form {
        public CursoList() {
            InitializeComponent();
        }

        private void Listar() {
            dgvCurso.AutoGenerateColumns = false;
            CursoLogic cl = new CursoLogic();
            dgvCurso.DataSource = cl.GetAll();
        }

        private void CursoList_Load(object sender, EventArgs e) {
            Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e) {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e) {
            CursoDetalle cursoDetalle = new CursoDetalle(ModoForm.Alta);
            cursoDetalle.ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e) {
            if (dgvCurso.SelectedRows.Count > 0) {
                int index = ((Curso)dgvCurso.SelectedRows[0].DataBoundItem).ID;
                CursoDetalle cursoDetalle = new CursoDetalle(index, ModoForm.Modificacion);
                cursoDetalle.ShowDialog();
                Listar();
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e) {
            if(dgvCurso.SelectedRows.Count > 0) {
                int index = ((Curso)dgvCurso.SelectedRows[0].DataBoundItem).ID;
                CursoDetalle cursoDetalle = new CursoDetalle(index, ModoForm.Baja);
                cursoDetalle.ShowDialog();
                Listar();
            }
        }
    }
}
