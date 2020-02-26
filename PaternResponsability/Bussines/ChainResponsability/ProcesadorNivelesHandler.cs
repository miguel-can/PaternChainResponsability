using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternResponsability.Bussines.ChainResponsability
{
    abstract class ProcesadorNivelesHandler : IProcesadorNivelesHandler
    {
        private IProcesadorNivelesHandler svrProcesdorNivelesHandler;
        public IProcesadorNivelesHandler SetNextHandler(IProcesadorNivelesHandler _IProcesadorNivelesHandler)
        {
            this.svrProcesdorNivelesHandler = _IProcesadorNivelesHandler;
            return _IProcesadorNivelesHandler;
        }

        public virtual string Handler(double _dImporte, string _cConcepto)
        {
            if (this.svrProcesdorNivelesHandler != null)
            {
                return this.svrProcesdorNivelesHandler.Handler(_dImporte, _cConcepto);
            }
            else
            {
                return null;
            }
        }

        public string GeneraMensaje(string _cConcepto, string _cNivel)
        {
            return string.Format("{0} de compra AUTORIZADA por el {1}", _cConcepto, _cNivel);
        }
    }
}
