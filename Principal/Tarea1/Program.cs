using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace Tarea1

{

    internal class Program
    {

        Veiculos[] peajes = new Veiculos[15];


        int numeroFactora = 1;
        int numeroPlaca = 0;
        String fecha = "";
        String hora = "";
        int contador = 0;
        String caseta = "";
        int monto = 0;
        double pagaCon = 0.0;
        double vuelto = 0.0;


        byte opcion = 0;
        private String opciones1;
        private String opciones2;





        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ 
        public void inicializarVerctores()
        {




        }//fin de Inicializar Vectores
         //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public void ingrasarDatos()
        {
            Veiculos veiculos = new Veiculos();

            if (veiculos != null)
            {
                if (contador < 14)
                {
                    peajes[contador] = veiculos;
                    contador++;



                    do
                    {
                        Console.WriteLine("++++++ Control de Peaje ++++++");

                        Console.WriteLine("Numero de factura:\n" + this.numeroFactora);
                        this.numeroFactora++;
                        veiculos.setnumeroFactura(this.numeroFactora);

                        Console.WriteLine("Numero de placa:");
                        this.numeroPlaca = int.Parse(Console.ReadLine());
                        veiculos.setnumeroPlaca(numeroPlaca);

                        Console.WriteLine("Fecha:");
                        this.fecha = Console.ReadLine();
                        veiculos.setfecha(fecha);


                        Console.WriteLine("Hora:");
                        this.hora = Console.ReadLine();
                        veiculos.sethora(hora);

                        Console.WriteLine("Tipo de veicuolo;\n1-Moto.\n2-Veiculo liviano.\n3-Camion o pesado.\n4-Autobus");
                        opciones1 = Console.ReadLine();
                        switch (opciones1)
                        {
                            case "1":
                                veiculos.settipo("moto ");
                                this.monto = 500;
                                veiculos.setmonto(monto);
                                break;

                            case "2":
                                veiculos.settipo("Veiculo liviano ");
                                this.monto = 700;
                                veiculos.setmonto(monto);

                                break;

                            case "3":
                                veiculos.settipo("Camion o pesado ");
                                this.monto = 2700;
                                veiculos.setmonto(monto);
                                break;

                            case "4":
                                veiculos.settipo("Autobus ");
                                this.monto = 3700;
                                veiculos.setmonto(monto);
                                break;
                        }

                        Console.WriteLine("Numero de caseta:\n1-Caseta1.\n2-Caseta2.\n3.Caseta3");
                        this.opciones2 = Console.ReadLine();
                        switch (opciones2)
                        {
                            case "1":
                                veiculos.setcaseta("Caseta1");
                                break;

                            case "2":
                                veiculos.setcaseta("Caseta2");
                                break;

                            case "3":
                                veiculos.setcaseta("Caseta3");
                                break;
                        }

                        Console.WriteLine("Monto a Pagar:" + this.monto);

                        Console.WriteLine("Paga con:");
                        this.pagaCon = double.Parse(Console.ReadLine());
                        veiculos.setpagaCon(pagaCon);


                        if (this.pagaCon > this.monto)
                        {
                            this.vuelto = this.pagaCon - this.monto;
                            Console.WriteLine("Su vuelto es:" + this.vuelto);
                            // veiculos.setvuelto(veiculos.getvuelto());
                            veiculos.setvuelto(vuelto);
                        }
                        else
                        {
                            if (this.pagaCon < this.monto)
                            {
                                this.vuelto = this.monto - this.pagaCon;
                                Console.WriteLine("Faltan " + this.vuelto + " para poder cancelar el peaje o por lo tanto no puedes pasar," +
                                    " de la vuelta en U para que le hagan un parte XD..");
                                veiculos.setvuelto(-vuelto);
                            }
                            else
                            {
                                if (this.pagaCon == this.monto)
                                {
                                    this.vuelto = 0;
                                    Console.WriteLine("Gracias por cancelar completo");
                                    veiculos.setvuelto(monto);
                                }
                            }
                        }


                        Console.WriteLine("Desea  \n1-continuar\n2-salir");
                        opcion = byte.Parse(Console.ReadLine());

                    } while (opcion != 2);

                }

                else
                {
                    Console.WriteLine("++++++ El vector se encuentra lleno ++++++");
                }
            }

        }//fin de Ingresar Datos
         //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public int consultarNumeros(String numeroPlaca) {
           
            /*int numero;
            Console.WriteLine("Digite el numero de placa:");
            numero = int.Parse(Console.ReadLine());*/
            for (int i = 0; i < peajes.Length; i++) {
                if (peajes[i] != null) {
                    if (peajes[i].getnumeroPlaca().Equals(numeroPlaca))
                    {
                        return i;

                    }
                }

            }
            return -1;
        }//fin de la consulta
         //



        public Veiculos consultar(String numeroPlaca )
        {
         
            Console.WriteLine("Digite el numero de placa");
            int numero = int.Parse(Console.ReadLine());
            numero = consultarNumeros(numeroPlaca);
            if (numero != -1)
            {
                return peajes[numero];
            }
            return null;
        }
   
        public void consultarPlaca()
        {
            Veiculos veiculos = new Veiculos();

           
           //veiculos = consultar(veiculos.getnumeroPlaca);
            if (veiculos != null)
            {
                veiculos.setnumeroFactura(veiculos.getnumeroFactura());
                veiculos.setnumeroPlaca(veiculos.getnumeroPlaca());
                veiculos.setfecha(veiculos.getfecha());
                veiculos.sethora(veiculos.gethora());
                veiculos.setcaseta(veiculos.getcaseta());
                veiculos.settipo(veiculos.gettipo());
                veiculos.setmonto(veiculos.getmonto());
                veiculos.setvuelto(veiculos.getvuelto());
            }
         
            
        
        


    }



        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /*public void modificar() {
            Veiculos veiculos = new Veiculos();

            if (veiculos != null)
            {
                int numero = consultar(veiculos.getnumeroPlaca());
                if (numero != -1)
                {
                    peajes[numero].setfecha(veiculos.getfecha());
                    peajes[numero].sethora (veiculos.gethora());
                    peajes[numero].setcaseta(veiculos.getcaseta());
                    peajes[numero].settipo(veiculos.gettipo());
                    peajes[numero].setmonto(veiculos.getmonto());
                    peajes[numero].setvuelto(veiculos.getvuelto());


                
                    }
                }
            
        }*/

        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public string reporte() {

            
            string mensaje1 = "";
            for (int i = 0; i < 15; i++)
            {
                
                if (peajes[i] != null)
                {
                    mensaje1 += peajes[i].toString() + "\n";
                }
                Console.WriteLine("vector [" + i + "]\n" + mensaje1);
            }
            return mensaje1;
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    }

}





          
        }
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++