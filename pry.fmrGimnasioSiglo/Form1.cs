using System.Diagnostics.Eventing.Reader;

namespace pry.fmrGimnasioSiglo
{
    public partial class fmrInscripcion : Form
    {
        const decimal PRECIO_MUSCULACION = 15000m;
        const decimal PRECIO_FUNCIONAL = 18000m;
        const decimal PRECIO_NATACION = 22000m;
        const decimal PRECIO_CASILLERO = 3000m;
        const int EDAD_MINIMA = 14;
        const decimal DESCUENTO_MENOR = 0.25m;
        const decimal DESCUENTO_MAYOR = 0.30m;
        const decimal DESCUENTO_ESTUDIANTE = 0.15m;
        const decimal DESCUENTO_EFECTIVO = 0.10m;
        const decimal RECARGO_3_CUOTAS = 0.10m;
        const decimal RECARGO_6_CUOTAS = 0.20m;
        public fmrInscripcion()
        {
            InitializeComponent();
        }

        private void lblPlan_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void EstadoInicial()

        {

            txtNombre.Text = "";
            txtEdad.Text = "";
            txtCantidadDeMeses.Text = "1";
            chkEstudiante.Checked = false;
            chkCasillero.Checked = false;
            cboPlan.SelectedIndex = 0;
            cboTurno.SelectedIndex = 0;
            rbtEfectivo.Checked = true;
            cboCuotas.SelectedIndex = -1;
            cboCuotas.Enabled = false;
            btnCalcular.Enabled = false;
            txtNombre.Focus();
        }

        private void lblMeses_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre = "";
            int edad = 0;
            int meses = 0;

            decimal precioMensual = 0m;
            decimal subtotal = 0m;
            decimal porcentajeDescuento = 0m;
            decimal porcentajeAjustePago = 0m;
            decimal total = 0m;
            decimal valorCuota = 0m;

            edad = int.Parse(txtEdad.Text);
            meses = int.Parse(txtCantidadDeMeses.Text);

            if (edad < EDAD_MINIMA)
            {
                MessageBox.Show("La edad es menor a la que esta permitida");
                return;
            }
            if (meses < 1 || meses > 12)
            {

                MessageBox.Show("La cantidad de meses tiene que estar entre 1 y 12 ");
                return;

                string plan = cboPlan.Text;

                switch (plan)
                {
                    case "Plan de Musculación":
                        precioMensual = PRECIO_MUSCULACION;
                        break;

                    case "Plan de Funcional":
                        precioMensual = PRECIO_FUNCIONAL;
                        break;

                    case " Plan de Natación":
                        precioMensual = PRECIO_NATACION;
                        break;

                    default:
                        MessageBox.Show("Plan inválido");
                        return;

                        string horario = "";
                        switch (cboTurno.SelectedIndex)
                        {
                            case 0:
                                horario = "7 a 12 horas";
                                break;

                            case 1:
                                horario = "14 a 18 horas";
                                break;

                            case 2:
                                horario = "18 a 23 horas";
                                break;

                            default:
                                horario = "Turno inválido";
                                break;
                        }
                        if (chkCasillero.Checked) precioMensual += PRECIO_CASILLERO;
                        subtotal = precioMensual * meses;

                        if (edad < 18)
                        {
                            porcentajeDescuento = DESCUENTO_MENOR;
                        }
                        else if (edad >= 65)
                        {
                            porcentajeDescuento = DESCUENTO_MAYOR;
                        }
                        else if (chkEstudiante.Checked)
                        {
                            porcentajeDescuento = DESCUENTO_ESTUDIANTE;
                        }
                        else
                        {
                            porcentajeDescuento = 0m;
                        }

                        subtotal = subtotal - (subtotal * porcentajeDescuento);
                        {

                        }
                        
                        
                }
            }
        }
              
                
                


        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 59 ||
                e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCantidadDeMeses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 59 ||
                e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNombre.Text.Length == 0 && char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtEdad.Text != "" && txtCantidadDeMeses.Text != "")
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }
    }
}

