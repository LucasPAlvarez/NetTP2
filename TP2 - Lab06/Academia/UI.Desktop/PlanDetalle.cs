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
    public partial class PlanDetalle : ApplicationForm {

        Plan planActual;
        List<Especialidad> listaEspecialidades;

        public PlanDetalle(ModoForm modo) {
            InitializeComponent();
            this.modo = modo;
            getListEspecialidades();

            
        }

        public PlanDetalle(int id, ModoForm modo) {
            InitializeComponent();
            this.modo = modo;
            getListEspecialidades();

            PlanLogic pl = new PlanLogic();
            planActual = pl.GetOne(id);
            MapearDeDatos();
        }

        public void getListEspecialidades() {
            EspecialidadLogic el = new EspecialidadLogic();
            listaEspecialidades = el.GetAll();
            foreach (Especialidad esp in listaEspecialidades) {
                cmbboxEspecialidad.Items.Add(esp.ID + " - " + esp.Descripcion);
            }
        }

        public override void MapearDeDatos() {

            this.txtBoxId.Text = planActual.ID.ToString();
            this.txtboxDescripcion.Text = planActual.Desripcion;

            EspecialidadLogic el = new EspecialidadLogic();
            Especialidad temp = el.GetOne(planActual.IdEspecialidad);
            int index = listaEspecialidades.FindIndex((Especialidad e) => { return e.ID.Equals(temp.ID); });
            this.cmbboxEspecialidad.SelectedIndex = index;

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
                    planActual = new Plan();
                    planActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Baja:
                    planActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Modificacion:
                    planActual.State = BusinessEntity.States.Modified;
                    break;
            }

            planActual.Desripcion = txtboxDescripcion.Text;

            int index = cmbboxEspecialidad.SelectedIndex;
            Especialidad espTemp = listaEspecialidades[index];
            planActual.IdEspecialidad = espTemp.ID;
        }

        public override void GuardarDatos() {
            MapearADatos();

            PlanLogic pl = new PlanLogic();
            pl.Save(planActual);
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
