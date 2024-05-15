using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Phidget22;

// AUTOR: Orlando Dias
// EMAIL: orlandoforschool@gmail.com

namespace Grafico_a_Partir_de_CSV_By_orlando_Dias
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            // personalizar form
            this.Text = "Importar Arquivo .CSV do simulador micro:bit e grar gráfico";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.BackColor = Color.FromArgb(148, 147, 152);
            this.MinimizeBox = false;
            this.MaximizeBox = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // criar openFileDialog e personalizar
            var DlgoCSV = new OpenFileDialog
            {
                Filter = "Arquivos CSV microbit (*.csv)|*.csv"
            };

            // inicializar contador temperaturas
            var ContadorTemperaturas = 1;

            Random Rnd = new Random();

            if (DlgoCSV.ShowDialog() == DialogResult.OK)
            {
                // limpar gráfico
                Grafico.Series.Clear();
                Grafico.Titles.Clear();

                // Ler arquivo .CSV
                using (var Leitura = new StreamReader(DlgoCSV.FileName))
                {

                    // ler primeira linha - ignora-la
                    if (!Leitura.EndOfStream)
                    {
                        Leitura.ReadLine();
                        Leitura.ReadLine();
                    }

                    while (!Leitura.EndOfStream)
                    {
                        // ler linha
                        var Linha = Leitura.ReadLine();

                        // obter valores na linha
                        var Valores = Linha.Split('	');

                        var duracao = float.Parse(Valores[0]);
                        var valor = long.Parse(Valores[1]);


                        // criar uma nova serie no grafico

                        Color Cor = Color.FromArgb(Rnd.Next(256), Rnd.Next(256), Rnd.Next(256));

                        var Serie = new System.Windows.Forms.DataVisualization.Charting.Series
                        {

                            Color = Cor,
                            Label = valor + "°C" + " (tempo: " + duracao.ToString("0.00") + ")",
                            LabelForeColor = Color.Black,
                            BorderColor = Cor,
                            ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar,
                            IsXValueIndexed = false,
                            XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32,
                            YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32,
                            IsVisibleInLegend = false
                           

                    };

                        
                        Serie.Points.AddXY(duracao,valor);
                        Grafico.Series.Add(Serie);
                        
                        // incrementar numero temperaturas lidas
                        ContadorTemperaturas++;
                    }
                }

                Grafico.Titles.Add(ContadorTemperaturas + " Temperatura Registadas");

            }
        }
    }
}
