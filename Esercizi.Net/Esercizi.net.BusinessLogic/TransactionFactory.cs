using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi.net.BusinessLogic
{

    public class TransactionFactory : ITransactionFactory
        //sarebbe stato lo stesso scrivere "public class TransactionFactory : IFactory <ITransazione>"
        //avrei saltato passaggio passando direttamente da ITransazione a IFactory senza passare da ITransactionFactory
    {
        public ITransazione Create()
        {
            return new TransazioneGK();
        }
    }

}
