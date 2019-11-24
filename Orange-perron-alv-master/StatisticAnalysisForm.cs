using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Orange_perron_chido.Clases;
using Orange_perron_chido.DTO;

namespace Orange_perron_chido
{
    public partial class StatisticAnalysisForm : Form
    {
        List<string> elementsToAnalyse;
        List<string> valores;
        List<string> atributos;
        Form1 anterior;
        int columnIndex;
        string columnName;
        BoxPlotElements boxplot;
        public StatisticAnalysisForm(List<string> data, string columnName, List<string> valores, List<string> atributos, int columnIndex, Form1 anterior)
        {
            this.anterior = anterior;
            this.columnIndex = columnIndex;
            this.valores = valores;
            this.atributos = atributos;
            elementsToAnalyse = data;
            this.columnName = columnName;
            boxplot = new BoxPlotElements();
            InitializeComponent();
            dataName.Text = columnName;
            if (isNumber().Item1)
            {
                Mode.Text = "Moda";
                Median.Text = "Mediana";
                Average.Text = "Promedio";
                StandarDesviation.Text = "Desviación Estandar";
                Frecuencias.Visible = false;
                boxPlot.Visible = true;
                makeNumericalAnalyse(isNumber().Item2, columnName);
            }
            else
            {
                Mode.Text = "";
                ValueMode.Text = "";
                Median.Text = "";
                ValueMedian.Text = "";
                Average.Text = "";
                ValueAverage.Text = "";
                StandarDesviation.Text = "";
                ValueStandarDesviation.Text = "";
                boxPlot.Visible = false;
                Frecuencias.Visible = true;
                makeCategoricalAnalyse(data);
            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool elementIsNumeric(List<string> elements)
        {
            double number;
            foreach(var element in elements)
            {
                if(double.TryParse(element, out number))
                {
                    return true;
                }
            }
            return false;
        }

        private List<double> getNumbersList(List<string> elements)
        {
            List<double> numbers = new List<double>();
            double number;
            foreach(var element in elements)
            {
                if (!element.Equals(""))
                {
                    double.TryParse(element, out number);
                    numbers.Add(number);
                }
                
            }
            return numbers;
        }

        private void checarValoresFaltantes()
        {
            double mediana;
            double moda;
            string titulo = "Corrección de valor";
            for(int i = 0; i < elementsToAnalyse.Count; i++)
            {
                if (elementsToAnalyse.ElementAt(i).Equals(""))
                {
                    if (elementIsNumeric(elementsToAnalyse))
                    {
                        Stadistic.getModeAndMedian(getNumbersList(elementsToAnalyse), out moda, out mediana);
                        int value = Prompt.ShowDialog(moda.ToString(), mediana.ToString(), titulo);
                        switch (value)
                        {
                            case 1:
                                elementsToAnalyse[i] = moda.ToString();
                                break;
                            case 2:
                                elementsToAnalyse[i] = mediana.ToString();
                                break;
                        }
                    }
                    else
                    {
                        var mode = Stadistic.getCategoricalMode(elementsToAnalyse);
                        elementsToAnalyse[i] = mode;
                    }
                }
            }
        }

        private void makeCategoricalAnalyse(List<string> data)
        {
            var valueAndQuantity = (from element in data
                                   group element by element into elements
                                   select new ValueAndQuantityDTO
                                   {
                                       Value = elements.Key,
                                       quantity = elements.Count()
                                   }).ToList();
            cargarColumnas(valueAndQuantity);
            cargarInformacion(valueAndQuantity);
            Frecuencias.BorderStyle = BorderStyle.None;
            Frecuencias.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            Frecuencias.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Frecuencias.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            Frecuencias.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            Frecuencias.BackgroundColor = Color.White;

            Frecuencias.EnableHeadersVisualStyles = false;
            Frecuencias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Frecuencias.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            Frecuencias.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Frecuencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void cargarColumnas(List<ValueAndQuantityDTO> data)
        {
            int columnas = 0;
            Frecuencias.ColumnCount = data.Count;
            foreach(var elemento in data)
            {
                Frecuencias.Columns[columnas++].Name = elemento.Value;
            }
        }

        private void cargarInformacion(List<ValueAndQuantityDTO> data)
        {
            ArrayList row = new ArrayList();
            foreach(var elemento in data)
            {
                row.Add(elemento.quantity);
            }
            Frecuencias.Rows.Add(row.ToArray());
        }
        private double[] makeNumericalAnalyse(List<double> elements, string columnName)
        {
            double mode;
            double median;
            double average = Stadistic.getAverage(elements);
            Object x = 0;
            int i = 0;
            double[] valores = new double[6];
            Stadistic.getModeAndMedian(elements, out mode, out median);
            double standarDesviation = getStandarDesviation(elements, average);
            ValueMedian.Text = median.ToString();
            ValueMode.Text = mode.ToString();
            ValueAverage.Text = average.ToString();
            ValueStandarDesviation.Text = standarDesviation.ToString();
            elements.Sort();
            var quartile1 = Stadistic.getFirstQuartile(elements);
            var quartile3 = Stadistic.getLastQuartile(elements);
            var interquartileRange = Stadistic.getInterquartileRange(quartile3, quartile1);
            valores[0] = Stadistic.getBoxPlotMin(quartile1, interquartileRange); //Minimo
            valores[1] = Stadistic.getBoxPlotMax(quartile3, interquartileRange); //Maximo
            valores[2] = quartile1; //Quartile 1
            valores[3] = quartile3; // Quartile 3
            valores[4] = average; // media
            valores[5] = median; //mediana
            boxplot.avg = valores[4];
            boxplot.max = valores[1];
            boxplot.med = valores[5];
            boxplot.min = valores[0];
            boxplot.q1 = valores[2];
            boxplot.q3 = valores[3];
            Series s = boxPlot.Series.Add(columnName);
            s.ChartType = SeriesChartType.BoxPlot;
            s.Points.Add(valores);
            DrawAnnotation("Mínimo - ", 0, columnName, valores);
            DrawAnnotation("Máximo - ", 1, columnName, valores);
            DrawAnnotation("Cuartil 1 - ", 2, columnName, valores);
            DrawAnnotation("Cuartil 2 - ", 3, columnName, valores);
            return valores;
        }

        private void DrawAnnotation(string text, int index, string columnName, double[] valores)
        {
            TextAnnotation textAnnotation = new TextAnnotation();
            textAnnotation.Text = text + valores[index].ToString();
            textAnnotation.AnchorDataPoint = boxPlot.Series[columnName].Points[0];
            textAnnotation.AnchorY = valores[index];
            boxPlot.Annotations.Add(textAnnotation);
        }

        private int getStandarDesviation(List<double> numbers, double average)
        {
            double count = 0;
            foreach(var number in numbers)
            {
                count += (number - average) * (number - average);
            }
            Console.WriteLine(count);
            count /= numbers.Count - 1;
            return (int)Math.Sqrt(count);
        }

        private (bool, List<double>) isNumber()
        {
            bool isNumeric;
            List<double> numeros = new List<double>();
            double n;
            foreach (var element in elementsToAnalyse)
            {
                if(element != "")
                {
                    isNumeric = double.TryParse(element, out n);
                    numeros.Add(n);
                    if (!isNumeric)
                    {
                        return (false, null);
                    }
                }
            }
            return (true, numeros);
        }

        private void back_Click(object sender, EventArgs e)
        {
            anterior.Show();
            this.Close();
        }

        private void correctOutliers(double[] valores, List<double> numbers)
        {
            double diferencia = (valores[1] - valores[3]) - (valores[2] - valores[0]);
            double newValue;
            if(diferencia == 0)
            {
                newValue = valores[4];
            }
            else
            {
                newValue = valores[5];
            }
            for(int i = 0; i < numbers.Count; i++)
            {
                if(numbers.ElementAt(i) > valores[1] || numbers.ElementAt(i) < valores[0])
                {
                    numbers[i] = newValue;
                }
            }
        }

        private void limpieza_Click(object sender, EventArgs e)
        {
            DataCleaning dc = new DataCleaning(valores, atributos, elementsToAnalyse, columnIndex, boxplot, this);
            this.Hide();
            dc.Show();
        }
    }
}
