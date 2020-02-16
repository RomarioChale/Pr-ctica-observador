using System;

namespace Observadores
{

    class Program
    {


        static void Main(string[] args)
        {
           


            int opcion;

            Console.WriteLine("Introduce una opcion:");


            Devops devopsObservado = new Devops();
            SubirCodigo subirCodigoObservado = new SubirCodigo();
            AgregarNotificador agregarNotificadorObservado = new AgregarNotificador();
            AgregarCompilador agregarCompiladorObservado = new AgregarCompilador();
            EjecutarPruebasUnitarias ejecutarPruebasUnitariasObservado = new EjecutarPruebasUnitarias();
            AgregarInstalador agregarInstaladorObservado = new AgregarInstalador();

            bool activa = true;

            do {

                Console.WriteLine("1. Subir código");
                Console.WriteLine("2. Agregar notificador");
                Console.WriteLine("3. Agregar compilador");
                Console.WriteLine("4. Agregar ejecutor de pruebas");
                Console.WriteLine("5. Agregar instalador");

                opcion = Convert.ToInt16(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        devopsObservado.AgregarObservador(subirCodigoObservado);
                        break;
                    case 2:
                        devopsObservado.AgregarObservador(agregarNotificadorObservado);
                        break;

                    case 3:
                        devopsObservado.AgregarObservador(agregarCompiladorObservado);
                        break;
                    case 4:
                        devopsObservado.AgregarObservador(ejecutarPruebasUnitariasObservado);
                        break;
                    case 5:
                        devopsObservado.AgregarObservador(agregarInstaladorObservado);
                        break;

                    default:
                        activa = false;
                        break;

                }
            } while (activa);
         
          

            Console.ReadLine();
        }
    }
}
