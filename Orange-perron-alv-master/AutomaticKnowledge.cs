using Orange_perron_chido.DTO;
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

namespace Orange_perron_chido
{
    public partial class AutomaticKnowledge : Form
    {

        List<string> elements;
        Form1 anterior;
        public AutomaticKnowledge(List<string> elements, string algoritmName, Form1 anterior)
        {
            this.elements = elements;
            this.anterior = anterior;
            InitializeComponent();
            getZeroR();
        }

        private void getZeroR()
        {
            var elementsQuantity = elements.GroupBy(r => r).Select(grp => new ZeroR() { element = grp.Key, quantity = grp.Count() }).ToList();
            var quantity = elements.Count();
            label2.Text = quantity.ToString();
            cargarColumnas(elementsQuantity);
            cargarInformacion(elementsQuantity);
            zeroRElements.BorderStyle = BorderStyle.None;
            zeroRElements.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            zeroRElements.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            zeroRElements.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            zeroRElements.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            zeroRElements.BackgroundColor = Color.White;

            zeroRElements.EnableHeadersVisualStyles = false;
            zeroRElements.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            zeroRElements.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            zeroRElements.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            zeroRElements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarColumnas(List<ZeroR> elements)
        {
            int columnas = 0;
            zeroRElements.ColumnCount = elements.Count + 1;
            foreach(var atributo in elements)
            {
                zeroRElements.Columns[columnas++].Name = atributo.element;
            }
        }

        private void cargarInformacion(List<ZeroR> elements)
        {
            int actual = 0;
            bool completo = true;
            do
            {
                ArrayList row = new ArrayList();
                if (actual == elements.Count)
                {
                    completo = false;
                    break;
                }
                for(int i = 0; i < elements.Count; i++)
                {
                    row.Add(elements.ElementAt(actual++).quantity);
                }
                zeroRElements.Rows.Add(row.ToArray());
            } while (completo);
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            anterior.Show();
            this.Close();
        }
    }
}
