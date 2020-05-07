using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Entiteti
{
    public abstract class Smena
    {
        public virtual int Id_smena { get; protected set; }

        public virtual DateTime Datum_od { get; set; }

        public virtual DateTime Datum_do { get; set; }

        public virtual char Tip_smene { get; set; }

        protected Smena() { }

        public override string ToString()
        {
            return base.ToString() + ":\nId smene: " + this.Id_smena + "\nDatum od: " + this.Datum_od +
                "\nDatum do: " + this.Datum_do + "\nTip smene: " + this.Tip_smene;
        }
    }

    public class Smena1 : Smena { }

    public class Smena2 : Smena { }

    public class Smena3 : Smena { }
}
