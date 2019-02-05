using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi.net.BusinessLogic
{
    public interface ITransazione
    {
        //string Tipo { get; set; } 
        //quando aggiugo enum non ho più una stringa ma diventa tipotransazione, cambio proprietà
        TipoTransazione Tipo { get; set; }
        string Categoria { get; set; }
        string Descrizione { get; set; }
        DateTime DataTransazione { get; set; }
        decimal Importo { get; set; }
    }
     
}
