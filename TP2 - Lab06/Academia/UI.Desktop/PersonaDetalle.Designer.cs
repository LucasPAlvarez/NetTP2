namespace UI.Desktop {
    partial class PersonaDetalle {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblId = new System.Windows.Forms.Label();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtboxApellido = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtboxTelefono = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtboxDireccion = new System.Windows.Forms.TextBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtboxLegajo = new System.Windows.Forms.TextBox();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSeparetor2 = new System.Windows.Forms.Label();
            this.txtboxDia = new System.Windows.Forms.TextBox();
            this.txtboxMes = new System.Windows.Forms.TextBox();
            this.txtboxAnio = new System.Windows.Forms.TextBox();
            this.lblSeparetor1 = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.cmbboxPlan = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(513, 244);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(432, 244);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 199F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 253F));
            this.tableLayoutPanel1.Controls.Add(this.lblId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNombre, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxNombre, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblApellido, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtboxApellido, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTelefono, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtboxTelefono, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblEmail, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtboxEmail, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDireccion, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtboxDireccion, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblLegajo, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtboxLegajo, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFechaNac, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblPlan, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.cmbboxPlan, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(576, 221);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(3, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(73, 23);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(82, 3);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.ReadOnly = true;
            this.txtBoxId.Size = new System.Drawing.Size(193, 20);
            this.txtBoxId.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(3, 42);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 23);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(82, 45);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(193, 20);
            this.txtBoxNombre.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.Location = new System.Drawing.Point(3, 72);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(73, 23);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtboxApellido
            // 
            this.txtboxApellido.Location = new System.Drawing.Point(82, 75);
            this.txtboxApellido.Name = "txtboxApellido";
            this.txtboxApellido.Size = new System.Drawing.Size(193, 20);
            this.txtboxApellido.TabIndex = 5;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Location = new System.Drawing.Point(3, 105);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(73, 23);
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Text = "Telefono";
            this.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtboxTelefono
            // 
            this.txtboxTelefono.Location = new System.Drawing.Point(82, 108);
            this.txtboxTelefono.Name = "txtboxTelefono";
            this.txtboxTelefono.Size = new System.Drawing.Size(190, 20);
            this.txtboxTelefono.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(289, 105);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(68, 23);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Location = new System.Drawing.Point(363, 108);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(204, 20);
            this.txtboxEmail.TabIndex = 9;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Location = new System.Drawing.Point(289, 72);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(68, 23);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Direccion";
            this.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtboxDireccion
            // 
            this.txtboxDireccion.Location = new System.Drawing.Point(363, 75);
            this.txtboxDireccion.Name = "txtboxDireccion";
            this.txtboxDireccion.Size = new System.Drawing.Size(204, 20);
            this.txtboxDireccion.TabIndex = 7;
            // 
            // lblLegajo
            // 
            this.lblLegajo.Location = new System.Drawing.Point(289, 42);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(68, 23);
            this.lblLegajo.TabIndex = 12;
            this.lblLegajo.Text = "Legajo";
            this.lblLegajo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtboxLegajo
            // 
            this.txtboxLegajo.Location = new System.Drawing.Point(363, 45);
            this.txtboxLegajo.Name = "txtboxLegajo";
            this.txtboxLegajo.Size = new System.Drawing.Size(204, 20);
            this.txtboxLegajo.TabIndex = 13;
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.Location = new System.Drawing.Point(3, 135);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(73, 31);
            this.lblFechaNac.TabIndex = 14;
            this.lblFechaNac.Text = "Fecha de Nacimiento";
            this.lblFechaNac.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.lblSeparetor2, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtboxDia, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtboxMes, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtboxAnio, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSeparetor1, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(82, 138);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(193, 25);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // lblSeparetor2
            // 
            this.lblSeparetor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparetor2.Location = new System.Drawing.Point(106, 0);
            this.lblSeparetor2.Name = "lblSeparetor2";
            this.lblSeparetor2.Size = new System.Drawing.Size(19, 23);
            this.lblSeparetor2.TabIndex = 20;
            this.lblSeparetor2.Text = "/";
            // 
            // txtboxDia
            // 
            this.txtboxDia.Location = new System.Drawing.Point(3, 3);
            this.txtboxDia.Name = "txtboxDia";
            this.txtboxDia.Size = new System.Drawing.Size(33, 20);
            this.txtboxDia.TabIndex = 16;
            // 
            // txtboxMes
            // 
            this.txtboxMes.Location = new System.Drawing.Point(67, 3);
            this.txtboxMes.Name = "txtboxMes";
            this.txtboxMes.Size = new System.Drawing.Size(33, 20);
            this.txtboxMes.TabIndex = 17;
            // 
            // txtboxAnio
            // 
            this.txtboxAnio.Location = new System.Drawing.Point(131, 3);
            this.txtboxAnio.Name = "txtboxAnio";
            this.txtboxAnio.Size = new System.Drawing.Size(59, 20);
            this.txtboxAnio.TabIndex = 18;
            // 
            // lblSeparetor1
            // 
            this.lblSeparetor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparetor1.Location = new System.Drawing.Point(42, 0);
            this.lblSeparetor1.Name = "lblSeparetor1";
            this.lblSeparetor1.Size = new System.Drawing.Size(19, 23);
            this.lblSeparetor1.TabIndex = 19;
            this.lblSeparetor1.Text = "/";
            // 
            // lblPlan
            // 
            this.lblPlan.Location = new System.Drawing.Point(3, 181);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(73, 31);
            this.lblPlan.TabIndex = 16;
            this.lblPlan.Text = "Plan";
            this.lblPlan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbboxPlan
            // 
            this.cmbboxPlan.FormattingEnabled = true;
            this.cmbboxPlan.Location = new System.Drawing.Point(82, 184);
            this.cmbboxPlan.Name = "cmbboxPlan";
            this.cmbboxPlan.Size = new System.Drawing.Size(190, 21);
            this.cmbboxPlan.TabIndex = 17;
            // 
            // PersonaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 279);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "PersonaDetalle";
            this.Text = "PersonaDetalle";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtboxApellido;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtboxDireccion;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtboxTelefono;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtboxLegajo;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblSeparetor2;
        private System.Windows.Forms.TextBox txtboxDia;
        private System.Windows.Forms.TextBox txtboxMes;
        private System.Windows.Forms.TextBox txtboxAnio;
        private System.Windows.Forms.Label lblSeparetor1;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.ComboBox cmbboxPlan;
    }
}