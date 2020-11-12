using Business.Entities;
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
    public partial class ComisionesDetalle : ApplicationForm {

        Comision comisionActual;

        List<Plan> listaPlanes = new List<Plan>();

        public ComisionesDetalle(ModoForm modo) {
            InitializeComponent();
            this.modo = modo;
            loadPlanes();
        }


        public ComisionesDetalle(int id, ModoForm modo) {
            InitializeComponent();
            this.modo = modo;
            ComisionLogic cl = new ComisionLogic();
            comisionActual = cl.GetOne(id);
            loadPlanes();

            MapearDeDatos();
            
        }

        public void loadPlanes() {
            PlanLogic pl = new PlanLogic();
            listaPlanes = pl.GetAll();

            foreach (Plan p in listaPlanes) {
                this.cmbboxPlan.Items.Add(p.ID.ToString() + " - " + p.Desripcion);
            }
        }

        public override void MapearDeDatos() {
            txtboxId.Text = comisionActual.ID.ToString();
            txtboxAnioEsp.Text = comisionActual.AnioEspecialidad.ToString();
            txtboxDesc.Text = comisionActual.Descripcion;

            PlanLogic pl = new PlanLogic();
            Plan planActual = pl.GetOne(comisionActual.IdPlan);
            int indexSelected = listaPlanes.FindIndex((Plan p) => { return p.ID.Equals(planActual.ID); });
            this.cmbboxPlan.SelectedItem = this.cmbboxPlan.Items[indexSelected];

            switch (this.modo) {
                case ModoForm.Alta:
                    btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    btnAceptar.Text = "Eliminar";
                    break;
                case ModoForm.Modificacion:
                    btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Consulta:
                    btnAceptar.Text = "Aceptar";
                    break;
            }
        }

        public override void MapearADatos() {
            switch (modo) {
                case ModoForm.Alta:
                    comisionActual = new Comision();
                    comisionActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Baja:
                    comisionActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Modificacion:
                    comisionActual.State = BusinessEntity.States.Modified;
                    break;
            }

            comisionActual.AnioEspecialidad = int.Parse(txtboxAnioEsp.Text);
            comisionActual.Descripcion = txtboxDesc.Text;

            int temp = this.cmbboxPlan.SelectedIndex;
            Plan tempPlan = listaPlanes[temp];
            comisionActual.IdPlan = tempPlan.ID;
        }

        public override void GuardarDatos() {
            MapearADatos();

            ComisionLogic cl = new ComisionLogic();
            cl.Save(comisionActual);
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            GuardarDatos();
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
