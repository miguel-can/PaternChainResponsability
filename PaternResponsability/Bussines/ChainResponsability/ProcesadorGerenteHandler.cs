using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternResponsability.Bussines.ChainResponsability
{
    class ProcesadorGerenteHandler : ProcesadorNivelesHandler
    {
        public override string Handler(double _dImporte, string _cConcepto)
        {
            if (_dImporte > 5000 && _dImporte <= 10000)
            {
                return base.GeneraMensaje(_cConcepto, "GERENTE");
            }
            else
            {
                return base.Handler(_dImporte, _cConcepto);
            }
        }
    }
}
