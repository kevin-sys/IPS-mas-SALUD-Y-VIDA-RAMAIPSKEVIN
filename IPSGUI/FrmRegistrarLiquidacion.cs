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

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            LiquidacionCuotaModeradoraService service = new LiquidacionCuotaModeradoraService();
            if (CmbTipoAfiliacion.Text.Equals("Contributivo"))
            {
                
                LiquidacionCuotaModeradora moderadora = new Contributivo();
                moderadora.NumeroLiquidacion = TxtNumeroLiquidacion.Text.Trim();
                moderadora.Identificacion = TxtIdentificacion.Text.Trim();
                moderadora.FechaLiquidacion = DtpFechaLiquidacion.Value;
                moderadora.SalarioDevengado = double.Parse(TxtSalarioDevengado.Text.Trim());
                moderadora.TipoAfiliacion = CmbTipoAfiliacion.Text.Trim();
                moderadora.ValorServicioHospitalizacion = double.Parse(TxtValorHospitalizacion.Text.Trim());
                moderadora.CalcularTarifa();
                service.Modificar(moderadora);
                MessageBox.Show("SE MODIFICO CORRECTAMENTE EL REGISTRO");

            }
            else if (CmbTipoAfiliacion.Text.Equals("Subsidiado"))
            {

                LiquidacionCuotaModeradora Subsidiado = new Subsidiado();
                Subsidiado.NumeroLiquidacion = TxtNumeroLiquidacion.Text.Trim();
                Subsidiado.Identificacion = TxtIdentificacion.Text.Trim();
                Subsidiado.FechaLiquidacion = DtpFechaLiquidacion.Value;
                Subsidiado.SalarioDevengado = double.Parse(TxtSalarioDevengado.Text.Trim());
                Subsidiado.TipoAfiliacion = CmbTipoAfiliacion.Text.Trim();
                Subsidiado.ValorServicioHospitalizacion = double.Parse(TxtValorHospitalizacion.Text.Trim());
                Subsidiado.CalcularTarifa();
                service.Modificar(Subsidiado);
                MessageBox.Show("SE MODIFICO CORRECTAMENTE EL REGISTRO");
            }
        }
    }
}
