using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace IPSGUI
{
    public partial class FrmLiquidacion : Form
    {
        LiquidacionCuotaModeradora liquidacion;
        public FrmLiquidacion()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            LiquidacionCuotaModeradoraService service = new LiquidacionCuotaModeradoraService();
            LiquidacionCuotaModeradora cuotaModeradora = MapearLiquidacion();
            cuotaModeradora.CalcularTarifa();
            string mensaje = service.Guardar(cuotaModeradora);
            MessageBox.Show(mensaje, "MENSAJE DE GUARDADO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private LiquidacionCuotaModeradora MapearLiquidacion()
        {
            if (CmbTipoAfiliacion.Text.Equals("Contributivo"))
            {
                liquidacion = new Contributivo();
                liquidacion.NumeroLiquidacion = TxtNumeroLiquidacion.Text;
                liquidacion.FechaLiquidacion = DtpFechaLiquidacion.Value.Date;
                liquidacion.Identificacion = TxtIdentificacion.Text;
                liquidacion.PrimerNombre = TxtPrimerNombre.Text.Trim();
                liquidacion.PrimerApellido = TxtPrimerApellido.Text.Trim();

                liquidacion.TipoAfiliacion = CmbTipoAfiliacion.Text;
                liquidacion.SalarioDevengado = double.Parse(TxtSalarioDevengado.Text);
                liquidacion.ValorServicioHospitalizacion = double.Parse(TxtValorHospitalizacion.Text);
                return liquidacion;
            }
            if (CmbTipoAfiliacion.Text.Equals("Subsidiado"))
            {
                liquidacion = new Subsidiado();
                liquidacion.NumeroLiquidacion = TxtNumeroLiquidacion.Text;
                liquidacion.FechaLiquidacion = DtpFechaLiquidacion.Value.Date;
                liquidacion.Identificacion = TxtIdentificacion.Text;
                liquidacion.PrimerNombre = TxtPrimerNombre.Text.Trim();
                liquidacion.PrimerApellido = TxtPrimerApellido.Text.Trim();
                liquidacion.TipoAfiliacion = CmbTipoAfiliacion.Text;
                liquidacion.SalarioDevengado = double.Parse(TxtSalarioDevengado.Text);
                liquidacion.ValorServicioHospitalizacion = double.Parse(TxtValorHospitalizacion.Text);
                return liquidacion;
            }
            return null;
        }

        private void FrmLiquidacion_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("ESTA SEGURO DE ELIMINAR EL REGISTRO", "MENSAJE DE ELIMINACIÓN", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes) 
            if (respuesta==DialogResult.Yes)
            {
                    LiquidacionCuotaModeradoraService service = new LiquidacionCuotaModeradoraService();
                    string numeroLiquidacion = TxtNumeroLiquidacion.Text.Trim();
                    string mensaje = service.Eliminar(numeroLiquidacion);
                    MessageBox.Show(mensaje);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            LiquidacionCuotaModeradoraService liquidacionCuota = new LiquidacionCuotaModeradoraService();
            string numeroLiquidacion = TxtNumeroLiquidacion.Text.Trim();
            if (numeroLiquidacion!="")
            {
                LiquidacionCuotaModeradora liquidacion = liquidacionCuota.BuscarID(numeroLiquidacion);
                if (liquidacion != null)
                {
                    TxtIdentificacion.Text = liquidacion.Identificacion;
                    TxtSalarioDevengado.Text = liquidacion.SalarioDevengado.ToString();
                    TxtValorHospitalizacion.Text = liquidacion.ValorServicioHospitalizacion.ToString();
                    CmbTipoAfiliacion.Text = liquidacion.TipoAfiliacion;
                    TxtPrimerNombre.Text = liquidacion.PrimerNombre;
                    TxtPrimerApellido.Text = liquidacion.PrimerApellido;
                    DtpFechaLiquidacion.Value = liquidacion.FechaLiquidacion;
                }
                else
                {
                    MessageBox.Show($"La liquidacion numero:  {numeroLiquidacion} no esta registrada");
                }
            }
            else
            {
                MessageBox.Show("Digite numero de la liquidacion");
            }
        }

        
    }
}
