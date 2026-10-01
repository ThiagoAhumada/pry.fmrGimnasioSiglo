namespace pry.fmrGimnasioSiglo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            chkEstudiante = new CheckBox();
            gpxDatosPersonales = new GroupBox();
            lblEdad = new Label();
            lblNombre = new Label();
            cboPlan = new ComboBox();
            cboTurno = new ComboBox();
            lblPlan = new Label();
            lblTurno = new Label();
            textBox1 = new TextBox();
            lblMeses = new Label();
            chkCasillero = new CheckBox();
            gpxPlan = new GroupBox();
            rbtEfectivo = new RadioButton();
            rbtTarjeta = new RadioButton();
            cboCuotas = new ComboBox();
            gpxFormaDePago = new GroupBox();
            lblCuotas = new Label();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            gpxDatosPersonales.SuspendLayout();
            gpxPlan.SuspendLayout();
            gpxFormaDePago.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(88, 22);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(136, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(88, 51);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(67, 23);
            txtEdad.TabIndex = 1;
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.CheckAlign = ContentAlignment.MiddleRight;
            chkEstudiante.ImageAlign = ContentAlignment.MiddleRight;
            chkEstudiante.Location = new Point(8, 95);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(89, 19);
            chkEstudiante.TabIndex = 2;
            chkEstudiante.Text = "Estudiante ?";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // gpxDatosPersonales
            // 
            gpxDatosPersonales.Controls.Add(lblEdad);
            gpxDatosPersonales.Controls.Add(lblNombre);
            gpxDatosPersonales.Controls.Add(chkEstudiante);
            gpxDatosPersonales.Controls.Add(txtEdad);
            gpxDatosPersonales.Controls.Add(txtNombre);
            gpxDatosPersonales.ForeColor = Color.Black;
            gpxDatosPersonales.Location = new Point(12, 24);
            gpxDatosPersonales.Name = "gpxDatosPersonales";
            gpxDatosPersonales.Size = new Size(288, 124);
            gpxDatosPersonales.TabIndex = 3;
            gpxDatosPersonales.TabStop = false;
            gpxDatosPersonales.Text = "Datos Personales";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(8, 57);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(39, 15);
            lblEdad.TabIndex = 4;
            lblEdad.Text = "Edad :";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(8, 25);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(57, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre :";
            // 
            // cboPlan
            // 
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FormattingEnabled = true;
            cboPlan.Items.AddRange(new object[] { "Musculacion", "Funcional", "Natacion" });
            cboPlan.Location = new Point(76, 37);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(121, 23);
            cboPlan.TabIndex = 4;
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.FormattingEnabled = true;
            cboTurno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            cboTurno.Location = new Point(76, 72);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(121, 23);
            cboTurno.TabIndex = 5;
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(13, 40);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(36, 15);
            lblPlan.TabIndex = 6;
            lblPlan.Text = "Plan :";
            lblPlan.Click += lblPlan_Click;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(13, 75);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(45, 15);
            lblTurno.TabIndex = 7;
            lblTurno.Text = "Turno :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 101);
            textBox1.MaxLength = 2;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(54, 23);
            textBox1.TabIndex = 8;
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.Location = new Point(13, 104);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(113, 15);
            lblMeses.TabIndex = 9;
            lblMeses.Text = "Cantidad de Meses :";
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.CheckAlign = ContentAlignment.MiddleRight;
            chkCasillero.Location = new Point(13, 140);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(139, 19);
            chkCasillero.TabIndex = 10;
            chkCasillero.Text = "Casillero ($3000/mes)";
            chkCasillero.UseVisualStyleBackColor = true;
            // 
            // gpxPlan
            // 
            gpxPlan.Controls.Add(chkCasillero);
            gpxPlan.Controls.Add(lblMeses);
            gpxPlan.Controls.Add(textBox1);
            gpxPlan.Controls.Add(lblTurno);
            gpxPlan.Controls.Add(lblPlan);
            gpxPlan.Controls.Add(cboTurno);
            gpxPlan.Controls.Add(cboPlan);
            gpxPlan.Location = new Point(12, 163);
            gpxPlan.Name = "gpxPlan";
            gpxPlan.Size = new Size(327, 164);
            gpxPlan.TabIndex = 11;
            gpxPlan.TabStop = false;
            gpxPlan.Text = "Plan De Gimnasio";
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(26, 36);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(67, 19);
            rbtEfectivo.TabIndex = 12;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(121, 36);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(60, 19);
            rbtTarjeta.TabIndex = 13;
            rbtTarjeta.TabStop = true;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            // 
            // cboCuotas
            // 
            cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Items.AddRange(new object[] { "1", "3", "6" });
            cboCuotas.Location = new Point(121, 61);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(121, 23);
            cboCuotas.TabIndex = 14;
            // 
            // gpxFormaDePago
            // 
            gpxFormaDePago.Controls.Add(lblCuotas);
            gpxFormaDePago.Controls.Add(cboCuotas);
            gpxFormaDePago.Controls.Add(rbtTarjeta);
            gpxFormaDePago.Controls.Add(rbtEfectivo);
            gpxFormaDePago.Location = new Point(12, 347);
            gpxFormaDePago.Name = "gpxFormaDePago";
            gpxFormaDePago.Size = new Size(276, 109);
            gpxFormaDePago.TabIndex = 16;
            gpxFormaDePago.TabStop = false;
            gpxFormaDePago.Text = "Forma De Pago";
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(4, 68);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(111, 15);
            lblCuotas.TabIndex = 15;
            lblCuotas.Text = "Cantidad de Cuotas";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(162, 474);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(92, 30);
            btnCalcular.TabIndex = 17;
            btnCalcular.Text = "&Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(38, 474);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(85, 30);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "&Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 537);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(gpxFormaDePago);
            Controls.Add(gpxPlan);
            Controls.Add(gpxDatosPersonales);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo - Incripciones";
            gpxDatosPersonales.ResumeLayout(false);
            gpxDatosPersonales.PerformLayout();
            gpxPlan.ResumeLayout(false);
            gpxPlan.PerformLayout();
            gpxFormaDePago.ResumeLayout(false);
            gpxFormaDePago.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtEdad;
        private CheckBox chkEstudiante;
        private GroupBox gpxDatosPersonales;
        private Label lblEdad;
        private Label lblNombre;
        private ComboBox cboPlan;
        private ComboBox cboTurno;
        private Label lblPlan;
        private Label lblTurno;
        private TextBox textBox1;
        private Label lblMeses;
        private CheckBox chkCasillero;
        private GroupBox gpxPlan;
        private RadioButton rbtEfectivo;
        private RadioButton rbtTarjeta;
        private ComboBox cboCuotas;
        private GroupBox gpxFormaDePago;
        private Button button1;
        private Button btnCalcular;
        private Label lblCuotas;
        private Button btnLimpiar;
        private Button button3;
    }
}
