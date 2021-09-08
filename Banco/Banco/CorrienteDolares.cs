using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class CorrienteDolares : Cuenta
    {
        public override void Extraccion(int monto, TipoDeExtraccion tipo)
        {
            switch (tipo)
            {
                case TipoDeExtraccion.CajeroAutomatico:
                    
                        if (monto > 200)
                        {
                            Console.WriteLine("No se puede extraer mas de 200 dolares por cajero automatico, visite una caja");
                        }
                        else
                        {
                            this.Cantidad -= monto;
                        }
                    break;

                case TipoDeExtraccion.CajeroHumano:
                    this.Cantidad -= monto;
                    break;
            }
        }
    }
}
