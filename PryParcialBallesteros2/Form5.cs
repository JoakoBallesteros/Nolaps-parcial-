using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PryParcialBallesteros2
{
    public partial class FrmEstadistica : Form
    {
        public FrmEstadistica()
        {
            InitializeComponent();
        }

        private void FrmEstadistica_Load(object sender, EventArgs e)
        {
            ConfigurarGrafico(ChartVenta, "Ventas");
            ConfigurarGrafico(ChartProduccion, "Producción");
            ConfigurarGrafico(ChartGasto, "Gastos");

            BtnDia.Click += BtnDia_Click;
            BtnSemana.Click += BtnSemana_Click;
            BtnMes.Click += BtnMes_Click;
        }

        private void ConfigurarGrafico(Chart chart, string tituloEjeY)
        {
            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart.ChartAreas.Add("ChartArea");

            chart.ChartAreas["ChartArea"].AxisY.Title = tituloEjeY;


        }

        private void BtnDia_Click(object sender, EventArgs e)
        {
         
            ActualizarGrafico(ChartVenta, ObtenerEstadisticasVentasDiarias(DateTime.Now));
            ActualizarGrafico(ChartProduccion, ObtenerEstadisticasProduccionDiarias(DateTime.Now));
            ActualizarGrafico(ChartGasto, ObtenerEstadisticasGastosDiarios(DateTime.Now));
        }

        private void BtnSemana_Click(object sender, EventArgs e)
        {
          
            ActualizarGrafico(ChartVenta, ObtenerEstadisticasVentasSemanles(DateTime.Now));
            ActualizarGrafico(ChartProduccion, ObtenerEstadisticasProduccionSemanal(DateTime.Now));
            ActualizarGrafico(ChartGasto, ObtenerEstadisticasGastosSemanal(DateTime.Now));
        }

        private void BtnMes_Click(object sender, EventArgs e)
        {

            ActualizarGrafico(ChartVenta, ObtenerEstadisticasVentasMensuales(DateTime.Now));
            ActualizarGrafico(ChartProduccion, ObtenerEstadisticasProduccionMensual(DateTime.Now));
            ActualizarGrafico(ChartGasto, ObtenerEstadisticasGastosMensuales(DateTime.Now));
        }

        private void ActualizarGrafico(Chart chart, List<Estadistica> estadisticas)
        {
            chart.Series.Clear();
            chart.Series.Add("Cantidad");

            foreach (Estadistica estadistica in estadisticas)
            {
                chart.Series["Cantidad"].Points.AddXY(estadistica.Periodo, estadistica.Cantidad);
            }
        }

        
        private List<Estadistica> ObtenerEstadisticasVentasDiarias(DateTime fecha)
        {
            List<Estadistica> estadisticas = new List<Estadistica>
            {
                new Estadistica { Periodo = "Día 1", Cantidad = 50 },
                new Estadistica { Periodo = "Día 2", Cantidad = 75 },
                new Estadistica { Periodo = "Día 3", Cantidad = 100 }
            };

            return estadisticas;
        }

        private List<Estadistica> ObtenerEstadisticasProduccionDiarias(DateTime fecha)
        {
            List<Estadistica> estadisticas = new List<Estadistica>
            {
                new Estadistica { Periodo = "Día 1", Cantidad = 200 },
                new Estadistica { Periodo = "Día 2", Cantidad = 300 },
                new Estadistica { Periodo = "Día 3", Cantidad = 250 }
            };

            return estadisticas;
        }

        private List<Estadistica> ObtenerEstadisticasGastosDiarios(DateTime fecha)
        {
            List<Estadistica> estadisticas = new List<Estadistica>
            {
                new Estadistica { Periodo = "Día 1", Cantidad = 100 },
                new Estadistica { Periodo = "Día 2", Cantidad = 150 },
                new Estadistica { Periodo = "Día 3", Cantidad = 200 }
            };

            return estadisticas;
        }

        private List<Estadistica> ObtenerEstadisticasVentasSemanles(DateTime fecha)
        {
            List<Estadistica> estadisticas = new List<Estadistica>
            {
                new Estadistica { Periodo = "Semana 1", Cantidad = 300 },
                new Estadistica { Periodo = "Semana 2", Cantidad = 400 },
                new Estadistica { Periodo = "Semana 3", Cantidad = 350 }
            };

            return estadisticas;
        }

        private List<Estadistica> ObtenerEstadisticasProduccionSemanal(DateTime fecha)
        {
            List<Estadistica> estadisticas = new List<Estadistica>
            {
                new Estadistica { Periodo = "Semana 1", Cantidad = 800 },
                new Estadistica { Periodo = "Semana 2", Cantidad = 900 },
                new Estadistica { Periodo = "Semana 3", Cantidad = 750 }
            };

            return estadisticas;
        }

        private List<Estadistica> ObtenerEstadisticasGastosSemanal(DateTime fecha)
        {
            List<Estadistica> estadisticas = new List<Estadistica>
            {
                new Estadistica { Periodo = "Semana 1", Cantidad = 400 },
                new Estadistica { Periodo = "Semana 2", Cantidad = 500 },
                new Estadistica { Periodo = "Semana 3", Cantidad = 450 }
            };

            return estadisticas;
        }

        private List<Estadistica> ObtenerEstadisticasVentasMensuales(DateTime fecha)
        {
            List<Estadistica> estadisticas = new List<Estadistica>
            {
                new Estadistica { Periodo = "Enero", Cantidad = 1200 },
                new Estadistica { Periodo = "Febrero", Cantidad = 1500 },
                new Estadistica { Periodo = "Marzo", Cantidad = 1800 }
            };

            return estadisticas;
        }

        private List<Estadistica> ObtenerEstadisticasProduccionMensual(DateTime fecha)
        {
            List<Estadistica> estadisticas = new List<Estadistica>
            {
                new Estadistica { Periodo = "Enero", Cantidad = 2800 },
                new Estadistica { Periodo = "Febrero", Cantidad = 3200 },
                new Estadistica { Periodo = "Marzo", Cantidad = 2900 }
            };

            return estadisticas;
        }

        private List<Estadistica> ObtenerEstadisticasGastosMensuales(DateTime fecha)
        {
            List<Estadistica> estadisticas = new List<Estadistica>
            {
                new Estadistica { Periodo = "Enero", Cantidad = 1500 },
                new Estadistica { Periodo = "Febrero", Cantidad = 1800 },
                new Estadistica { Periodo = "Marzo", Cantidad = 2000 }
            };

            return estadisticas;
        }

        private class Estadistica
        {
            public string Periodo { get; set; }
            public int Cantidad { get; set; }
        }

        private void registroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegistro nuevo = new FrmRegistro();
            nuevo.Show();
        }

        private void listaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLista listin = new FrmLista();
            listin.Show();
        }

        private void fabrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPedidos frmPedidos = new FrmPedidos();
            frmPedidos.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmpedidoCliente frmCliente = new FrmpedidoCliente();
            frmCliente.Show();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmListaPedidos lista = new FrmListaPedidos();
            lista.Show();
        }
    }
}
