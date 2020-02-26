using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternResponsability.Bussines.ChainResponsability
{
    class ProcesadorDirectorHandler : ProcesadorNivelesHandler
    {
        public override string Handler(double _dImporte, string _cConcepto)
        {
            if (_dImporte > 15000 && _dImporte <= 20000)
            {
                return base.GeneraMensaje(_cConcepto, "DIRECTOR");
            }
            else
            {
                return "Solicitud DENEGADA";
            }
        }

    }
}
