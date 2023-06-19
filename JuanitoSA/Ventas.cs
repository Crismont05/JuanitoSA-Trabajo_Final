using InventarioAPI.Models;
using InventarioAPI.Models.ProductoDto;
using InventarioAPI.Models.ProveedorDto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuanitoSA
{
    public partial class Ventas : Form
    {
        Venta venta = new Venta();
        ProductoDto productDto = new ProductoDto();
        List<ProductoDto> products = new List<ProductoDto>();
        List<Venta> ventas = new List<Venta>();
        int i = 1;
        int id;

        public Ventas()
        {
            InitializeComponent();
        }

        void limpiar()
        { 
            txtID.Text = "";
            txtCantidad.Text = "";
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvVentas.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    id = int.Parse(row.Cells[0].Value.ToString());
                    GetVentaById(id);
                }
            }
        }
        private async void ObtenerProducts()
        {
            products.Clear();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7220/api/Producto"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var productos = await response.Content.ReadAsStringAsync();
                        products = JsonConvert.DeserializeObject<List<ProductoDto>>(productos);
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de los Proveedores: {response.StatusCode}");
                    }
                }
            }
        }
        private async void GetProductById(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}", "https://localhost:7220/api/Producto", id));
                if (response.IsSuccessStatusCode)
                {
                    var producto = await response.Content.ReadAsStringAsync();
                    productDto = JsonConvert.DeserializeObject<ProductoDto>(producto);
                }
                else
                {
                    MessageBox.Show($"No se puede obtener el producto: {response.StatusCode}");
                }
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            GetProductById(int.Parse(txtID.Text));
            venta = new Venta(productDto.Id, productDto.Nombre, productDto.Id_Proveedor, productDto.Costo, productDto.Precio, int.Parse(txtCantidad.Text), 0, dtpFecha.Value);
            Agregar(venta);
            dgvVentas.DataSource = ventas;
            limpiar();
        }
        private void Agregar(Venta venta)
        {
            bool Encontrado = false;
            bool Error = false;
            foreach (var v in ventas)
            {
                if (v.Id == venta.Id)
                {
                    v.Id = venta.Id;
                    v.Nombre = venta.Nombre;
                    v.IdProveedor = venta.IdProveedor;
                    v.Costo = venta.Costo;
                    v.Precio = venta.Precio;
                    if (v.Salida + venta.Salida <= v.Entrada + venta.Entrada)
                    {
                        v.Salida += venta.Salida;
                        v.Entrada += venta.Entrada;
                    }
                    else
                    {
                        MessageBox.Show("Las ventas no pueden ser mayores al inventario del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Error = true;
                    }
                    Encontrado = true;
                }
            }
            if (Encontrado == false && Error == false && venta.Salida <= venta.Entrada)
            {
                ventas.Add(venta);
            }
            else
            {
                MessageBox.Show("Error al agregar la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            btnSell.Enabled = true;
            GetProductById(int.Parse(txtID.Text));
            venta = new Venta(productDto.Id, productDto.Nombre, productDto.Id_Proveedor, productDto.Costo, productDto.Precio, 0, int.Parse(txtCantidad.Text), dtpFecha.Value);
            Agregar(venta);
            dgvVentas.DataSource = ventas;
            limpiar();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            ObtenerProducts();
        }
        private void GetVentaById(int id)
        {
            foreach(var v in ventas)
            {
                if(v.Id == id)
                {
                    txtID.Text = v.Id.ToString();   
                    txtCantidad.Text = (v.Salida - v.Entrada).ToString();
                    dtpFecha.Value = v.Fecha;
                }
            }
        }
    }
}
