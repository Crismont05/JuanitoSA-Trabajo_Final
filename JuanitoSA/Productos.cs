using InventarioAPI.Models.ProductoDto;
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
                        var students = await response.Content.ReadAsStringAsync();
                        var displaydata = JsonConvert.DeserializeObject<List<ProductoDto>>(students);
                        dgvProductos.DataSource = displaydata.ToList();
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de estudiantes: {response.StatusCode}");
                    }
                }
            }
        }

    }
}
