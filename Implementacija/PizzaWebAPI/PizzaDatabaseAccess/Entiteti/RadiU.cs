using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDatabaseAccess.Entiteti
{
    public class RadiU
    {
        public virtual int Id_surogat_radi_u { get; protected set; }
        public virtual Osoba Id_osoba { get; set; }
        public virtual Smena Id_smena { get; set; }
                
        public RadiU(){ }
    }
}
