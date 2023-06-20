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
using System.Text.RegularExpressions;
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
        private async void EjecutarVenta()
        {
            int id = Convert.ToInt32(txtID.Text);
            products.Clear();
            using (var client = new HttpClient())
            {
                var response1 = await client.GetAsync("https://localhost:7220/api/Producto");
                if (response1.IsSuccessStatusCode)
                {
                    var productos = await response1.Content.ReadAsStringAsync();
                    products = JsonConvert.DeserializeObject<List<ProductoDto>>(productos);
                }
                else
                {
                    MessageBox.Show($"No se puede obtener la lista de los Proveedores: {response1.StatusCode}");
                }
                foreach (ProductoDto p in products)
                {
                    if (p.Id == id)
                    {
                        productDto.Id = p.Id;
                        productDto.Nombre = p.Nombre;
                        productDto.Id_Proveedor = p.Id_Proveedor;
                        productDto.Costo = p.Costo;
                        productDto.Precio = p.Precio;
                        productDto.Existencia = p.Existencia;
                    }
                }
                if (Regex.IsMatch(txtCantidad.Text, "^[0-9]") && Regex.IsMatch(txtID.Text, "^[0-9]"))
                    venta = new Venta(productDto.Id, productDto.Nombre, productDto.Id_Proveedor, productDto.Costo, productDto.Precio, Convert.ToInt32(txtCantidad.Text), 0, dtpFecha.Value);
                else
                {
                    limpiar();
                    MessageBox.Show("Debe agregar un número mayor que 0 como cantidad a ocupar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Agregar(venta);
                dgvVentas.DataSource = ventas;
                limpiar();
                lblMontoVendido.Text = venta.TotalVentas(ventas).ToString();
            }
        }
        private async void EjecutarCompra()
        {
            int id = Convert.ToInt32(txtID.Text);
            products.Clear();
            using (var client = new HttpClient())
            {
                var response1 = await client.GetAsync("https://localhost:7220/api/Producto");
                if (response1.IsSuccessStatusCode)
                {
                    var productos = await response1.Content.ReadAsStringAsync();
                    products = JsonConvert.DeserializeObject<List<ProductoDto>>(productos);
                }
                else
                {
                    MessageBox.Show($"No se puede obtener la lista de los Proveedores: {response1.StatusCode}");
                }
                foreach (ProductoDto p in products)
                {
                    if (p.Id == id)
                    {
                        productDto.Id = p.Id;
                        productDto.Nombre = p.Nombre;
                        productDto.Id_Proveedor = p.Id_Proveedor;
                        productDto.Costo = p.Costo;
                        productDto.Precio = p.Precio;
                        productDto.Existencia = p.Existencia;
                    }
                }
                if (Regex.IsMatch(txtCantidad.Text, "^[0-9]") && Regex.IsMatch(txtID.Text, "^[0-9]"))
                    venta = new Venta(productDto.Id, productDto.Nombre, productDto.Id_Proveedor, productDto.Costo, productDto.Precio, 0, Convert.ToInt32(txtCantidad.Text), dtpFecha.Value);
                else
                {
                    limpiar();
                    MessageBox.Show("Ingrese valores numéricos mayores que 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Agregar(venta);
                dgvVentas.DataSource = null;
                dgvVentas.DataSource = ventas;
                limpiar();
                lblMontoPagado.Text = venta.TotalCompras(ventas).ToString();
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" || txtCantidad.Text != "")
            {
                if (Regex.IsMatch(txtID.Text, "^[0-9]") && Regex.IsMatch(txtCantidad.Text, "^[0-9]"))
                {
                    btnEliminar.Enabled = true;
                    btnSell.Enabled = true;
                    EjecutarVenta();
                }
                else
                {
                    limpiar();
                    MessageBox.Show("Ingrese valores numéricos mayores que 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
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
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" || txtCantidad.Text != "")
            {
                if (Regex.IsMatch(txtID.Text, "^[0-9]") && Regex.IsMatch(txtCantidad.Text, "^[0-9]"))
                {
                    btnEliminar.Enabled = true;
                    btnSell.Enabled = true;
                    EjecutarCompra();
                }
                else
                {
                    limpiar();
                    MessageBox.Show("Ingrese valores numéricos mayores que 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void GetVentaById(int id)
        {
            foreach (var v in ventas)
            {
                if (v.Id == id)
                {
                    txtID.Text = v.Id.ToString();
                    txtCantidad.Text = (v.Entrada - v.Salida).ToString();
                    dtpFecha.Value = v.Fecha;
                }
            }
        }
    }
}
