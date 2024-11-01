using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueWebAppSol.Data.Entities
{
    public class Web
    {
        public int IdWeb { get; set; }

        public int NumeroPlaca { get; set; }


        public int CapacidadPiso1 { get; set; }

        public int CapacidadPiso2 { get; set; }

        public bool Disponible { get; set; }
    }
}
