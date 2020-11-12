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
    public partial class PersonaDetalle : ApplicationForm {

        Persona personaActual;
        TiposPersonas thisTipo;

        List<Plan> listaPlanes = new List<Plan>();

        public PersonaDetalle(ModoForm modo, TiposPersonas tipoInput) {
            InitializeComponent();
            this.modo = modo;
            this.thisTipo = tipoInput;
            loadPlanes();
            SetTitle();
        }

        public PersonaDetalle(int id, ModoForm modo) {
            InitializeComponent();
            PersonaLogic pl = new PersonaLogic();
            personaActual = pl.GetOne(id);
            this.modo = modo;
            this.thisTipo = personaActual.TipoPersona;
            loadPlanes();
            SetTitle();

            MapearDeDatos();
        }

        public void loadPlanes() {
            PlanLogic pl = new PlanLogic();
            listaPlanes = pl.GetAll();

            foreach (Plan p in listaPlanes) {
                int indexActual =  this.cmbboxPlan.Items.Add(p.ID.ToString() + " - " + p.Desripcion);
            }
        }

        public void SetTitle() {
            if (thisTipo == TiposPersonas.alumno) {
                this.Text = "Alumno Detalle";
            }
            else {
                this.Text = "Docente Detalle";
            }
        }

        public override void MapearDeDatos() {
            this.txtBoxId.Text = personaActual.ID.ToString();
            this.txtBoxNombre.Text = personaActual.Nombre;
            this.txtboxApellido.Text = personaActual.Apellido;
            this.txtboxDireccion.Text = personaActual.Direccion;
            this.txtboxEmail.Text = personaActual.Email;
            this.txtboxTelefono.Text = personaActual.Telefono;
            this.txtboxLegajo.Text = personaActual.Legajo.ToString();

            this.txtboxDia.Text = personaActual.FechaNacimiento.Day.ToString();
            this.txtboxMes.Text = personaActual.FechaNacimiento.Month.ToString();
            this.txtboxAnio.Text = personaActual.FechaNacimiento.Year.ToString();


            PlanLogic pl = new PlanLogic();
            Plan planActual = pl.GetOne(personaActual.IdPlan);
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
                    personaActual = new Persona();
                    personaActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Baja:
                    personaActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Modificacion:
                    personaActual.State = BusinessEntity.States.Modified;
                    break;
            }

            personaActual.Nombre = this.txtBoxNombre.Text;
            personaActual.Apellido = this.txtboxApellido.Text;
            personaActual.Direccion = this.txtboxDireccion.Text;
            personaActual.Email = this.txtboxEmail.Text;
            personaActual.Telefono = this.txtboxTelefono.Text;
            personaActual.Legajo = int.Parse(this.txtboxLegajo.Text);

            int dia = int.Parse(this.txtboxDia.Text);
            int mes = int.Parse(this.txtboxMes.Text);
            int año = int.Parse(this.txtboxAnio.Text);
            personaActual.FechaNacimiento = new DateTime(año, mes, dia);

            personaActual.TipoPersona = thisTipo;

            int temp = this.cmbboxPlan.SelectedIndex;
            Plan tempPlan = listaPlanes[temp];
            personaActual.IdPlan = tempPlan.ID;
        }

        public override void GuardarDatos() {
            MapearADatos();

            PersonaLogic pl = new PersonaLogic();
            pl.Save(personaActual);
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
