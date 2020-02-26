using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternResponsability.Bussines.ChainResponsability
{
    public interface IProcesadorNivelesHandler
    {
        IProcesadorNivelesHandler SetNextHandler(IProcesadorNivelesHandler _IProcesadorNivelesHandler);
        string Handler(double _dImporte, string _cConcepto);
    }
}
