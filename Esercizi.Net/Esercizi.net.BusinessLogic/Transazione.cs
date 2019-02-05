using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi.net.BusinessLogic
{
    
    public abstract class Transazione : ITransazione
    {

        //cambio il tipo, dopo enum diventa Tipotransazione, non più stringa


        //COME ERA prima di enum:

        //private string _tipo;
        //public string Tipo
        //{
        //    get
        //    {
        //        return _tipo;
        //    }
        //    set
        //    {
        //        if (value == "Spesa" || value == "Ricavo")
        //        {
        //            _tipo = value;
        //        }
        //    }
        //}

        //DOPO enum:

        //private TipoTransazione _tipo;
        //public TipoTransazione Tipo

        //{
        //    get
        //    {
        //        return _tipo;
        //    }
        //    set
        //    {
        //        if (value == "Spesa" || value == "Ricavo")
        //        {
        //            _tipo = value;
        //        }
        //    }
        //}

        //MA POSSO ULTERIORMENTE CONDENSARE:
        //inoltre non ho più bisogno di estendere get e set perchè ho già dato condizioni su Tipotransazione dicendo che deve essere o spesa o ricavo

        public TipoTransazione Tipo { get; set; }

        public DateTime DataTransazione { get; set; }

        public string Categoria { get; set; }

        public string Descrizione { get; set; }

        public abstract decimal Importo { get; set; }

        public override string ToString()
        {
            string result = string.Empty;
            result += "Data transazione: " + DataTransazione + ",\n";
            result += "Tipo transazione:" + Tipo + "\n";
            result += "Categoria: " + Categoria + ",\n";
            result += "Descrizione: " + Descrizione + ",\n";
            result += "Importo: " + Importo + ".\n";

            return result;
        }
    }

}
