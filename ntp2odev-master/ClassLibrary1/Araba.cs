using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasitLib
{
    public class Tasit
    {
        public string marka;
        public string model;
    }
    public class Araba : Tasit
    {
        public string Model { get => model; set => model = value.ToUpper(); }
        public string Marka { get => marka; set => marka = value.ToUpper(); }
    }
}