using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using System.ComponentModel;
using Microsoft.VisualBasic.FileIO;
using System.Diagnostics.Metrics;


public class telefoniaclaro
{
    static public int opciones;
    static void Main(string[] args)
    {

        telefoniaclaro capturaDatos = new telefoniaclaro();
        capturaDatos.captura();
        
        

    }



    public void captura()
    {
        Console.WriteLine("1.Compras");

        Console.WriteLine("2.consultas");

        Console.WriteLine("3.Regala");

        Console.WriteLine("4.NavegacionLibre");

        Console.WriteLine("5.comparte");

        Console.WriteLine("6.Roaming");

        Console.WriteLine("7.internet inalambrico fijo");

        Console.WriteLine("Seleccione la opcion deseada");

        Console.WriteLine("---------------------------------");
        opciones = int.Parse(Console.ReadLine());

        
        switch (opciones)
        {
            case 1:
                Compras subcompras = new Compras();
                subcompras.seleccionaropcioncompras();


                break;
            case 2:
                Consultas subconsultas = new Consultas();
                subconsultas.opcionConsultas();


                break;
            case 3:
                Regala subregala = new Regala();
                subregala.opcionregala();
          

                break;
            case 4:
                Navegacionlibre subnavegacionlibre = new Navegacionlibre();
                subnavegacionlibre.opcionnavegacionlibre();


                break;
            case 5:
                comparte subcomparte = new comparte();
                subcomparte.opcioncomparte();


                break;
            case 6:
                roaming subroaming = new roaming();
                subroaming.opcionroaming();



                break;
            case 7:
                internetinalambricofijo subinternetinalambricofijo = new internetinalambricofijo();
                subinternetinalambricofijo.opcioninternetinalambricofijo();

                break;
            default: //REVISAR EL VALOR DEFAULT
                Console.WriteLine("Valor incorrecto ingresado");
                break;

        }
    }

   

    public class Compras : telefoniaclaro
    {
        static public int opcioncompras;
        public void seleccionaropcioncompras()
        {
            Console.Clear();
            Console.WriteLine("Selecciona una opcion:\n");

            Console.WriteLine("1. Paquetes Libres ");
            Console.WriteLine("2. Paquetes Libres Plus");
            Console.WriteLine("3. Ofertas");
            Console.WriteLine("4. Turbo Carga");
            Console.WriteLine("5. Nav Horas");
            Console.WriteLine("6. Chat y Redes");
            Console.WriteLine("7. Adelanta Paquetes");

            opcioncompras = int.Parse(Console.ReadLine());

            switch (opcioncompras)
            {

                case 1:
                    paqlibresseleccionado paqlibresselecc = new paqlibresseleccionado();
                    paqlibresselecc.opcionpaqLibres();
                    break;
                case 2:
                    paqLibresplusselecc paqLibresplusselec = new paqLibresplusselecc();
                    paqLibresplusselec.opcionpaqLibresplusselec();
                    break;
                case 3:
                    opofertasseleccionado ofertasselecc = new opofertasseleccionado();
                    ofertasselecc.opcionofertasselecc();

                    break;
                case 4:
                    opturbocargaseleccionado opturbocarga = new opturbocargaseleccionado();
                    opturbocarga.opcionturbocarga();

                    break;
                case 5:
                    opNavhorasseleccionado opnavhoras = new opNavhorasseleccionado();
                    opnavhoras.opcionnavhoras();

                    break;
                case 6:
                    opchatyredesseleccionado opchatyredes = new opchatyredesseleccionado();
                    opchatyredes.opcionchatyredes();


                    break;
                case 7:
                    opadelantapaquetesseleccionado opadelantapaquetes = new opadelantapaquetesseleccionado();
                    opadelantapaquetes.opcionadelantapaquetes();


                    break;

                default:
                    break;

            }

        }
       
     }


    
    public class paqlibresseleccionado : Compras
    {
        static public int paqlibresseleccionados;
        public void opcionpaqLibres()
        {
            Console.Clear();
            Console.WriteLine("seleccione una opcion");

            Console.WriteLine("1.1 Dia 1GB 50");
            Console.WriteLine("2.3 Dia 3GB 95");
            Console.WriteLine("3.5 Dia 5GB 145");

            Console.WriteLine("\nSelecciona una opcion:");
            paqlibresseleccionados = int.Parse(Console.ReadLine());
            
           
                //Codigo Agregado dale un vistazo a las condicionales
                if (paqlibresseleccionados == 1)
                {
               
                    Console.Clear();
                    Console.WriteLine("Estas seguro de comprarlo?");
                    Console.WriteLine("1.Si");
                    Console.WriteLine("2.No");
                    paqlibresseleccionados = int.Parse(Console.ReadLine());
               
                    Console.Clear();

                    switch (paqlibresseleccionados)
                    {
                        case 1:
                            Console.WriteLine("Compraste el paquete con Exito");
                        captura();
                        break;
                        case 2:
                        captura();
                        Console.WriteLine("Cancelaste la compra del paquete");

                            break;
                   
                    }
            if (paqlibresseleccionados ==4)
                {
                    Console.WriteLine("seleccione 4 para ir al menu principal");
                    paqlibresseleccionados = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                
                    Console.ReadKey(); //Para Ver mejor el resultado, para terminar el programa darle 2 veces al Enter (Esto es opcional)

                }
                else if (paqlibresseleccionados == 2)
                {

                    Console.Clear();
                    Console.WriteLine("Estas seguro de comprarlo?");
                    Console.WriteLine("1.Si");
                    Console.WriteLine("2.No");

                    paqlibresseleccionados = int.Parse(Console.ReadLine());

                    Console.Clear();

                    switch (paqlibresseleccionados)
                    {
                    case 1:
                        Console.WriteLine("Compraste el paquete con Exito");
                        break;
                    case 2:
                        Console.WriteLine("Cancelaste la compra del paquete");
                        break;
                     }

                switch (paqlibresseleccionados)
                {
                    case 1:

                        captura();
                        break;
                    case 2:

                        captura();
                        break;

                }
                Console.ReadKey(); //Para Ver mejor el resultado, para terminar el programa darle 2 veces al Enter (Esto es opcional)

                }
                else if (paqlibresseleccionados == 3)
                {

                 Console.Clear();
                 Console.WriteLine("Estas seguro de comprarlo?");
                 Console.WriteLine("1.Si");
                 Console.WriteLine("2.No");
 
                 paqlibresseleccionados = int.Parse(Console.ReadLine());

                 Console.Clear();

                 switch (paqlibresseleccionados)
                 {
                    case 1:
                        Console.WriteLine("Compraste el paquete con Exito");
                        break;
                    case 2:
                        Console.WriteLine("Cancelaste la compra del paquete");
                        break;
                }
                switch (paqlibresseleccionados)
                {
                    case 1:

                        captura();
                        break;
                    case 2:

                        captura();
                        break;

                }

                Console.ReadKey(); //Para Ver mejor el resultado, para terminar el programa darle 2 veces al Enter (Esto es opcional)
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Entrada Incorrecta");
                    Console.ReadKey(); //Para Ver mejor el resultado, para terminar el programa darle 2 veces al Enter (Esto es opcional)

                }
          
        }


    }

    public class paqLibresplusselecc : Compras
    {
        static public int paqLibresplusselec;

        public void opcionpaqLibresplusselec()
        {
            Console.Clear();
            Console.WriteLine("1.1 Dia plus 2GB 65");
            Console.WriteLine("2.3 Dia plus 5GB 120 ");
            Console.WriteLine("3.5 Dia plus 8GB 170");

            Console.WriteLine("Seleccione una opcion:");
            paqLibresplusselec = int.Parse(Console.ReadLine());

            if (paqLibresplusselec == 1)
            {

                Console.Clear();
                Console.WriteLine("Estas seguro de comprarlo?");
                Console.WriteLine("1.Si");
                Console.WriteLine("2.No");

                paqLibresplusselec = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (paqLibresplusselec)
                {
                    case 1:
                        Console.WriteLine("Compraste el paquete con exito");
                        break;
                    case 2:
                        Console.WriteLine("Cancelaste la compra con exito");
                        break;
                }
                switch (paqLibresplusselec)
                {
                    case 1:

                        captura();
                        break;
                    case 2:

                        captura();
                        break;

                }
                Console.ReadKey();

              Console.ReadKey(); //Para Ver mejor el resultado, para terminar el programa darle 2 veces al Enter (Esto es opcional)
            }
            else if (paqLibresplusselec == 2)
            {
                Console.Clear();
                Console.WriteLine("Estas seguro de comprarlo?");
                Console.WriteLine("1.Si");
                Console.WriteLine("2.No");

                paqLibresplusselec = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (paqLibresplusselec)
                {
                    case 1:
                        Console.WriteLine("Compraste el paquete con exito");
                        break;
                    case 2:
                        Console.WriteLine("Cancelaste la compra con exito");
                        break;
                }
                switch (paqLibresplusselec)
                {
                    case 1:

                        captura();
                        break;
                    case 2:

                        captura();
                        break;

                }
                Console.ReadKey();
            }
            else if (paqLibresplusselec ==3)
            {
                Console.Clear();
                Console.WriteLine("Estas seguro de comprarlo?");
                Console.WriteLine("1.Si");
                Console.WriteLine("2.No");

                paqLibresplusselec = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (paqLibresplusselec)
                {
                    case 1:
                        Console.WriteLine("Compraste el paquete con exito");
                        break;
                    case 2:
                        Console.WriteLine("Cancelaste la compra con exito");
                        break;
                }
                switch (paqLibresplusselec)
                {
                    case 1:

                        captura();
                        break;
                    case 2:

                        captura();
                        break;

                }
                Console.ReadKey();
            }

        }
    
    
    
    }

    public class opofertasseleccionado : Compras
    {
        static public int opofertasselec;


        public void opcionofertasselecc()
        {
            Console.Clear();
            Console.WriteLine("1.7 Dias 200");
            Console.WriteLine("2.10 Dias 280");
            Console.WriteLine("3.15 Dias 420");

            Console.WriteLine("Seleccione la opcion deseada:");
            opofertasselec = int.Parse(Console.ReadLine());

        if (opofertasselec ==1)
            {
                Console.Clear();
                Console.WriteLine("Estas seguro de comprarlo?");
                Console.WriteLine("1.Si");
                Console.WriteLine("2.No");

                opofertasselec = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opofertasselec)
                {
                    case 1:
                        Console.WriteLine("Compra seleccionada con exito");
                        break;
                    case 2:
                        Console.WriteLine("Compra cancelada con exito");
                        break;
                }
                switch (opofertasselec)
                {
                    case 1:

                        captura();
                        break;
                    case 2:

                        captura();
                        break;

                }
                Console.ReadKey();
            }
        else if (opofertasselec ==2)
            {
                Console.Clear();
                Console.WriteLine("Estas seguro de comprarlo?");
                Console.WriteLine("1.Si");
                Console.WriteLine("2.No");

                opofertasselec = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opofertasselec)
                {
                    case 1:
                        Console.WriteLine("Compra seleccionada con exito");
                        break;
                    case 2:
                        Console.WriteLine("Compra cancelada con exito");
                        break;
                }
                switch (opofertasselec)
                {
                    case 1:

                        captura();
                        break;
                    case 2:

                        captura();
                        break;

                }
                Console.ReadKey();


            }
        else if (opofertasselec ==3)
            {
                Console.Clear();
                Console.WriteLine("Estas seguro de comprarlo?");
                Console.WriteLine("1.Si");
                Console.WriteLine("2.No");

                opofertasselec = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opofertasselec)
                {
                    
                    case 1:
                        Console.WriteLine("Compra seleccionada con exito");
                        
                        break;
                    case 2:
                        Console.WriteLine("Compra cancelada con exito");
                       
                        break;
                   
                }
                switch (opofertasselec)
                {
                    case 1:

                        captura();
                        break;
                    case 2:

                        captura();
                        break;

                }
                Console.ReadKey();

            }
           
        
        }





    }

    public class opturbocargaseleccionado : Compras
    {
        static public int opturbocargaselec;
        public void opcionturbocarga()
        {
            Console.Clear();
            Console.WriteLine("no cargo el codigo");
            Console.WriteLine("Presiona la tecla 1 para retornar");
            opturbocargaselec = int.Parse(Console.ReadLine());
            Console.Clear();
            switch(opturbocargaselec)
            {
                case 1:
                    captura();
                    break;
            }

        }

    }

    public class opNavhorasseleccionado : Compras
    {
        static public int opcionesnavhoras;

        public void opcionnavhoras()
        {
            Console.Clear();
            Console.WriteLine("1.10 MB 1 horas 10");
            Console.WriteLine("2.40 MB 3 horas 20");
            Console.WriteLine("3.100 MB 7 horas 30");
            Console.WriteLine("Seleccione una opcion");
            opcionesnavhoras = int.Parse(Console.ReadLine());

        if (opcionesnavhoras == 1)
            {
                Console.Clear();
                    Console.WriteLine("Estas seguro de comprarlo?");
                    Console.WriteLine("1.Si");
                    Console.WriteLine("2.No");

                    opcionesnavhoras = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (opcionesnavhoras)
                    {
                        case 1:
                            Console.WriteLine("Compra seleccionada con exito");
                            break;
                        case 2:
                            Console.WriteLine("Compra cancelada con exito");
                            break;
                    }
                switch (opcionesnavhoras)
                {
                    case 1:

                        captura();
                        break;
                    case 2:

                        captura();
                        break;

                }
                Console.ReadKey();
                 
            }
            else if (opcionesnavhoras == 2)
            {
                Console.Clear();
                    Console.WriteLine("Estas seguro de comprarlo?");
                    Console.WriteLine("1.Si");
                    Console.WriteLine("2.No");

                    opcionesnavhoras = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (opcionesnavhoras)
                    {
                        case 1:
                            Console.WriteLine("Compra seleccionada con exito");
                            break;
                        case 2:
                            Console.WriteLine("Compra cancelada con exito");
                            break;
                    }
                switch (opcionesnavhoras)
                {
                    case 1:

                        captura();
                        break;
                    case 2:

                        captura();
                        break;

                }
                Console.ReadKey();
                 

            }
            else if (opcionesnavhoras == 3)
            {
                Console.Clear();
                    Console.WriteLine("Estas seguro de comprarlo?");
                    Console.WriteLine("1.Si");
                    Console.WriteLine("2.No");

                    opcionesnavhoras = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (opcionesnavhoras)
                    {
                        case 1:
                            Console.WriteLine("Compra seleccionada con exito");
                            break;
                        case 2:
                            Console.WriteLine("Compra cancelada con exito");
                            break;
                    }
                switch (opcionesnavhoras)
                {
                    case 1:

                        captura();
                        break;
                    case 2:

                        captura();
                        break;

                }
                Console.ReadKey();
                 

            }
        }

    }

    public class opchatyredesseleccionado : Compras
    {
        static public int opcioneschatyredes;


        public void opcionchatyredes()
        {
            Console.Clear();
            Console.WriteLine("1.150 MB 1 dia - chat y redes 40");
            Console.WriteLine("2.300 MB 7 dias - chat y redes 75");
            Console.WriteLine("3.1GB 15 dias - chat y redes 250");
            Console.WriteLine("Seleccione una opcion");
            opcioneschatyredes = int.Parse(Console.ReadLine());

            
             
       
            
           

        if (opcioneschatyredes == 1)
            {
                Console.Clear();
                    Console.WriteLine("Estas seguro de comprarlo?");
                    Console.WriteLine("1.Si");
                    Console.WriteLine("2.No");

                    opcioneschatyredes = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (opcioneschatyredes)
                    {
                        case 1:
                            Console.WriteLine("Compra seleccionada con exito");
                            break;
                        case 2:
                            Console.WriteLine("Compra cancelada con exito");
                            break;
                    }
                switch (opcioneschatyredes)
                {
                    case 1:

                        captura();
                        break;
                    case 2:

                        captura();
                        break;

                }
                Console.ReadKey();
                 
            }
           


            else if (opcioneschatyredes == 2)
            {
                Console.Clear();
                    Console.WriteLine("Estas seguro de comprarlo?");
                    Console.WriteLine("1.Si");
                    Console.WriteLine("2.No");

                    opcioneschatyredes = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (opcioneschatyredes)
                    {
                        case 1:
                            Console.WriteLine("Compra seleccionada con exito");
                            break;
                        case 2:
                            Console.WriteLine("Compra cancelada con exito");
                            break;
                    }
                switch (opcioneschatyredes)
                {
                    case 1:

                        captura();
                        break;
                    case 2:

                        captura();
                        break;

                }
                Console.ReadKey();
                 

            }
            else if (opcioneschatyredes == 3)
            {
                Console.Clear();
                    Console.WriteLine("Estas seguro de comprarlo?");
                    Console.WriteLine("1.Si");
                    Console.WriteLine("2.No");

                    opcioneschatyredes = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (opcioneschatyredes)
                    {
                        case 1:
                            Console.WriteLine("Compra seleccionada con exito");
                            break;
                        case 2:
                            Console.WriteLine("Compra cancelada con exito");
                            break;
                    }
                switch (opcioneschatyredes)
                {
                    case 1:

                        captura();
                        break;
                    case 2:

                        captura();
                        break;

                }
                Console.ReadKey();
                 

            }
             
             
        }


    }

    public class opadelantapaquetesseleccionado : Compras
    {
        static public int opcionesadelantapaquetes;


        public void opcionadelantapaquetes()
        {
            Console.Clear();
            Console.WriteLine("NO HAY PAQUETES DE ESTE TIPO DISPONIBLE PARA LA VENTA EN ESTOS MOMENTOS");
            Console.WriteLine("Presione la tecla 1 para retornar al menu");
            opcionesadelantapaquetes = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcionesadelantapaquetes)
            {
                case 1:
                    captura();
                    break;
            }
        }

    }

    public class Consultas : telefoniaclaro
    {
        static public int opcionesconsultas;
        public void opcionConsultas()
        {
            Console.Clear();
            Console.WriteLine("1.internet individual");
            Console.WriteLine("2.internet compartido");
            Console.WriteLine("Seleccione una opcion");
            opcionesconsultas = int.Parse(Console.ReadLine());

            switch (opcionesconsultas)
            {
                case 1:
                    {
                        opinternetindividualseleccionado opinternetindividual = new opinternetindividualseleccionado();
                        opinternetindividual.opcioninternetindividual();
                        break;
                    }

                case 2:
                    {
                        opinternetcompartidoseleccionado opinternetcompartido = new opinternetcompartidoseleccionado();
                        opinternetcompartido.opcioninternetcompartido();
                        break;
                    }
            }
        }
    }








    public class opinternetindividualseleccionado : Consultas
    {
        static public int opcionesinternetindividual;

        public void opcioninternetindividual()
        {
            Console.Clear();
            Console.WriteLine("Tienes un paquete activado");
           
            Console.WriteLine("Presione 1 para volver al Menú Principal");
            
            opcionesinternetindividual = int.Parse(Console.ReadLine());
            Console.Clear();
            captura();
           
        }

    }

    public class opinternetcompartidoseleccionado : Consultas
    {
        static public int opcionesinternetcompartido;

        public void opcioninternetcompartido()
        {
            Console.Clear();
            Console.WriteLine("No tiene paquete de datos para esta categoria");
           
            Console.WriteLine("Presione 1 para volver al Menú Principal");
            
            
            opcionesinternetcompartido = int.Parse(Console.ReadLine());
            Console.Clear();
            captura();
           
        }

    }

    public class Regala : telefoniaclaro
    {
        static public int opcionesregala;

        public void opcionregala()
        {
            Console.Clear();
            Console.WriteLine("Digite el número de recarga:");

            opcionesregala = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Recarga realizada con éxito");
            Console.WriteLine("Presione la tecla 1 para retornar al menú principal");

            int opcionRetorno = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcionRetorno)
            {
                case 1:
                    captura();
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }


    public class Navegacionlibre : telefoniaclaro
    {
        static public int opcionesnavegacionlibre;
        public void opcionnavegacionlibre()
        {
            Console.Clear();
            Console.WriteLine("1.Tipo de Cliente");
            Console.WriteLine("Seleccione una opcion");
            opcionesnavegacionlibre = int.Parse(Console.ReadLine());
            
            switch (opcionesnavegacionlibre)
            {
                case 1:
                    optipodeclienteseleccionado optipodecliente = new optipodeclienteseleccionado();
                optipodecliente.opcionestipodecliente();
                    break;
            }
        }
    }

   public class optipodeclienteseleccionado : Navegacionlibre
    {
        static public int opcionestipocliente;

        public void opcionestipodecliente()
        {
            Console.Clear();
            Console.WriteLine("1.postpago");
            Console.WriteLine("2.prepago/control");

            Console.WriteLine("Seleccione una opcion");
            opcionestipocliente = int.Parse(Console.ReadLine());
           
            switch (opcionestipocliente) 
            {
                case 1:
                    oppostpagoseleccionado oppostpago = new oppostpagoseleccionado();
                    oppostpago.opcionespostpago();
                    break;
                case 2:
                    opprepagoseleccionado opprepago = new opprepagoseleccionado();
                    opprepago.opcionesprepago();
                    break;
            }


        }
    }

    public class oppostpagoseleccionado : optipodeclienteseleccionado
    {
        static public int opcionpostpago;

        public void opcionespostpago()
        {
            Console.Clear();
            Console.WriteLine("1.Activar");
            Console.WriteLine("2.Cancelar");
            Console.WriteLine("3.Consulta");
            Console.WriteLine("4.Informacion");

            Console.WriteLine("Seleccione una opcion");
            opcionpostpago = int.Parse(Console.ReadLine());
            switch (opcionpostpago) 
            {
                case 1:
                    opactivarseleccionado1 opactivar1 = new opactivarseleccionado1();
                    opactivar1.opcionactivar1();
                    break;

                case 2:
                    opcancelarseleccionado1 opcancelar1 = new opcancelarseleccionado1();
                    opcancelar1.opcioncancelar1();
                    break;
                case 3:
                    opconsultaseleccionado1 opconsulta1 = new opconsultaseleccionado1();
                    opconsulta1.opcionconsulta1();
                    break;
                case 4:
                    opinformacionseleccionado1 opinformacion1 = new opinformacionseleccionado1();
                    opinformacion1.opcioninformacion1();
                    break;
            }

        }

    }


    public class opactivarseleccionado1 : oppostpagoseleccionado
    {
        static public int opcionactivardepostpago;


        public void opcionactivar1()
        {
            Console.Clear();
            Console.WriteLine("opcion postpago activado con exito");
            Console.WriteLine("presione 1 para retornar al menu");
            opcionactivardepostpago = int.Parse(Console.ReadLine());
            Console.Clear();
            captura();
        }
    }

    public class opcancelarseleccionado1 : oppostpagoseleccionado
    {
        static public int opcioncancelardepostpago;

        public void opcioncancelar1()
        {
            Console.Clear();

            Console.WriteLine("1. Confirmar cancelación");
            Console.WriteLine("2. No cancelar");
            Console.WriteLine("Seleccione una opción:");

            opcioncancelardepostpago = int.Parse(Console.ReadLine());

            switch (opcioncancelardepostpago)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Cancelado con éxito");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Operación realizada con éxito");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opción no válida");
                    break;
            }

            // Check the chosen option and return to the main menu accordingly
            if (opcioncancelardepostpago == 1 || opcioncancelardepostpago == 2)
            {
                captura();
            }

            Console.ReadKey();
        }
    }

    public class opconsultaseleccionado1 : oppostpagoseleccionado
    {
        static public int opcionconsultasdepostpago;


        public void opcionconsulta1()
        {
            Console.Clear();
            Console.WriteLine("No hay granel configurado para este cliente, no se puede continuar. Gracias por prefererirnos. CLARO!!");
            Console.WriteLine("presione 1 para retornar al menu");
            opcionconsultasdepostpago = int.Parse(Console.ReadLine());
            Console.Clear();
            captura();
        }
    }

    public class opinformacionseleccionado1 : oppostpagoseleccionado
    {
        static public int opcioninformaciondepostpago;


        public void opcioninformacion1()
        {
            Console.Clear();
            Console.WriteLine("No hay granel configurado para este cliente, no se puede continuar. Gracias por prefererirnos. CLARO!!");
            Console.WriteLine("presione 1 para retornar al menu");
            opcioninformaciondepostpago = int.Parse(Console.ReadLine());
            Console.Clear();
            captura();

        }
    }






    public class opprepagoseleccionado : optipodeclienteseleccionado
    {
        static public int opcionprepago;


        public void opcionesprepago()
        {
            Console.Clear();
            Console.WriteLine("1.Activar");
            Console.WriteLine("2.Cancelar");
            Console.WriteLine("3.Consulta");
            Console.WriteLine("4.Informacion");
            Console.WriteLine("Seleccione una opcion");
            opcionprepago = int.Parse(Console.ReadLine());
          
            switch (opcionprepago)
            {
                case 1:
                    opactivarseleccionado2 opactivar2 = new opactivarseleccionado2();
                    opactivar2.opcionactivar2();
                    break;

                case 2:
                    opcancelarseleccionado2 opcancelar2 = new opcancelarseleccionado2();
                    opcancelar2.opcioncancelar2();
                    break;
                case 3:
                    opconsultaseleccionado2 opconsulta2 = new opconsultaseleccionado2();
                    opconsulta2.opcionconsulta2();
                    break;
                case 4:
                    opinformacionseleccionado2 opinformacion2 = new opinformacionseleccionado2();
                    opinformacion2.opcioninformacion2();
                    break;
            }

        }
    }

    public class opactivarseleccionado2 : opprepagoseleccionado
    {
        static public int opcionactivardeprepago;


        public void opcionactivar2()
        {
            Console.Clear();
            Console.WriteLine("opcion prepago activado con exito");
            Console.WriteLine("presione 1 para retornar al menu");
            opcionactivardeprepago = int.Parse(Console.ReadLine());
            Console.Clear();
            captura();
        }

    }
    /*opcioncancelardeprepago*/
    public class opcancelarseleccionado2 : opprepagoseleccionado
    {
        static public int opcioncancelardeprepago;

        public void opcioncancelar2()
        {
            Console.Clear();

            Console.WriteLine("1. Confirmar cancelación");
            Console.WriteLine("2. No cancelar");
            Console.WriteLine("Seleccione una opción:");

            opcioncancelardeprepago = int.Parse(Console.ReadLine());

            switch (opcioncancelardeprepago)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Cancelado con éxito");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Operación realizada con éxito");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opción no válida");
                    break;
            }

            // Check the chosen option and return to the main menu accordingly
            if (opcioncancelardeprepago == 1 || opcioncancelardeprepago == 2)
            {
                captura();
            }

            Console.ReadKey();
        }
    }



    public class opconsultaseleccionado2 : opprepagoseleccionado
    {
        static public int opcionconsultardeprepago;


        public void opcionconsulta2()
        {
            Console.Clear();
            Console.WriteLine("No hay granel configurado para este cliente, no se puede continuar. Gracias por prefererirnos. CLARO!!");
            Console.WriteLine("presione 1 para retornar al menu");
            opcionconsultardeprepago = int.Parse(Console.ReadLine());
            Console.Clear();
            captura();
        }
    }


    public class opinformacionseleccionado2 : opprepagoseleccionado
    {
        static public int opcioninformaciondeprepago;


        public void opcioninformacion2()
        {
            Console.Clear();
            Console.WriteLine("No hay granel configurado para este cliente, no se puede continuar. Gracias por prefererirnos. CLARO!!");
            Console.WriteLine("presione 1 para retornar al menu");
            opcioninformaciondeprepago = int.Parse(Console.ReadLine());
            Console.Clear();
            captura();
        }
    }

    public class comparte : telefoniaclaro
    {
        static public int opcionescomparte;
        public void opcioncomparte()
        {
            Console.Clear();
            Console.WriteLine("1.Agregar");
            Console.WriteLine("2.Remover");
            Console.WriteLine("Seleccione una opcion");
            opcionescomparte = int.Parse(Console.ReadLine());

            switch (opcionescomparte) 
            {
                case 1:
                    opagregarseleccionado opagregar = new opagregarseleccionado();
                    opagregar.opcionagregar();
                    
                    break;

                case 2:
                    opremoverseleccionado opremover = new opremoverseleccionado();
                    opremover.opcionremover();
                    break;
                case 3:
                    // Return to the main menu
                    captura();
                    break;
            }
        }
    }

    
    public class opagregarseleccionado : comparte
    {
        static public int opcionesagregar;

        public void opcionagregar()
        {
            Console.Clear();
            Console.WriteLine("Digite el número que desea agregar:");
            opcionesagregar = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"Número {opcionesagregar} agregado con éxito");

            Console.WriteLine("Presione 1 para volver al Menú Principal");
            int opcionRetorno = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcionRetorno)
            {
                case 1:
                    captura();
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }

    public class opremoverseleccionado : comparte
    {
        static public int opcionesremover;

        public void opcionremover()
        {
            Console.Clear();
            Console.WriteLine("Esta linea no tiene numeros asociados que remover");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Presione la tecla 1 para retornar a menu principal");
            
            opcionesremover = int.Parse(Console.ReadLine());
            switch (opcionesremover)
            {
                case 1:
                    Console.Clear();
                    captura();
                    break;
            }

        }
    }

    public class roaming : telefoniaclaro
    {
        static public int opcionesroaming;
        public void opcionroaming()
        {
            Console.Clear();
            Console.WriteLine("1.america y caribe");
            Console.WriteLine("2.resto del caribe");
            Console.WriteLine("3.europa");

            Console.WriteLine("Seleccione la opcion deseada:");
            opcionesroaming = int.Parse(Console.ReadLine());

            switch (opcionesroaming) 
            {
                case 1:
                    americaycaribe1seleccionado opamericaycaribe1 = new americaycaribe1seleccionado();
                    opamericaycaribe1.opcionamericaycaribe1();
                    break;

                case 2:
                    restodelcaribeseleccionado oprestodelcaribe = new restodelcaribeseleccionado();
                    oprestodelcaribe.opcionrestodelcaribe();
                    break;
                case 3:
                    europaseleccionado opeuropa = new europaseleccionado();
                    opeuropa.opcioneuropa();
                    break;



            }
        }
    }

    public class americaycaribe1seleccionado : roaming
    {
        static public int opcionesamericaycaribe;

        public void opcionamericaycaribe1()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. 250 MB AMERICA Y CARIBE 325");
                Console.WriteLine("2. 500 MB AMERICA Y CARIBE 520");
                Console.WriteLine("3. 1GB AMERICA Y CARIBE 910");
                Console.WriteLine("4. 3GB AMERICA Y CARIBE 2340");
                Console.WriteLine("5. 5GB AMERICA Y CARIBE 3705");
                Console.WriteLine("6. Volver al Menú Principal");
                Console.WriteLine("\nSelecciona una opción:");

                opcionesamericaycaribe = int.Parse(Console.ReadLine());

                switch (opcionesamericaycaribe)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Has seleccionado paquete roaming de 250MB AMERICA Y CARIBE 325");
                        Console.WriteLine("presione cualquier tecla para retornar al menu roaming");
                        // Logic for sub-option 1
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Has seleccionado el paquete roaming de 500 MB AMERICA Y CARIBE 520");
                        Console.WriteLine("presione cualquier tecla para retornar al menu roaming");
                        // Logic for sub-option 2
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Has seleccionado el paquete roaming de 1GB AMERICA Y CARIBE 910");
                        Console.WriteLine("presione cualquier tecla para retornar al menu roaming");
                        // Logic for sub-option 3
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Has seleccionado el paquete roaming de 3GB AMERICA Y CARIBE 2340");
                        Console.WriteLine("presione cualquier tecla para retornar al menu roaming");
                        // Logic for sub-option 4
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Has seleccionado el paquete roaming de 5GB AMERICA Y CARIBE 3705");
                        Console.WriteLine("presione cualquier tecla para retornar al menu roaming");
                        // Logic for sub-option 5
                        Console.ReadKey();
                        break;
                    case 6:
                        // Exit the loop and return to the main menu
                        Console.Clear();
                        captura();
                        return;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opción no válida");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }








    public class restodelcaribeseleccionado : roaming
    {
        static public int opcionesrestodelcaribe;

        public void opcionrestodelcaribe()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. 100MB Roaming Caribe 975");
                Console.WriteLine("2. 250MB Roaming Caribe 2275");
                Console.WriteLine("3. 500MB Roaming Caribe 4420");
                Console.WriteLine("4. 1GB Roaming Caribe 8580");
                Console.WriteLine("6. Volver al Menú Principal");
                Console.WriteLine("Seleccione la opcion deseada");

                opcionesrestodelcaribe = int.Parse(Console.ReadLine());

                switch (opcionesrestodelcaribe)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Has seleccionado paquete roaming de resto del Caribe 975");
                        Console.WriteLine("presione cualquier tecla para retornar al menu roaming");
                        // Logic for sub-option 1
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Has seleccionado el paquete roaming de resto del Caribe 2275");
                        Console.WriteLine("presione cualquier tecla para retornar al menu roaming");
                        // Logic for sub-option 2
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Has seleccionado el paquete roaming de resto del Caribe 4420");
                        Console.WriteLine("presione cualquier tecla para retornar al menu roaming");
                        // Logic for sub-option 3
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Has seleccionado el paquete roaming de resto del Caribe 8580");
                        Console.WriteLine("presione cualquier tecla para retornar al menu roaming");
                        // Logic for sub-option 4
                        Console.ReadKey();
                        break;
                    case 5:
                        // Exit the loop and return to the main menu
                        return;
                    case 6:
                        // Return to the main menu
                        Console.Clear();
                        captura();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opción no válida");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }


    public class europaseleccionado : roaming
    {
        static public int opcioneseuropa;

        public void opcioneuropa()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. 250MB Roaming Europa 715\r\n");
                Console.WriteLine("2. 500MB Roaming Europa 1300\r\n");
                Console.WriteLine("3. 1GB Roaming Europa 2405\r\n");
                Console.WriteLine("4. 3GB Roaming Europa 6995\r\n");
                Console.WriteLine("5. 5GB Roaming Europa 11050");
                Console.WriteLine("6. Volver al Menú Principal");
                Console.WriteLine("Seleccione una opcion:");
                opcioneseuropa = int.Parse(Console.ReadLine());

                switch (opcioneseuropa)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Has seleccionado paquete roaming de 250MB AMERICA Y CARIBE ");
                        Console.WriteLine("presione cualquier tecla para retornar al menu roaming");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Has seleccionado el paquete roaming de 500 MB AMERICA Y CARIBE  520");
                        Console.WriteLine("presione cualquier tecla para retornar al menu roaming");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Has seleccionado el paquete roaming de 1GB AMERICA Y CARIBE  910");
                        Console.WriteLine("presione cualquier tecla para retornar al menu roaming");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Has seleccionado el paquete roaming de 3GB AMERICA Y CARIBE 2340");
                        Console.WriteLine("presione cualquier tecla para retornar al menu roaming");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Has seleccionado el paquete roaming de 5GB AMERICA Y CARIBE 3705");
                        Console.WriteLine("presione cualquier tecla para retornar al menu roaming");
                        Console.ReadKey();
                        break;
                    case 6:
                        // Return to the main menu
                        Console.Clear();
                        captura();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opción no válida");
                        Console.ReadKey();
                        break;
                     
                }
            }
        }
    }


    public class internetinalambricofijo : telefoniaclaro
    {
        static public int opcionesinternetinalambricofijo;

        public void opcioninternetinalambricofijo()
        {
            Console.Clear();
            Console.WriteLine("Digita tu numero de recarga:");

            opcionesinternetinalambricofijo = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Estás seguro de recargarlo?");
            Console.WriteLine("1. Sí");
            Console.WriteLine("2. No");

            int confirmacionRecarga = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (confirmacionRecarga)
            {
                case 1:
                    Console.WriteLine("Recargaste tu internet inalámbrico con éxito");
                    break;
                case 2:
                    Console.WriteLine("Cancelaste la recarga con éxito");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }

            // Return to the main menu
            captura();
        }
    }
}