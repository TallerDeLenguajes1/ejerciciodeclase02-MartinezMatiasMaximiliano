using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class AhorroPesos : Cuenta
    {
        public override void Extraccion(int monto, TipoDeExtraccion tipo)
        {
            if (this.Cantidad < monto)
            {
                switch (tipo)
                {
                    case TipoDeExtraccion.CajeroAutomatico:

                        if (monto > 10000)
                        {
                            Console.WriteLine("No se puede extraer mas de 10k por cajero automatico, visite una caja");
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
            else
            {
                Console.WriteLine("No se realizo la extraccion, fondos insuficientes");
            }
            
        }
    }
}
