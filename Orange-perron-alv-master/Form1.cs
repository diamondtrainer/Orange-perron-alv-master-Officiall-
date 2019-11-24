using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using Orange_perron_chido.Clases;

namespace Orange_perron_chido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        OpenFileDialog ofl = new OpenFileDialog();
        List<string> atributos = new List<string>();
        List<string> valores = new List<string>();
        List<string> tipo = new List<string>();
        List<string> dominio = new List<string>();
        List<int> X = new List<int>();
        List<int> Y = new List<int>();
        List<int> MX = new List<int>();
        List<int> MY = new List<int>();
        List<int> LocalizacionMissing = new List<int>();
        string ValorFaltante;
        string nombreArchivo;
        string Descripcion;
        int numerodeatributos;
        bool ArchivoData = false;
        string ruta;
        bool AddInstancia = false;

        private void Colorear()
        {
            int contador = 0;
            while (contador < X.Count())
            {
                tablaPrincipal.Rows[Y[contador]].Cells[X[contador]].Style.BackColor = Color.Red;
                contador++;
            }
        }

        private void MColorear()
        {
            int contador = 0;
            while (contador < MX.Count())
            {
                tablaPrincipal.Rows[MY[contador]].Cells[MX[contador]].Style.BackColor = Color.Yellow;
                contador++;
            }
        }
        private void accionadorArchivo_Click(object sender, EventArgs e)
        {
            int cantidadFilas;
            int cantidadColumnas;
            int valoresFaltantes;
            int valoresNoFaltantes;
            float propocionValoresFaltantes;
            string shortFileName;
            if (tablaPrincipal.Rows.Count != 0)
            {
                tablaPrincipal.Rows.Clear();
                tablaPrincipal.Columns.Clear();
                columnToAutomatic.Items.Clear();
                atributos.RemoveRange(0, atributos.Count);
                valores.RemoveRange(0, valores.Count);
                AlgoritmNames.Items.Clear();
            }
            if (ofl.ShowDialog() == DialogResult.OK)
            {
                nombreArchivo = ofl.FileName;
                ruta = nombreArchivo;
                shortFileName = ofl.SafeFileName.Split('.').FirstOrDefault();
                string data = ofl.FileName.ToString();
                string[] formato = data.Split('.'); ;

                if (formato[1] == "data")
                {
                    ArchivoData = true;
                    string[] lineasDeData = File.ReadAllLines(ofl.FileName);
                    int X = 0;
                    bool datos = false;
                    foreach (var lineasDelData in lineasDeData)
                    {
                        if (datos)
                        {
                            string[] informacion = lineasDeData[X].Split(',');
                            int contador = 0;
                            while (contador < numerodeatributos)
                            {
                                if (informacion[contador] == "" || informacion[contador] == " " || informacion[contador] == null)
                                {
                                    informacion[contador] = ValorFaltante;
                                }
                                valores.Add(informacion[contador]);
                                //MessageBox.Show(informacion[contador]);
                                contador++;
                                //MessageBox.Show(contador.ToString());

                            }

                        }
                        else
                        {
                            if (lineasDeData[X].Contains("%"))
                            {
                                string[] none = lineasDeData[X].Split('%');
                                Descripcion = none[1];
                            }
                            else if (lineasDeData[X].Contains("@Relation"))
                            {
                                string[] none = lineasDeData[X].Split(' ');
                                nombreArchivo = none[1];
                            }
                            else if (lineasDeData[X].Contains("@attribute"))
                            {
                                string[] atributes = lineasDeData[X].Split(' ');

                                atributos.Add(atributes[1]);
                                tipo.Add(atributes[2]);
                                dominio.Add(atributes[3]);
                                numerodeatributos++;
                            }
                            else if (lineasDeData[X].Contains("@missingValue"))
                            {
                                string[] miss = lineasDeData[X].Split(' ');

                                ValorFaltante = miss[1];
                            }
                            else if (lineasDeData[X].Contains("@data"))
                            {
                                datos = true;
                            }
                        }
                        X++;
                    }
                }
                else
                {
                    Console.WriteLine(ofl.FileName);
                    int cantidad = 0;

                    string[] lines = File.ReadAllLines(ofl.FileName);
                    foreach (var linea in lines)
                    {
                        if (cantidad == 0)
                        {
                            atributos.AddRange(linea.Split(','));
                        }
                        else
                        {
                            valores.AddRange(linea.Split(','));
                        }
                        cantidad++;
                    }
                }

                cantidadFilas = valores.Count / atributos.Count;
                cantidadColumnas = atributos.Count;
                valoresFaltantes = obtenerCantidadValoresFaltantes();
                valoresNoFaltantes = obtenerCantidadValoresNoFaltantes();
                propocionValoresFaltantes = (valoresFaltantes * 100) / valoresNoFaltantes;
                rowsQuantity.Text = cantidadFilas.ToString();
                ColumnQuantity.Text = cantidadColumnas.ToString();
                missingValues.Text = valoresFaltantes.ToString();
                proportion.Text = propocionValoresFaltantes.ToString() + "%";
                DataSetName.Text = shortFileName;
                cargarColumnas();
                cargarInformacion();
                MColorear();
                if (ArchivoData)
                {
                    Colorear();
                    
                }

                //tablaPrincipal.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            }
        }

        private int obtenerCantidadValoresFaltantes()
        {
            int valoresFaltantes = 0;
            foreach (var elemento in valores)
            {
                if (elemento.Equals("") || elemento.Equals(null) || elemento.Equals("?"))
                {
                    valoresFaltantes++;
                }
            }
            return valoresFaltantes;
        }

        private int obtenerCantidadValoresNoFaltantes()
        {
            int valoresNoFaltantes = 0;
            foreach (var elemento in valores)
            {
                if (!elemento.Equals("") || elemento.Equals(null) || elemento.Equals("?"))
                {
                    valoresNoFaltantes++;
                }
            }
            return valoresNoFaltantes;
        }

        private void cargarColumnas()
        {
            int columnas = 0;
            tablaPrincipal.ColumnCount = atributos.Count + 1;
            tablaPrincipal.Columns[columnas++].Name = "ID";
            foreach (var atributo in atributos)
            {
                CBAtr.Items.Add(atributo);
                CBAtr2.Items.Add(atributo);
                tablaPrincipal.Columns[columnas++].Name = atributo;
                columnToAutomatic.Items.Add(atributo);
            }
            AlgoritmNames.Items.Add("Zero-R");
            AlgoritmNames.Items.Add("One-R");
            AlgoritmNames.Items.Add("Naive-Bayes");
            AlgoritmNames.Items.Add("K-means");
            AlgoritmNames.Items.Add("K-NN");
            metodology.Items.Add("K-Fold");
            metodology.Items.Add("Hold-Out");
        }

        private bool isNumericColumn(int index)
        {
            int dummy;
            for (int i = 0; i < tablaPrincipal.RowCount - 1; i++)
            {
                if (int.TryParse(tablaPrincipal.Rows[i].Cells[index].Value.ToString(), out dummy))
                {
                    return true;
                }
            }
            return false;
        }

        public List<double> getColumnList(int index)
        {
            double value;
            List<double> valores = new List<double>();
            for (int i = 0; i < tablaPrincipal.RowCount - 1; i++)
            {
                if (tablaPrincipal.Rows[i].Cells[index].Value.ToString() != "")
                {
                    double.TryParse(tablaPrincipal.Rows[i].Cells[index].Value.ToString(), out value);
                    valores.Add(value);
                }

            }
            return valores;
        }

        public List<string> getCategoricalColumnList(int index)
        {
            string element;
            List<string> valores = new List<string>();
            for (int i = 0; i < tablaPrincipal.RowCount - 1; i++)
            {
                element = tablaPrincipal.Rows[i].Cells[index].Value.ToString();
                if (element != "")
                {
                    valores.Add(element);
                }
            }
            return valores;
        }
        bool MissingMaching(string Domine, string dato)
        {
            if (Domine == "[0-9]+")
            {
                int numero = 0;
                if (int.TryParse(dato, out numero))
                {

                    return true;
                }
                else
                {
                    MessageBox.Show(dato + " no pertenece al dominio");
                    return false;
                }
            }

            else if (Domine.Contains('['))
            {
                Char[] v = { '[', ']' };
                string temp = Domine;
                Domine = temp.Trim(v);
                string[] domonios = Domine.Split('|');
                foreach (var x in domonios)
                {

                    if (x == dato)
                    {
                        return true;
                    }
                }
            }
            else
            {
                return true;
            }

            return false;
        }
        private void cargarInformacion()
        {
            int id = 1;
            int actual = 0;
            bool completo = true;
            int valor = 0;
            int y = 0;
            do
            {
                ArrayList row = new ArrayList();
                if (actual == (valores.Count / atributos.Count))
                {
                    completo = false;
                    break;
                }
                row.Add(id++);
                int contador = 0;
                while (contador < atributos.Count)
                {
                    row.Add(valores[valor]);
                    if (valores[valor] == "?" || valores[valor]=="")
                    {
                        MX.Add(contador + 1);
                        MY.Add(y);
                    }
                    else if (ArchivoData)
                    {
                        if (MissingMaching(dominio[contador], valores[valor]))
                        {

                        }
                    }
                    else
                    {
                        X.Add(contador + 1);
                        Y.Add(y);
                    }

                    valor++;
                    contador++;
                }
                tablaPrincipal.Rows.Add(row.ToArray());
                actual++;
                y++;
            } while (completo);
            ///checarValoresFaltantes();
            tablaPrincipal.BorderStyle = BorderStyle.None;
            tablaPrincipal.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            tablaPrincipal.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tablaPrincipal.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            tablaPrincipal.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            tablaPrincipal.BackgroundColor = Color.White;

            tablaPrincipal.EnableHeadersVisualStyles = false;
            tablaPrincipal.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tablaPrincipal.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            tablaPrincipal.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tablaPrincipal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void tablaPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            List<string> columnElements = new List<string>();
            foreach (DataGridViewRow row in tablaPrincipal.Rows)
            {
                if (row.Cells[columnIndex].Value != null)
                {
                    columnElements.Add(row.Cells[columnIndex].Value.ToString());
                }
            }

            StatisticAnalysisForm analysis = new StatisticAnalysisForm(columnElements, tablaPrincipal.Columns[e.ColumnIndex].Name, valores, atributos, columnIndex, this);
            this.Hide();
            analysis.Show();
        }

        private void getTableData(out List<Object[]> data, out List<string> columnNames)
        {
            data = tablaPrincipal.Rows.OfType<DataGridViewRow>().Select(
                    row => row.Cells.OfType<DataGridViewCell>().Select(c => c.Value).Skip(1).ToArray()).ToList();
            columnNames = new List<string>();
            for (var i = 0; i < tablaPrincipal.ColumnCount; i++)
            {
                if (!tablaPrincipal.Columns[i].HeaderText.Equals("ID"))
                {
                    columnNames.Add(tablaPrincipal.Columns[i].HeaderText);
                }
            }
        }

        private void writeToFile(string path, List<Object[]> data, List<string> columnNames)
        {
            int contador = 0;
            int contadorData = 0;
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            File.Create(path).Dispose();
            using (StreamWriter w = File.AppendText(path))
            {
                Console.WriteLine("header");
                foreach (var column in columnNames)
                {
                    Console.WriteLine(column);
                    w.Write(column);
                    if (++contador != columnNames.Count)
                    {
                        w.Write(",");
                    }
                    else
                    {
                        w.WriteLine("");
                    }
                }
                contador = 0;
                Console.WriteLine("elementos");
                data.RemoveAt(data.Count - 1);
                foreach (var el in data)
                {
                    foreach (var ele in el)
                    {
                        w.Write(ele);
                        if (++contadorData != el.Length)
                        {
                            w.Write(",");
                        }
                        else if (++contador != data.Count)
                        {
                            w.WriteLine("");
                        }
                    }
                    contadorData = 0;
                }
                w.Close();
            }
        }
        private void SaveData()
        {
            StreamWriter sw = new StreamWriter(ruta);
            sw.Write("%" + Descripcion + Environment.NewLine);
            sw.Write("@Relation " + nombreArchivo + Environment.NewLine);
            int cont = 0;
            while (cont < atributos.Count)
            {
                sw.Write("@attribute " + atributos[cont] + " " + tipo[cont] + " " + dominio[cont] + Environment.NewLine);
                cont++;
            }
            sw.Write("@missingValue " + ValorFaltante + Environment.NewLine);
            sw.Write("@data" + Environment.NewLine);
            cont = 0;
            int cont1 = 0;
            string sentencia;
            while (cont < valores.Count)
            {
                sentencia = "";
                while (cont1 < atributos.Count)
                {
                    sentencia = sentencia + valores[cont];
                    if (cont1 + 1 < atributos.Count)
                    {
                        sentencia = sentencia + ",";
                    }
                    cont1++;
                    cont++;
                }
                sw.Write(sentencia + Environment.NewLine);
                cont1 = 0;
            }

            sw.Close();
        }
        private void SaveChanges_Click(object sender, EventArgs e)
        {
            if (ArchivoData)
            {
                SaveData();
            }
            else
            {
                string path = nombreArchivo;
                List<Object[]> data = new List<Object[]>();
                List<string> columnNames = new List<string>();
                getTableData(out data, out columnNames);
                writeToFile(path, data, columnNames);
            }
        }

        private void SaveNewFile_Click(object sender, EventArgs e)
        {
            string path = string.Format(@"C:\Users\pepti\source\repos\Orange-perron-alv\Files\{0}.csv", Guid.NewGuid());
            List<Object[]> data = new List<Object[]>();
            List<string> columnNames = new List<string>();
            getTableData(out data, out columnNames);
            writeToFile(path, data, columnNames);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteRow_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in tablaPrincipal.SelectedRows)
            {
                tablaPrincipal.Rows.RemoveAt(row.Index);
            }
        }

        private void StatisticAnalysis_Click(object sender, EventArgs e)
        {
            //StatisticAnalysisForm statisticAnalysisForm = new StatisticAnalysisForm();
            this.Hide();
            //statisticAnalysisForm.Show();
        }

        private List<List<string>> getColumnsValues()
        {
            List<List<string>> columnas = new List<List<string>>();
            for (int i = 0; i < tablaPrincipal.ColumnCount; i++)
            {
                List<string> column = new List<string>();
                column.Add(tablaPrincipal.Columns[i].Name);
                foreach (DataGridViewRow row in tablaPrincipal.Rows)
                {
                    if (row.Cells[i].Value != null)
                    {
                        column.Add(row.Cells[i].Value.ToString());
                    }
                }
                columnas.Add(column);
            }
            return columnas;
        }

        private void DevelopAnalyse_Click(object sender, EventArgs e)
        {
            var columnName = columnToAutomatic.Text;
            var algoritm = AlgoritmNames.Text;
            var index = getColumnIndex(columnName);
            List<string> columnElements = new List<string>();
            foreach (DataGridViewRow row in tablaPrincipal.Rows)
            {
                if (row.Cells[index].Value != null)
                {
                    columnElements.Add(row.Cells[index].Value.ToString());
                }
            }

            switch (algoritm)
            {
                case "Zero-R":
                    AutomaticKnowledge automaticForm = new AutomaticKnowledge(columnElements, algoritm, this);
                    this.Hide();
                    automaticForm.Show();
                    break;
                case "One-R":
                    OneRAK oner = new OneRAK(getColumnsValues(), index, this);
                    this.Hide();
                    oner.K = Int32.Parse(txtK.Text);
                    oner.Show();
                    break;
            }


        }

        private int getColumnIndex(string columnName)
        {
            return tablaPrincipal.Columns[columnName].Index;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CBAtr.Visible = true;
            BTNEli.Visible = true;
        }
        public void AddNewAttribute(string name, string Nuevodominio, string Nuevotipo, string vDefault)
        {
            List<string> Natributos = new List<string>();
            List<string> Nvalores = new List<string>();
            List<string> Ntipo = new List<string>();
            List<string> Ndominio = new List<string>();
            int contAt = -1;
            foreach (var valor in atributos)
            {
                Natributos.Add(valor);
                contAt++;
            }
            Natributos.Add(name);
            if (dominio.Count() == 0)
            {
                int contNuevo = 0;
                foreach (var valor in valores)
                {
                    Nvalores.Add(valor);
                    if (contAt == contNuevo)
                    {
                        Nvalores.Add(vDefault);
                        contAt = contAt + Natributos.Count();

                    }
                    contNuevo++;
                }
                tablaPrincipal.Rows.Clear();
            }
            else
            {
                int contNuevo = 0;
                foreach (var valor in valores)
                {
                    Nvalores.Add(valor);
                    if (contAt == contNuevo)
                    {
                        Nvalores.Add(vDefault);
                        contAt = contAt + Natributos.Count() - 1;

                    }
                    contNuevo++;
                }

                foreach (var x in dominio)
                {
                    Ndominio.Add(x);
                }
                Ndominio.Add(Nuevodominio);
                foreach (var kind in tipo)
                {
                    Ntipo.Add(kind);
                }
                Ntipo.Add(Nuevotipo);
            }
            tablaPrincipal.Rows.Clear();
            valores = Nvalores;
            dominio = Ndominio;
            atributos = Natributos;
            tipo = Ntipo;
            int cantidadFilas;
            int cantidadColumnas;
            cantidadFilas = valores.Count / atributos.Count;
            cantidadColumnas = atributos.Count;
            rowsQuantity.Text = cantidadFilas.ToString();
            ColumnQuantity.Text = cantidadColumnas.ToString();
            cargarColumnas();
            cargarInformacion();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (AddInstancia)
            {
                int cont = 0;
                while (cont < atributos.Count())
                {
                    valores.Add(txtvDefault.Text);
                    cont++;
                }
                tablaPrincipal.Rows.Clear();
                int cantidadFilas;
                int cantidadColumnas;
                cantidadFilas = valores.Count / atributos.Count;
                cantidadColumnas = atributos.Count;
                rowsQuantity.Text = cantidadFilas.ToString();
                ColumnQuantity.Text = cantidadColumnas.ToString();
                cargarColumnas();
                cargarInformacion();
                MessageBox.Show("Instancia agregada correctamente");
                lblval.Visible = false;
                btnAdd.Visible = false;
                txtvDefault.Visible = false;
            }

            else
            {
                if (TXTDom.Text.Contains('(') && TXTDom.Text.Contains(')'))
                {
                    AddNewAttribute(txtName.Text, TXTDom.Text, CBTipo.Text, txtvDefault.Text);
                    MessageBox.Show("Atributo agregado correctamente");
                    lblnombre.Visible = false;
                    txtName.Visible = false;
                    lbldom.Visible = false;
                    TXTDom.Visible = false;
                    lbltipo.Visible = false;
                    CBTipo.Visible = false;
                    lblval.Visible = false;
                    btnAdd.Visible = false;
                    txtvDefault.Visible = false;
                }
                else
                {
                    MessageBox.Show("Por favor, agrege un dominio valido");
                }
            }
        }

        private void BTNEli_Click(object sender, EventArgs e)
        {
            if (CBAtr.Text == "")
            {
                MessageBox.Show("Por favor, seleccióne un atributo a eliminar");
            }
            else
            {
                List<string> Natributos = new List<string>();
                List<string> Nvalores = new List<string>();
                List<string> Ntipo = new List<string>();
                List<string> Ndominio = new List<string>();

                int contador = 0;
                while (atributos[contador] != CBAtr.Text)
                {
                    contador++;
                }
                int contAt = contador;
                int Universe = 0;
                foreach (var valor in atributos)
                {

                    if (Universe == contador)
                    {

                    }
                    else
                    {
                        Natributos.Add(valor);
                    }
                    Universe++;
                }
                Universe = 0;
                if (dominio.Count() == 0)
                {
                    int contNuevo = 0;
                    foreach (var valor in valores)
                    {

                        if (contador == contNuevo)
                        {
                            contAt = contAt + Natributos.Count();

                        }
                        else
                        {
                            Nvalores.Add(valor);
                        }
                        contNuevo++;
                    }
                    tablaPrincipal.Rows.Clear();
                }
                else
                {
                    int contNuevo = 0;
                    foreach (var valor in valores)
                    {
                        if (contAt == contNuevo)
                        {
                            contAt = contAt + atributos.Count();
                        }
                        else
                        {
                            Nvalores.Add(valor);
                        }
                        contNuevo++;
                    }
                    contNuevo = 0;
                    foreach (var x in dominio)
                    {
                        if (contador == contNuevo)
                        {

                        }
                        else
                        {
                            Ndominio.Add(x);
                        }
                        contNuevo++;
                    }
                    contNuevo = 0;
                    foreach (var kind in tipo)
                    {
                        if (contador == contNuevo)
                        {

                        }
                        else
                        {
                            Ntipo.Add(kind);
                        }
                        contNuevo++;
                    }
                }
                tablaPrincipal.Rows.Clear();
                valores = Nvalores;
                dominio = Ndominio;
                atributos = Natributos;
                tipo = Ntipo;
                int cantidadFilas;
                int cantidadColumnas;
                if (atributos.Count() == 0)
                {
                    cantidadFilas = 0;
                }
                else
                {
                    cantidadFilas = valores.Count / atributos.Count;
                }
                cantidadColumnas = atributos.Count;
                rowsQuantity.Text = cantidadFilas.ToString();
                ColumnQuantity.Text = cantidadColumnas.ToString();
                cargarColumnas();
                cargarInformacion();
                CBAtr.Visible = false;
                BTNEli.Visible = false;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblval.Visible = true;
            btnAdd.Visible = true;
            txtvDefault.Visible = true;
            AddInstancia = true;
        }

        private void btnBi_Click(object sender, EventArgs e)
        {
            Bivariable nuevo = new Bivariable();
            nuevo.atributos = atributos;
            nuevo.valores = valores;
            nuevo.tipo = tipo;
            nuevo.dominio = dominio;
            nuevo.Ventana = this;
            nuevo.Show();
            this.Hide();
            if (!ArchivoData)
            {
                nuevo.csv = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddInstancia = false;
            lblnombre.Visible = true;
            txtName.Visible = true;
            lbldom.Visible = true;
            TXTDom.Visible = true;
            lbltipo.Visible = true;
            CBTipo.Visible = true;
            lblval.Visible = true;
            btnAdd.Visible = true;
            txtvDefault.Visible = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void CBAtr2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Llenar tipo
            int cont = 0, atribute = 0;
            foreach (var x in atributos)
            {
                if (x == CBAtr2.Text)
                {
                    atribute = cont;
                }
                cont++;
            }
            if (ArchivoData)
            {
                
                lblTipe.Text = tipo[atribute];
            }
            else
            {
                lblTipe.Text = "Desconocido";
            }
            //Llenar Porcentaje Faltante
            int c = 0, valorestotales = Int32.Parse(rowsQuantity.Text) * atributos.Count(), ValorFaltante=0;
            while (c<valorestotales)
            {
                if (MX.Contains(c))
                {
                    ValorFaltante++;
                }
                c = c + atributos.Count();

            }
            lblVF.Text =ValorFaltante.ToString();
            double promedio = 0;
            promedio = (ValorFaltante * 100) / valorestotales;
            lblVFP.Text = promedio.ToString() + "%";
            //Llenar Valores Out of Domine
            if (ArchivoData)
            {
                c = 0;
                ValorFaltante = 0;
                while (c < valorestotales)
                {
                    if (X.Contains(c))
                    {
                        ValorFaltante++;
                    }
                    c = c + atributos.Count();

                }
                lblOutDom.Text =ValorFaltante.ToString();
            }
            else
            {
                lblOutDom.Text = "Desconocido";
            }
            

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (AddInstancia)
            {
                int cont = 0;
                while (cont < atributos.Count())
                {
                    valores.Add(txtvDefault.Text);
                    cont++;
                }
                tablaPrincipal.Rows.Clear();
                int cantidadFilas;
                int cantidadColumnas;
                cantidadFilas = valores.Count / atributos.Count;
                cantidadColumnas = atributos.Count;
                rowsQuantity.Text = cantidadFilas.ToString();
                ColumnQuantity.Text = cantidadColumnas.ToString();
                cargarColumnas();
                cargarInformacion();
            }

            else
            {
                if (TXTDom.Text.Contains('(') && TXTDom.Text.Contains(')'))
                {
                    AddNewAttribute(txtName.Text, TXTDom.Text, CBTipo.Text, txtvDefault.Text);
                }
                else
                {
                    MessageBox.Show("Por favor, agrege un dominio valido");
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void BTNEli_Click_1(object sender, EventArgs e)
        {
            if (CBAtr.Text == "")
            {
                MessageBox.Show("Por favor, seleccióne un atributo a eliminar");
            }
            else
            {
                List<string> Natributos = new List<string>();
                List<string> Nvalores = new List<string>();
                List<string> Ntipo = new List<string>();
                List<string> Ndominio = new List<string>();

                int contador = 0;
                while (atributos[contador] != CBAtr.Text)
                {
                    contador++;
                }
                int contAt = contador;
                int Universe = 0;
                foreach (var valor in atributos)
                {

                    if (Universe == contador)
                    {

                    }
                    else
                    {
                        Natributos.Add(valor);
                    }
                    Universe++;
                }
                Universe = 0;
                if (dominio.Count() == 0)
                {
                    int contNuevo = 0;
                    foreach (var valor in valores)
                    {

                        if (contador == contNuevo)
                        {
                            contAt = contAt + Natributos.Count();

                        }
                        else
                        {
                            Nvalores.Add(valor);
                        }
                        contNuevo++;
                    }
                    tablaPrincipal.Rows.Clear();
                }
                else
                {
                    int contNuevo = 0;
                    foreach (var valor in valores)
                    {
                        if (contAt == contNuevo)
                        {
                            contAt = contAt + atributos.Count();
                        }
                        else
                        {
                            Nvalores.Add(valor);
                        }
                        contNuevo++;
                    }
                    contNuevo = 0;
                    foreach (var x in dominio)
                    {
                        if (contador == contNuevo)
                        {

                        }
                        else
                        {
                            Ndominio.Add(x);
                        }
                        contNuevo++;
                    }
                    contNuevo = 0;
                    foreach (var kind in tipo)
                    {
                        if (contador == contNuevo)
                        {

                        }
                        else
                        {
                            Ntipo.Add(kind);
                        }
                        contNuevo++;
                    }
                }
                tablaPrincipal.Rows.Clear();
                valores = Nvalores;
                dominio = Ndominio;
                atributos = Natributos;
                tipo = Ntipo;
                int cantidadFilas;
                int cantidadColumnas;
                if (atributos.Count() == 0)
                {
                    cantidadFilas = 0;
                }
                else
                {
                    cantidadFilas = valores.Count / atributos.Count;
                }
                cantidadColumnas = atributos.Count;
                rowsQuantity.Text = cantidadFilas.ToString();
                ColumnQuantity.Text = cantidadColumnas.ToString();
                cargarColumnas();
                cargarInformacion();
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            int x = 0;
            while(x<atributos.Count())
            {
                if(atributos[x]==CBAtr2.Text)
                {
                    atributos[x] = txtnewnom.Text;
                }
                x++;
            }
            cargarColumnas();
            cargarInformacion();
            CBAtr.Items.Clear();
            CBAtr2.Items.Clear();
            foreach (var y in atributos)
            {
                CBAtr.Items.Add(y);
                CBAtr2.Items.Add(y);
            }
        }

        private void metodology_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(metodology.Text== "K-Fold")
                {
                txtK.Visible = true;
            }
        }
    }
}



public static class Prompt
{
    public static int ShowDialog(string moda, string mediana, string title)
    {
        int ModeOrMedian = 0; //Mode = 1, Median = 2
        Form prompt = new Form();
        prompt.Width = 500;
        prompt.Height = 300;
        prompt.Text = title;
        Label textLAbel = new Label() { Left = 100, Top = 20, Text = $"Moda: { moda}" };
        Label TextLabel2 = new Label() { Left = 200, Top = 20, Text = $"Mediana: { mediana}" };
        Button Mode = new Button() { Text = "Moda", Left = 100, Width = 100, Top = 70 };
        Button Median = new Button() { Text = "Mediana", Left = 200, Width = 100, Top = 70 };
        Mode.Click += (sender, e) =>
        {
            ModeOrMedian = 1;
            prompt.Close();
        };
        Median.Click += (sender, e) =>
        {
            ModeOrMedian = 2;
            prompt.Close();
        };
        prompt.Controls.Add(Mode);
        prompt.Controls.Add(Median);
        prompt.Controls.Add(textLAbel);
        prompt.Controls.Add(TextLabel2);
        prompt.ShowDialog();
        return ModeOrMedian;
    }
}