using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternResponsability.Bussines.ChainResponsability
{
    class ProcesadorSubdirectorHandler : ProcesadorNivelesHandler
    {
        public override string Handler(double _dImporte, string _cConcepto)
        {
            if (_dImporte > 10000 && _dImporte <= 15000)
            {
                return base.GeneraMensaje(_cConcepto, "SUBDIRECTOR");
            }
            else
            {
                return base.Handler(_dImporte, _cConcepto);
            }
        }
    }
}
