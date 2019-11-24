using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orange_perron_chido.DTO
{
    public class Rules
    {
        public string name { get; set; }
        public List<SingleError> reglas { get; set; }
        public double error { get; set; }
        public int cantidad { get; set; }
        public Rules()
        {
            reglas = new List<SingleError>();
        }
    }
}
