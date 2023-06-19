using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanitoSA
{
    public class Venta
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public int IdProveedor { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public int Salida { get; set; }
        public int Entrada { get; set; }
        public DateTime Fecha { get; set; }

        public Venta(int id, string? nombre, int idProveedor, decimal costo, decimal precio, int salida, int entrada, DateTime fecha)
        {
            Id = id;
            Nombre = nombre;
            IdProveedor = idProveedor;
            Costo = costo;
            Precio = precio;
            Salida = salida;
            Entrada = entrada;
            Fecha = fecha;
        }
        public Venta()
        {

        }
        public double TotalVentas(List<Venta> ventas)
        {
            double totalVentas = 0;
            foreach (Venta v in ventas)
            {
                totalVentas = Convert.ToDouble(v.Salida * v.Precio);
            }
            return totalVentas;
        }
        public double TotalCompras(List<Venta> ventas)
        {
            double totalCompras = 0;
            foreach (Venta v in ventas)
            {
                totalCompras = Convert.ToDouble(v.Entrada * v.Costo);
            }
            return totalCompras;
        }
    }
}
