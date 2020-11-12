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
using Util;

namespace UI.Desktop {
    public partial class MainMenu : Form {

        bool logOut = false;
        //Usuario currentUser;
        //List<ModuloUsuario> currentPermisos;

        public MainMenu() {
            InitializeComponent();
        }

        private void HideListas() {
            titleListas.Visible = false;
            divider1.Visible = false;
            btnUsuarios.Visible = false;
            btnAlumnos.Visible = false;
            btnProfesores.Visible = false;
            btnEspecialidades.Visible = false;
            btnPlanes.Visible = false;
            btnCurso.Visible = false;
            btnComisiones.Visible = false;
        }

        private void HideAlumnos() {
            titleAlumnos.Visible = false;
            divider2.Visible = false;
            btnInscripcion.Visible = false;
        }

        private void HideProfesores() {
            titleProfesores.Visible = false;
            divider3.Visible = false;
            btnNotas.Visible = false;
            btnReporteCurso.Visible = false;
            btnReportePlanes.Visible = false;
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e) {
            if (logOut) {
                UsuarioLogIn.logIn.Show();
            }
            else {
                UsuarioLogIn.logIn.Close();
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e) {
            Usuarios usuarioList = new Usuarios();
            usuarioList.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e) {
            logOut = true;
            this.Close();
        }

        private void btnAlumnos_Click(object sender, EventArgs e) {
            AlumnosList alumnosList = new AlumnosList();
            alumnosList.ShowDialog();
        }

        private void btnEspecialidades_Click(object sender, EventArgs e) {
            EspecialidadesList especialidadesList = new EspecialidadesList();
            especialidadesList.ShowDialog();
        }

        private void btnPlanes_Click(object sender, EventArgs e) {
            PlanList planList = new PlanList();
            planList.ShowDialog();
        }

        private void btnComisiones_Click(object sender, EventArgs e) {
            ComisionesList comisionesList = new ComisionesList();
            comisionesList.ShowDialog();
        }

        private void btnProfesores_Click(object sender, EventArgs e) {
            ProfesoresList profesoresList = new ProfesoresList();
            profesoresList.ShowDialog();
        }

        private void btnCurso_Click(object sender, EventArgs e) {
            CursoList cursoList = new CursoList();
            cursoList.ShowDialog();
        }

        private void MainMenu_Load(object sender, EventArgs e) {
            tsmItemUsrName.Text = CurrentUser.GetUsrName();

            int permisoModuloId = CurrentUser.Permiso.idModulo;

            if (permisoModuloId != 14) {
                HideListas();
            }
            if(permisoModuloId != 15) {
                HideAlumnos();
            }
            if(permisoModuloId != 16) {
                HideProfesores();
            }
        }
    }
}
