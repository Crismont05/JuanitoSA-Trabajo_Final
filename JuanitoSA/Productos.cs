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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            GetallProducts();
        }

        private async void GetallProducts()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7220/api/Producto"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var productos = await response.Content.ReadAsStringAsync();
                        var displaydata = JsonConvert.DeserializeObject<List<ProductoDto>>(productos);
                        dgvProductos.DataSource = displaydata.ToList();
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de Productos: {response.StatusCode}");
                    }
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AddProducto();
        }

        public async void AddProducto()
        {
            CreateProductoDto oproduct = new CreateProductoDto();
            oproduct.Nombre = txtNombre.Text;
            oproduct.Precio = Convert.ToDecimal(txtPrecio.Text);
            oproduct.Existencia = Convert.ToInt32(txtexistencia.Text);
            oproduct.Id_Proveedor = Convert.ToInt32(txtIdProveedor.Text);
            oproduct.Costo = Convert.ToDecimal(txtCosto.Text);
            using (var client = new HttpClient())
            {
                var serializedStudent = JsonConvert.SerializeObject(oproduct);
                var content = new StringContent(serializedStudent, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7220/api/Producto", content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Producto agregado");
                else
                    MessageBox.Show($"Error al guardar el producto: {response.Content.ReadAsStringAsync().Result}");
            }

            GetallProducts();
        }
    }
}
