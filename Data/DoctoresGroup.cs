using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Citas_Medicas.Data
{
    public class DoctoresGroup : List<DoctoresLista>
    {        
        public string Name { get; set; }
        public DoctoresGroup(string name, List<DoctoresLista> doctores) : base (doctores)
        {
            Name = name;
        }
    }
}

