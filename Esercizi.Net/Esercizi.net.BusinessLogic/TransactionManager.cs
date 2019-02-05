using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi.net.BusinessLogic
{
    //creo gestore delle transazioni che deve creare, salvare, rimuovere transazione, restituire elenco transazioni

    public class TransactionManager
    {
        //per funzionare manager ha bisogno della factory

        //riga sotto è una property (non ha parentesi tonda, se le avesse sarebbe metodo), è una property di TIPO ITransaction ed è una property che si CHIAMA Factory
        public ITransactionFactory Factory { get;  }
        public List<ITransazione> Transazioni { get; }

        //per evitare errore (per ora scrivila poi verrà spiegata)
        public TransactionManager() : this(new TransactionFactory())
        { }

        
        public TransactionManager(ITransactionFactory factory)
        {
            Factory = factory;
            Transazioni = new List<ITransazione>();
        }

        //mi dice crea una transazione e dimmi dove è
        // ha le parentesi, è COSTRUTTORE serve per istanziare oggetti di una certa classe
        //una volta istanziato costruttore posso istanziare metodi su quel costruttore

         //METODO 
        public ITransazione CreateTransaction()
        {
            return Factory.Create();
        }



        //METODO particolae void che restituisce blocco nullo
        public void SaveTransaction(ITransazione transazione)
        {
            Transazioni.Add(transazione);
        }


        public ITransazione DeleteTransaction(int index)
        {
            return null;
        }


        //Inumerable comando che contiene lettura per insiemi ma non per la modifica
        public IEnumerable<ITransazione> GetTransaction()
        {
            return null;
        }
    }
}
