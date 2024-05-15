
namespace Grafico_a_Partir_de_CSV_By_orlando_Dias
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnGerarGrafico = new System.Windows.Forms.Button();
            this.LblAutor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // Grafico
            // 
            chartArea3.Name = "ChartArea1";
            this.Grafico.ChartAreas.Add(chartArea3);
            this.Grafico.Dock = System.Windows.Forms.DockStyle.Top;
            legend3.Name = "Legend1";
            this.Grafico.Legends.Add(legend3);
            this.Grafico.Location = new System.Drawing.Point(0, 0);
            this.Grafico.Name = "Grafico";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.Grafico.Series.Add(series3);
            this.Grafico.Size = new System.Drawing.Size(995, 522);
            this.Grafico.TabIndex = 0;
            this.Grafico.Text = "chart1";
            // 
            // BtnGerarGrafico
            // 
            this.BtnGerarGrafico.Location = new System.Drawing.Point(313, 545);
            this.BtnGerarGrafico.Name = "BtnGerarGrafico";
            this.BtnGerarGrafico.Size = new System.Drawing.Size(392, 45);
            this.BtnGerarGrafico.TabIndex = 1;
            this.BtnGerarGrafico.Text = "Importar Arquivo .CSV e Gerar Gráfico";
            this.BtnGerarGrafico.UseVisualStyleBackColor = true;
            this.BtnGerarGrafico.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblAutor
            // 
            this.LblAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAutor.AutoSize = true;
            this.LblAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAutor.ForeColor = System.Drawing.Color.Yellow;
            this.LblAutor.Location = new System.Drawing.Point(731, 593);
            this.LblAutor.Name = "LblAutor";
            this.LblAutor.Size = new System.Drawing.Size(293, 15);
            this.LblAutor.TabIndex = 2;
            this.LblAutor.Text = "Orlando Dias (orlandoforschool@gmail.com)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 617);
            this.Controls.Add(this.LblAutor);
            this.Controls.Add(this.BtnGerarGrafico);
            this.Controls.Add(this.Grafico);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Grafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Grafico;
        private System.Windows.Forms.Button BtnGerarGrafico;
        private System.Windows.Forms.Label LblAutor;
    }
}

