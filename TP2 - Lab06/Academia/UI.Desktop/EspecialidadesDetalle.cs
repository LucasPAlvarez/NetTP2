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
    public partial class EspecialidadesDetalle : ApplicationForm {

        public Especialidad especialidadActual;

        public EspecialidadesDetalle(ModoForm modo) {
            InitializeComponent();
            this.modo = modo;
        }

        public EspecialidadesDetalle(int Id, ModoForm modo) {
            InitializeComponent();

            this.modo = modo;
            EspecialidadLogic el = new EspecialidadLogic();
            especialidadActual = el.GetOne(Id);
            MapearDeDatos();
        }

        public override void MapearDeDatos() {
            this.txtBoxId.Text = especialidadActual.ID.ToString();
            this.txtBoxEspecialidad.Text = especialidadActual.Descripcion;

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
                    especialidadActual = new Especialidad();
                    especialidadActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Baja:
                    especialidadActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Modificacion:
                    especialidadActual.State = BusinessEntity.States.Modified;
                    break;
            }

            especialidadActual.Descripcion = this.txtBoxEspecialidad.Text;
        }

        public override void GuardarDatos() {
            MapearADatos();

            EspecialidadLogic el = new EspecialidadLogic();
            el.Save(especialidadActual);
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
