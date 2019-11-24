using System;
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
    public partial class Bivariable : Form
    {
        public Bivariable()
        {
            InitializeComponent();
        }

        public List<string> atributos;
        public List<string> valores;
        public List<string> tipo;
        public List<string> dominio;
        List<string> Val1 = new List<string>();
        List<string> Val2 = new List<string>();
        public Form1 Ventana;
        public bool csv = false;
        void TeOdio (int First, int Atributo1)
        {
            if (First >= valores.Count())
            {
                return;
            }
            else 
            {
                Val1.Add(valores[First]);
                First = First + Atributo1 + 1;
            }
            TeOdio(First, Atributo1);

        }
        void TeOdio2(int First, int Atributo1)
        {
            if (First >= valores.Count())
            {
                return;
            }
            else
            {
Val2.Add(valores[First]);
                First = First + Atributo1 + 1;
            }
            TeOdio2(First,Atributo1);

        }
        double CalcularSigma (List<double> num, double prom)
        {
            double sigma = 0;
            double sumatoria = 0;
            double resul = 0;
            int contador = 0;
            while(contador<num.Count())
            {
                resul = num[contador] - prom;
                resul = resul * resul;
                sumatoria = sumatoria + resul;
                contador++;
            }
            sumatoria = sumatoria / num.Count();
            sigma = Math.Sqrt(sumatoria);
            return sigma;
        }
        double Promedio(List<double> num)
        {
            double Promedio =0;
            foreach(var x in num)
            {
                Promedio = Promedio + x;
            }
            Promedio = Promedio / num.Count();
            return Promedio;

        }
        private void Bivariable_Load(object sender, EventArgs e)
        {
            foreach (var atri in atributos)
            {
                CBA1.Items.Add(atri);
                CBA2.Items.Add(atri);
            }

        }
        int GetNumberIndex (string[] array, string dato)
        {
            int index = 0;
            bool flag = true;
            while (flag)
            {
                if(array[index]==dato)
                {
                    flag = false;
                }
                index++;
            }
            return index;
        }
        int[,] FillEnd (int[,] matriz, int x, int y)
        {
            int zero = 0;
            int contador2 = 0;
            int contador = 0;
            int suma = 0;
            while (contador2<y-1)
            {
                while (contador < x-1)
                {
                    suma = suma + matriz[contador,contador2];
                   
                    contador++;
                }
                matriz[contador, contador2] = suma;
                contador = zero;
                contador2++;
                suma = 0;
            }
            suma = 0;
            contador = 0;
            contador2=0;
            while (contador < x - 1)
            {
                while (contador2 < y - 1)
                {
                    suma = suma + matriz[contador, contador2];
                     contador2++;
                }
                matriz[contador, contador2] = suma;
                
                contador2 = 0;
                contador++;
                suma =0;
            }
            contador = 0;
            contador2 = 0;
            suma = 0;
                while (contador <= y - 1)
                {
                    suma = suma + matriz[x-1, contador];
                    contador++;
                }
            matriz[x - 1, y - 1] = suma;
            return matriz;
        }
        double ChiCuadrada(int[,] matriz, int x, int y)
        {
            double Cucaracha = 0, Chi=0, aux=0;
            int contX = 0, ContY = 0, ValorInterceptado=0;
            while (ContY<y)
            {
                while (contX<x)
                {
                    aux = (matriz[contX,y] * matriz[x,ContY])/matriz[x,y];
                    ValorInterceptado = matriz[contX, ContY];
                    Chi = Chi + (((ValorInterceptado - aux) * (ValorInterceptado - aux)) / aux);
                    
                    contX++;
                }
                contX = 0;
                ContY++;
            }
            Cucaracha = Chi;
            return Cucaracha;
        }
        double TsChuProw(double Cucaracha, int x, int y, int TotalOfData)
        {
            double Tschuprow = Math.Sqrt((Cucaracha/(TotalOfData*Math.Sqrt((x-1)*(y-1)))));
            return Tschuprow;
        }
        string[] FindDomine (List<string> data)
        {
            List<string> Dominious = new List<string>();
            foreach(var bit in data)
            {
                if(Dominious.Contains(bit))
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

        private void Correlación_Click(object sender, EventArgs e)
        {
            if(CBA1.Text=="" && CBA2.Text=="")
            {
                MessageBox.Show("Por favor, seleccione los dos atributos a analizar");
            }
            else
            {
                int cont = 0;
                int Atributo1 = 0;
                int Atributo2 = 0;
                while (cont < atributos.Count())
                {
                    if (atributos[cont]==CBA1.Text)
                    {
                        Atributo1 = cont + 1;
                    }
                    else if (atributos[cont] == CBA2.Text)
                    {
                        Atributo2 = cont + 1;
                    }
                    cont++;
                }
                int ejem = 0;
                MessageBox.Show(valores[Atributo1 - 1].ToString());
                if (!int.TryParse(valores[Atributo1-1], out ejem))
                    {
                    
                        int First = Atributo1 - 1;
                        int Second = Atributo2 - 1;
                        while (First < valores.Count())
                        {
                            Val1.Add(valores[First]);
                            First = First + atributos.Count();
                    }
                        
                        while (Second < valores.Count())
                        {
                            Val2.Add(valores[Second]);
                            Second = Second + atributos.Count();
                        }


                        List<double> Ele1 = new List<double>();
                        List<double> Ele2 = new List<double>();
                        foreach (var x in Val1)
                        {
                            Ele1.Add(Convert.ToDouble(x));
                        }
                        foreach (string x in Val2)
                        {
                            Ele2.Add(Convert.ToDouble(x));
                        }
                        double Media1 = Promedio(Ele1);
                        double Media2 = Promedio(Ele2);
                        double sigma1 = CalcularSigma(Ele1,Media1);
                        double sigma2 = CalcularSigma(Ele2, Media2);
                        int cont3 = 0;
                        double resultado = 0;
                        double sumatoria = 0;
                        while(cont3 < Ele2.Count())
                        {
                            resultado = (Ele1[cont3]-Media1) * (Ele2[cont3] - Media2);

                            sumatoria = sumatoria + resultado;
                            cont3++;
                        }
                        MessageBox.Show(sumatoria.ToString());
                        double resul3 = sumatoria / (Ele1.Count() * sigma1 * sigma2);
                        if (resul3>0.5)
                        {
                            btntext.Text = "El atributo " + CBA1.Text + " esta bastante correlacionado con el atributo " + CBA2.Text;
                            btnRes.Text = "El resultado es " + resul3.ToString();
                        }
                        else
                        {
                            btntext.Text = "El atributo " + CBA1.Text + " esta debilmente correlacionado con el atributo " + CBA2.Text;
                            btnRes.Text = resul3.ToString();
                        }
                    }
                    else
                    {
                        int First = Atributo1 - 1;
                        int Second = Atributo2 - 1;
                        while (First < valores.Count())
                        {
                            Val1.Add(valores[First]);
                            First = First + atributos.Count();
                        }

                        while (Second < valores.Count())
                        {
                            Val2.Add(valores[Second]);
                            Second = Second + atributos.Count();
                        }
                        //Sacar dominios 
                        string[] valdom1;
                        string[] valdom2;
                        if (csv)
                        {
                            valdom1 = FindDomine(Val1);
                            valdom2 = FindDomine(Val2);
                        }
                        else
                        {
                        string Dom1 = dominio[Atributo1-1];
                        string Dom2 = dominio[Atributo2-1];
                        Char[] v = { '[', ']' };
                        string temp = Dom1;
                        Dom1 = temp.Trim(v);
                        temp = Dom2;
                        Dom2 = temp.Trim(v);
                        valdom1 = Dom1.Split('|');
                        valdom2 = Dom2.Split('|');
                        }

                        //CALCULAR DISTANCIA

                        //Empezar a llenar la matriz
                        int cont1 = 0;
                        int[,] matriz;
                        matriz = new int[valdom1.Count()+1, valdom2.Count()+1];
                       
                            while (cont1 < Val1.Count())
                            {
                                int valor1 = GetNumberIndex(valdom1,Val1[cont1])-1;
                                int valor2 = GetNumberIndex(valdom2, Val2[cont1])-1;
                            int PlusValue = matriz[valor1,valor2];
                                PlusValue = PlusValue + 1;
                                matriz[valor1, valor2] = PlusValue;
                                
                                cont1++;
                            }
                            matriz = FillEnd(matriz,valdom1.Length+1,valdom2.Length+1);
                        double resultado = TsChuProw(ChiCuadrada(matriz, valdom1.Length , valdom2.Length), valdom1.Length, valdom2.Length, matriz[valdom1.Length, valdom2.Length]);
                        btnRes.Text = resultado.ToString();
                    if (resultado<0.5)
                    {
                        btntext.Text = "El atributo " + CBA1.Text + " esta debilmente correlacionado con el atributo " + CBA2.Text;
                    }
                    else

                    {
                        btntext.Text = "El atributo " + CBA1.Text + " esta altamente correlacionado con el atributo " + CBA2.Text;
                    }
                    }
                
                
            }
        }
    }
}
