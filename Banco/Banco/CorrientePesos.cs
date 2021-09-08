using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class CorrientePesos : Cuenta
    {
        public override void Extraccion(int monto, TipoDeExtraccion tipo)
        {
            
            switch (tipo)
            {
                case TipoDeExtraccion.CajeroAutomatico:
                    if ((this.Cantidad - monto) < -5000)
                    {
                        Console.WriteLine("no se puede extraer, la cuenta quedaria con menos de -5000 pesos");
                    }
                    else
                    {
                        if (monto > 20000)
                        {
                            Console.WriteLine("No se puede extraer mas de 20k por cajero automatico, visite una caja");
                        }
                        else
                        {
                            this.Cantidad -= monto;
                        }
                    }

                    break;
                case TipoDeExtraccion.CajeroHumano:
                    this.Cantidad -= monto;
                    break;
            }
        }
    }
}
