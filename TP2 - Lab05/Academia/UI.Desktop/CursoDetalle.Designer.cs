namespace UI.Desktop {
    partial class CursoDetalle {
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
            this.ID = new System.Windows.Forms.Label();
            this.txtboxId = new System.Windows.Forms.TextBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblCupo = new System.Windows.Forms.Label();
            this.txtboxAnio = new System.Windows.Forms.TextBox();
            this.txtboxCupo = new System.Windows.Forms.TextBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblComision = new System.Windows.Forms.Label();
            this.cmbboxMateria = new System.Windows.Forms.ComboBox();
            this.cmbboxComision = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(454, 241);
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
            this.btnAceptar.Location = new System.Drawing.Point(373, 240);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.txtboxAnio, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtboxId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAnio, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCupo, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtboxCupo, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblComision, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblMateria, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbboxMateria, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbboxComision, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(517, 215);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(3, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(97, 23);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            this.ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtboxId
            // 
            this.txtboxId.Location = new System.Drawing.Point(106, 3);
            this.txtboxId.Name = "txtboxId";
            this.txtboxId.ReadOnly = true;
            this.txtboxId.Size = new System.Drawing.Size(148, 20);
            this.txtboxId.TabIndex = 1;
            // 
            // lblAnio
            // 
            this.lblAnio.Location = new System.Drawing.Point(3, 30);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(97, 23);
            this.lblAnio.TabIndex = 2;
            this.lblAnio.Text = "Año calendario";
            this.lblAnio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCupo
            // 
            this.lblCupo.Location = new System.Drawing.Point(261, 30);
            this.lblCupo.Name = "lblCupo";
            this.lblCupo.Size = new System.Drawing.Size(97, 23);
            this.lblCupo.TabIndex = 3;
            this.lblCupo.Text = "Cupo";
            this.lblCupo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtboxAnio
            // 
            this.txtboxAnio.Location = new System.Drawing.Point(106, 33);
            this.txtboxAnio.Name = "txtboxAnio";
            this.txtboxAnio.Size = new System.Drawing.Size(148, 20);
            this.txtboxAnio.TabIndex = 4;
            // 
            // txtboxCupo
            // 
            this.txtboxCupo.Location = new System.Drawing.Point(364, 33);
            this.txtboxCupo.Name = "txtboxCupo";
            this.txtboxCupo.Size = new System.Drawing.Size(148, 20);
            this.txtboxCupo.TabIndex = 5;
            // 
            // lblMateria
            // 
            this.lblMateria.Location = new System.Drawing.Point(3, 80);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(97, 23);
            this.lblMateria.TabIndex = 6;
            this.lblMateria.Text = "Materia";
            this.lblMateria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblComision
            // 
            this.lblComision.Location = new System.Drawing.Point(3, 129);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(97, 23);
            this.lblComision.TabIndex = 7;
            this.lblComision.Text = "Comision";
            this.lblComision.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbboxMateria
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cmbboxMateria, 3);
            this.cmbboxMateria.FormattingEnabled = true;
            this.cmbboxMateria.Location = new System.Drawing.Point(106, 83);
            this.cmbboxMateria.Name = "cmbboxMateria";
            this.cmbboxMateria.Size = new System.Drawing.Size(330, 21);
            this.cmbboxMateria.TabIndex = 8;
            // 
            // cmbboxComision
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cmbboxComision, 3);
            this.cmbboxComision.FormattingEnabled = true;
            this.cmbboxComision.Location = new System.Drawing.Point(106, 132);
            this.cmbboxComision.Name = "cmbboxComision";
            this.cmbboxComision.Size = new System.Drawing.Size(330, 21);
            this.cmbboxComision.TabIndex = 9;
            // 
            // CursoDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 276);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "CursoDetalle";
            this.Text = "CursoDetalle";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtboxAnio;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox txtboxId;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblCupo;
        private System.Windows.Forms.TextBox txtboxCupo;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.ComboBox cmbboxMateria;
        private System.Windows.Forms.ComboBox cmbboxComision;
    }
}