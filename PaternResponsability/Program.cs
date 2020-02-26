using PaternResponsability.Bussines.ChainResponsability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternResponsability
{
    class Program
    {
        static void Main(string[] args)
        {

            string cConcepto = string.Empty, cRespuesta = string.Empty;
            double dImporte = 0;

            Console.WriteLine("**** Sistema para solicitudes de Compra *****");
            Console.WriteLine("Proporcione el concepto");
            cConcepto = Console.ReadLine();

            Console.WriteLine("Proporcione el importe");
            double.TryParse(Console.ReadLine(), out dImporte);


            ProcesadorNivelesHandler svrProcesadorCoordinador = new ProcesaroCoordinadorHandler();
            ProcesadorNivelesHandler svrProcesadorGerente = new ProcesadorGerenteHandler();
            ProcesadorNivelesHandler svrProcesadorSubdirector = new ProcesadorSubdirectorHandler();
            ProcesadorNivelesHandler svrProcesadorDirector = new ProcesadorDirectorHandler();

            svrProcesadorCoordinador.SetNextHandler(svrProcesadorGerente).SetNextHandler(svrProcesadorSubdirector).SetNextHandler(svrProcesadorDirector);
            cRespuesta = svrProcesadorCoordinador.Handler(dImporte, cConcepto);

            Console.WriteLine(cRespuesta);
        
            Console.Write("Presiona cualquier tecla para salir del programa...");
            Console.ReadKey();

        }
    }
}
