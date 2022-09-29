using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tarea1
{
    internal class Veiculos
    {
        private int numeroFactura = 0;
        private int numeroPlaca = 0;
        private String fecha = "";
        private String hora = "";
        private string tipo = "";

        private String caseta = "";
        private int monto = 0;
        private double pagaCon = 0.0;
        private double vuelto = 0.0;




        public int getnumeroFactura()
        {
            return numeroFactura;
        }
        public void setnumeroFactura(int numeroFactura)
        {
            this.numeroFactura = numeroFactura;
        }
        public int getnumeroPlaca()
        {
            return numeroPlaca;
        }
        public void setnumeroPlaca(int numeroPlaca)
        {
            this.numeroPlaca = numeroPlaca;
        }
        public String getfecha()
        {
            return fecha;
        }
        public void setfecha(String fecha)
        {
            this.fecha = fecha;
        }
        public String gethora()
        {
            return hora;
        }
        public void sethora(String hora)
        {
            this.hora = hora;
        }
        public string gettipo()
        {
            return tipo;
        }
        public void settipo(string tipo)
        {
            this.tipo = tipo;
        }
        public String getcaseta()
        {
            return caseta;
        }
        public void setcaseta(String caseta)
        {
            this.caseta = caseta;
        }
        public int getmonto()
        {
            return monto;
        }
        public void setmonto(int monto)
        {
            this.monto = monto;
        }
        public double getpagaCon()
        {
            return pagaCon;
        }
        public void setpagaCon(double pagaCon)
        {
            this.pagaCon = pagaCon;
        }
        public double getvuelto()
        {
            return vuelto;
        }
        public void setvuelto(double vuelto)
        {
            this.vuelto = vuelto;
        }




       

        public Veiculos(int numeroFactora, int numeroPlaca, string fecha, string hora,string tipo, string caseta, int monto, double pagaCon, double vuelto)
        {
            this.numeroFactura = numeroFactora;
            this.numeroPlaca = numeroPlaca;
            this.fecha = fecha;
            this.hora = hora;
            this.tipo = tipo;
            this.caseta = caseta;
            this.monto = monto;
            this.pagaCon = pagaCon;
            this.vuelto = vuelto;
        }

        public Veiculos()
        {
            this.tipo = "ND";
            this.numeroFactura = 0;
            this.numeroPlaca = 0;
            this.fecha = "ND";
            this.hora = "ND";
            this.caseta = "ND";
            this.monto = 0;
            this.pagaCon = 0;
            this.vuelto = 0;
        }
        public String toString()
        {
            return "++++ Cliente ++++\n" + " Factura:=" + this.numeroFactura + "\n Placa:=" + this.numeroPlaca + "\n Fecha:=" + fecha +
                "\n Hora:=" + hora + "\n Caseta:=" + caseta + "\n Monto del veiculo:" + tipo + monto + "\n Pago con:" + pagaCon +
                "\n Vuelto:" + vuelto;
        }




    }
}
