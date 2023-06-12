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
        private static int id = 0;
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
            clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(id!=0)
            Deleteproduct(id);
        }

        private async void Deleteproduct(int id)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7220/api/Producto");
                var response = await client.DeleteAsync(String.Format("{0}/{1}",
                    "https://localhost:7220/api/Producto", id));
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Estudiante eliminado con éxito");
                else
                    MessageBox.Show($"No se pudo eliminar el estudiante: {response.StatusCode}");
            }
            clear();
            GetallProducts();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    id = int.Parse(row.Cells[0].Value.ToString());
                    GetStudentById(id);
                }
            }
        }

        private async void GetStudentById(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}", "https://localhost:7220/api/Producto", id));
                if (response.IsSuccessStatusCode)
                {
                    var producto = await response.Content.ReadAsStringAsync();
                    ProductoDto productoDto = JsonConvert.DeserializeObject<ProductoDto>(producto);

                    txtNombre.Text = productoDto.Nombre;
                    txtIdProveedor.Text = productoDto.Id_Proveedor.ToString();
                    txtexistencia.Text = productoDto.Existencia.ToString();
                    txtCosto.Text = productoDto.Costo.ToString();
                    txtPrecio.Text = productoDto.Precio.ToString();
                }
                else
                {
                    MessageBox.Show($"No se puede obtener el producto: {response.StatusCode}");
                }
            }

        }

        private void clear()
        {
            txtPrecio.Text = string.Empty;
            txtCosto.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtexistencia.Text = string.Empty;
            txtIdProveedor.Text = string.Empty;
            id = 0; 
        }
    }
}
