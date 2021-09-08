using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            AhorroPesos APesos = new AhorroPesos();
            CorrienteDolares CDolares = new CorrienteDolares();
            CorrientePesos CPesos = new CorrientePesos();


            APesos.Insercion(5000);
            CDolares.Insercion(5000);
            CPesos.Insercion(5000);


            CPesos.Extraccion(30000, Cuenta.TipoDeExtraccion.CajeroAutomatico); //mas de 20k por cajero
            CPesos.Extraccion(300, Cuenta.TipoDeExtraccion.CajeroAutomatico); //ok
            CPesos.Extraccion(600, Cuenta.TipoDeExtraccion.CajeroHumano); //ok

            CDolares.Extraccion(300, Cuenta.TipoDeExtraccion.CajeroAutomatico); //mas de 200 por cajero
            CDolares.Extraccion(100, Cuenta.TipoDeExtraccion.CajeroAutomatico); //ok
            CDolares.Extraccion(600, Cuenta.TipoDeExtraccion.CajeroHumano); //ok

            APesos.Extraccion(999999999,Cuenta.TipoDeExtraccion.CajeroAutomatico); //sin fondos
            APesos.Extraccion(30000, Cuenta.TipoDeExtraccion.CajeroAutomatico); //mas de 10k por cajero
            APesos.Extraccion(500, Cuenta.TipoDeExtraccion.CajeroAutomatico); //ok
            APesos.Extraccion(600, Cuenta.TipoDeExtraccion.CajeroHumano); //ok

           

           
            

        }
    }
}
