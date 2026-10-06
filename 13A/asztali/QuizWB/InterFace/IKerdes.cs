using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.InterFace
{
    internal interface IKerdes
    {
        string Temakor { get; set; }
        byte Pontszam { get; set; }
        byte Jatszas();
    }
}
