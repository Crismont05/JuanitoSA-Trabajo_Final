using InventarioAPI.Models.ProductoDto;
using InventarioAPI.Models.ProveedorDto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
            AddProduct();
        }

        public async void AddProduct()
        {
            try
            {
                if (txtCosto.Text != "" || txtexistencia.Text != "" || txtIdProveedor.Text != "" || txtNombre.Text != "" || txtPrecio.Text != "")
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
                else
                {
                    MessageBox.Show("Debe llenar todos los espacio requeridos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Formato no aceptado","Error de llenado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (id != 0)
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
                    MessageBox.Show("Producto Eliminado con éxito");
                else
                    MessageBox.Show($"El producto no pudo ser eliminado: {response.StatusCode}");
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
                    GetProductById(id);
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            UpdateProduct();
        }

        private async void UpdateProduct()
        {

            if (txtCosto.Text != "" || txtexistencia.Text != "" || txtIdProveedor.Text != "" || txtNombre.Text != "" || txtPrecio.Text != "")
            {
                UpdateProductoDto productoDto = new UpdateProductoDto();
                productoDto.Costo = Convert.ToDecimal(txtCosto.Text);
                productoDto.Nombre = txtNombre.Text;
                productoDto.Existencia = Convert.ToInt32(txtexistencia.Text);
                productoDto.Precio = Convert.ToDecimal(txtPrecio.Text);
                productoDto.Id_Proveedor = Convert.ToInt32(txtIdProveedor.Text);
                productoDto.Id = id;


                using (var client = new HttpClient())
                {
                    var producto = JsonConvert.SerializeObject(productoDto);
                    var content = new StringContent(producto, Encoding.UTF8, "application/json");
                    var response = await client.PutAsync(String.Format("{0}/{1}", "https://localhost:7220/api/Producto", id), content);
                    if (response.IsSuccessStatusCode)
                        MessageBox.Show("Producto actualizado");
                    else
                        MessageBox.Show($"Error al actualizar el producto: {response.StatusCode}");
                }
                clear();
                GetallProducts(); 
            }
            else
            {
                MessageBox.Show("Debe haber  información para actualizar la información del producto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
