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
    public partial class CursoDetalle : ApplicationForm {

        Curso cursoActual;

        List<Materia> listaMaterias;
        List<Comision> listaComision;

        public CursoDetalle(ModoForm modo) {
            InitializeComponent();
            this.modo = modo;
            GetListaComision();
            GetListaMaterias();
        }

        public CursoDetalle(int id, ModoForm modo) {
            InitializeComponent();
            this.modo = modo;
            GetListaComision();
            GetListaMaterias();

            CursoLogic cl = new CursoLogic();
            cursoActual = cl.GetOne(id);
            MapearDeDatos();
        }

        private void GetListaMaterias() {
            MateriaLogic ml = new MateriaLogic();
            listaMaterias = ml.GetAll();

            foreach(Materia mat in listaMaterias) {
                cmbboxMateria.Items.Add(mat.ID + " - " + mat.descripcion);
            }
        }

        private void GetListaComision() {
            ComisionLogic cl = new ComisionLogic();
            listaComision = cl.GetAll();

            foreach(Comision com in listaComision) {
                cmbboxComision.Items.Add(com.ID + " - " + com.Descripcion);
            }
        }

        public override void MapearDeDatos() {
            txtboxId.Text = cursoActual.ID.ToString();
            txtboxAnio.Text = cursoActual.AnioCalendario.ToString();
            txtboxCupo.Text = cursoActual.Cupo.ToString();

            ComisionLogic cl = new ComisionLogic();
            int idComision = cl.GetOne(cursoActual.IdComision).ID;
            cmbboxComision.SelectedIndex = listaComision.FindIndex((Comision c) => { return c.ID.Equals(idComision); });

            MateriaLogic ml = new MateriaLogic();
            int idMateria = ml.GetOne(cursoActual.IdMateria).ID;
            cmbboxMateria.SelectedIndex = listaMaterias.FindIndex((Materia m) => { return m.ID.Equals(idMateria); });

            switch (modo) {
                case ModoForm.Alta:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    break;
                case ModoForm.Modificacion:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    break;
            }
        }

        public override void MapearADatos() {
            switch (modo) {
                case ModoForm.Alta:
                    cursoActual = new Curso();
                    cursoActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Baja:
                    cursoActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Modificacion:
                    cursoActual.State = BusinessEntity.States.Modified;
                    break;
            }

            cursoActual.AnioCalendario = int.Parse(this.txtboxAnio.Text);
            cursoActual.Cupo = int.Parse(this.txtboxCupo.Text);

            int index = cmbboxComision.SelectedIndex;
            cursoActual.IdComision = listaComision[index].ID;

            index = cmbboxMateria.SelectedIndex;
            cursoActual.IdMateria = listaMaterias[index].ID;
        }

        public override void GuardarDatos() {
            MapearADatos();

            CursoLogic cl = new CursoLogic();
            cl.Save(cursoActual);
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            GuardarDatos();
            Close();
        }
    }
}
