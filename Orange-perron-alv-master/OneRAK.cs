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
    public partial class OneRAK : Form
    {
        List<List<string>> columnas;
        public List<string> atributos;
        List<string> objective;
        List<string> columnNames;
        List<Rules> reglas;
        Form1 anterior;
        Dictionary<string, List<ErrorPorList>> columnasFinales;
        int index;
        int i = 0;
        int contador ;
        int columnQuantity;
        string objectiveName;
        bool auxiliar;
        public int K = 2;

        public OneRAK(List<List<string>> columnas, int index, Form1 anterior)
        {

            objective = columnas.ElementAt(index);
            columnNames = new List<string>();
            reglas = new List<Rules>();
            bool auxiliar;
            this.anterior = anterior;
            Rules reglaFinal = new Rules();
            columnasFinales = new Dictionary<string, List<ErrorPorList>>(); //nombre de la columna y el conjunto de reglas
            foreach (var columna in columnas)
            {
                columnNames.Add(columna.ElementAt(0));
                columna.RemoveAt(0);
            }
            columnas.RemoveAt(index);
            columnNames.RemoveAt(index);
            columnas.RemoveAt(0);
            columnNames.RemoveAt(0);
            objectiveName = objective.FirstOrDefault().ToString();
            this.columnas = columnas;
            this.index = index;
            columnQuantity = this.columnas.Count;
            InitializeComponent();
            reglaFinal = oneR();
            mostrarReglas(reglaFinal);

            //Aplicando Folk
            
            int cont = 0, TotalDeDivido, pidote = 0;
            List<string> columnita = new List<string>();
            columnita = columnas[0];
            TotalDeDivido = (columnita.Count() - 1) / K;
            int ignorar = TotalDeDivido;
            pidote = columnita.Count() - 1;
            Rules[] modelos;
            int[] FinDelSubconjuto;
            FinDelSubconjuto = new int[K];
            modelos = new Rules[K];
            int counter = 0;
            while (cont < K)
            {
                if (cont == K - 1)
                {
                    TotalDeDivido = columnita.Count() - 1;
                }
                List<List<string>> subconjunto = new List<List<string>>();
                List<string> aux2;
                List<string> aux = new List<string>();
                int counter2 = 0;
                while (counter2 < columnas.Count())
                {
                    counter = 0;
                    aux.Add(atributos[counter2]);
                    aux2 = columnas[counter2];
                    while (counter < TotalDeDivido)
                    {
                        aux.Add(aux2[counter + 1]);
                        counter++;
                    }
                    counter2++;
                    subconjunto.Add(aux);
                }
                FinDelSubconjuto[cont] = counter;
                modelos[cont] = Cacular_reglas(subconjunto, index, anterior);
                TotalDeDivido = TotalDeDivido + ignorar;
                cont++;
            }
            int[,] MatrizDeConfusion;
            string[] Domines = CalcularClases(objective);
            MatrizDeConfusion = new int[Domines.Count()+1, Domines.Count() + 1];
        }
        List<string> NotTarget (Rules reglamento, List<List<string>> Tabla )
        {
            List<string> Nuevo;
            bool fag = true;
            
            while (fag)
            {
                foreach(var atributo in Tabla)
                {
                    foreach (var regla in reglamento.reglas)
                    {
                        if (atributo.Contains(regla.element))
                        {
                            Nuevo = atributo;
                            return Nuevo;
                        } 
                    }
                }
            }
            
            return null;
        }
        void KFolk (Rules[] reglas, List<string> target, List<List<string>> NOTTarget)
        {

        }
        string[] CalcularClases (List<string> data)
        {
            List<string> Dominious = new List<string>();
            foreach (var bit in data)
            {
                if (Dominious.Contains(bit))
                {

                }
                else
                {
                    Dominious.Add(bit);
                }
            }
            string[] Domi = Dominious.ToArray();
            return Domi;
        }
        Rules Cacular_reglas (List<List<string>> columnas, int index, Form1 anterior)
        {
            objective = columnas.ElementAt(index);
            columnNames = new List<string>();
            reglas = new List<Rules>();
            bool auxiliar;
            this.anterior = anterior;
            Rules reglaFinal = new Rules();
            columnasFinales = new Dictionary<string, List<ErrorPorList>>(); //nombre de la columna y el conjunto de reglas
            foreach (var columna in columnas)
            {
                columnNames.Add(columna.ElementAt(0));
                columna.RemoveAt(0);
            }
            columnas.RemoveAt(index);
            columnNames.RemoveAt(index);
            columnas.RemoveAt(0);
            columnNames.RemoveAt(0);
            objectiveName = objective.FirstOrDefault().ToString();
            this.columnas = columnas;
            this.index = index;
            columnQuantity = this.columnas.Count;
            InitializeComponent();
            reglaFinal = oneR();
            return reglaFinal;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void mostrarReglas(Rules reglas)
        {
            nombreReglas.Text = reglas.name;
            int columnas = 0;
            int id = 0;
            int actual = 0;
            bool completo = true;
            listaReglas.ColumnCount = reglas.reglas.Count + 1;
            listaReglas.Columns[columnas++].Name = "ID";
            foreach(var regla in reglas.reglas)
            {
                listaReglas.Columns[columnas].Name = "";
            }
            foreach(var regla in reglas.reglas)
            {
                ArrayList row = new ArrayList();
                row.Add(id++);
                row.Add(regla.element);
                row.Add(regla.objectiveElement);
                listaReglas.Rows.Add(row.ToArray());
            }
            listaReglas.BorderStyle = BorderStyle.None;
            listaReglas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            listaReglas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            listaReglas.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            listaReglas.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            listaReglas.BackgroundColor = Color.White;

            listaReglas.EnableHeadersVisualStyles = false;
            listaReglas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            listaReglas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            listaReglas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            listaReglas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public Rules oneR()
        {
            double errorMinimo;
            int minimo;
            var frequences = getFrequences();
            var conjuntos = cantidadDeErrores(frequences);
            List<ErrorPorList> reglasFinales = new List<ErrorPorList>();
            foreach (var conjunto in conjuntos)
            {
                foreach (var aux in conjunto)
                {
                    ErrorPorList error = new ErrorPorList();
                    error.element = aux.element;
                    error.objectiveElement = aux.objectiveElement;
                    error.quantity = aux.quantity;
                    reglasFinales.Add(error);
                    contador += error.quantity;
                    if (contador >= columnas.ElementAt(i).Count)
                    {
                        columnasFinales.Add(columnNames.ElementAt(i++), reglasFinales);
                        reglasFinales = new List<ErrorPorList>();
                        contador = 0;
                    }
                }
            }
            int j;
            foreach (var col in columnasFinales)
            {
                Rules nuevaRegla = new Rules();
                nuevaRegla.name = col.Key;

                for (int i = 0; i < col.Value.Count; i++)
                {
                    auxiliar = false;
                    SingleError error = new SingleError()
                    {
                        element = col.Value.ElementAt(i).element,
                        objectiveElement = col.Value.ElementAt(i).objectiveElement,
                        singleError = col.Value.ElementAt(i).quantity
                    };
                    nuevaRegla.cantidad += (int)error.singleError;
                    j = i + 1;
                    if (j < col.Value.Count)
                    {
                        while (col.Value.ElementAt(j).element == error.element)
                        {
                            auxiliar = true;
                            if (col.Value.ElementAt(j).quantity > error.singleError)
                            {
                                error.element = col.Value.ElementAt(j).element;
                                error.objectiveElement = col.Value.ElementAt(j).objectiveElement;
                                error.singleError = col.Value.ElementAt(j).quantity;
                            }
                            if (nuevaRegla.error == 0)
                            {
                                nuevaRegla.error = error.singleError;
                            }
                            nuevaRegla.cantidad += col.Value.ElementAt(j).quantity;
                            col.Value.RemoveAt(j);
                            j++;
                            if (j >= col.Value.Count)
                            {
                                break;
                            }
                        }
                        if (!auxiliar)
                        {
                            nuevaRegla.error = 0;
                        }

                    }
                    if (error.singleError < nuevaRegla.error)
                    {
                        nuevaRegla.error = error.singleError;
                    }
                    nuevaRegla.reglas.Add(error);
                }
                reglas.Add(nuevaRegla);
            }
            errorMinimo = reglas.FirstOrDefault().error / reglas.FirstOrDefault().cantidad;
            minimo = 0;
            for (int i = 0; i < reglas.Count; i++)
            {
                if ((reglas.ElementAt(i).error / reglas.ElementAt(i).cantidad) < errorMinimo)
                {
                    errorMinimo = reglas.ElementAt(i).error / reglas.ElementAt(i).cantidad;
                    minimo = i;
                }
            }
            return reglas.ElementAt(minimo);
        }

        private List<List<ErrorPorList>> cantidadDeErrores(List<List<FrequenceList>> frecuenciasPorColumna)
        {
            List<List<ErrorPorList>> erroresPorObjectivo = new List<List<ErrorPorList>>();
            var objectives = objective.GroupBy(r => r).Select(r => r.Key).ToList();
                foreach (var columna in frecuenciasPorColumna)
                {
                    foreach (var atributo in columna)
                    {
                        var values = atributo.frequences.GroupBy(x => new
                        {
                            x.element,
                            x.objectiveElement
                        }).Select(t => new ErrorPorList
                        {
                            element = t.Key.element,
                            objectiveElement = t.Key.objectiveElement,
                            quantity = t.Count()
                        }).ToList();
                        erroresPorObjectivo.Add(values);
                    }
                }
            return erroresPorObjectivo;
        }

        private List<List<FrequenceList>> getFrequences()
        {
            List<List<FrequenceList>> frecuenciasGlobales = new List<List<FrequenceList>>();
            int cantidadFrecuencias;
            bool crearNuevaFrecuencia;
            foreach (var columna in columnas) //va columna por columna
            {
                List<FrequenceList> frecuencias = new List<FrequenceList>();
                for (int i = 0; i < columna.Count; i++) //toma una sola columna contra la objetivo
                {
                    Frequences frecuencia = new Frequences();
                    frecuencia.element = columna[i];
                    frecuencia.objectiveElement = objective[i];
                    crearNuevaFrecuencia = true;
                    if(frecuencias.Count != 0)
                    {
                        cantidadFrecuencias = frecuencias.Count;
                        for (int y = 0; y < cantidadFrecuencias; y++)
                        {
                                if (frecuencias[y].frequences[0].element.Equals(frecuencia.element))
                                {
                                    frecuencias[y].frequences.Add(frecuencia);
                                    frecuencias[y].quantity++;
                                    crearNuevaFrecuencia = false;
                                }
                        }
                        if(crearNuevaFrecuencia)
                        {
                                var aux = new List<Frequences>();
                                aux.Add(frecuencia);
                                frecuencias.Add(new FrequenceList()
                                {
                                    frequences = aux,
                                    quantity = 1
                                });
                        }
                    }
                    else
                    {
                        frecuencias.Add(new FrequenceList()
                        {
                            frequences = new List<Frequences>(),
                            quantity = 1
                        });
                        frecuencias.FirstOrDefault().frequences.Add(frecuencia);
                    }
                    
                }
                frecuenciasGlobales.Add(frecuencias);
            }
            return frecuenciasGlobales;
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            anterior.Show();
            this.Close();
        }

        private void OneRAK_Load(object sender, EventArgs e)
        {

        }
    }
}
