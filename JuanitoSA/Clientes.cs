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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }
        private async void GetAllProviders()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7220/api/Proveedor"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var proveedores = await response.Content.ReadAsStringAsync();
                        var displaydata = JsonConvert.DeserializeObject<List<ProveedorDto>>(proveedores);
                        dgvListado.DataSource = displaydata.ToList();
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de los Proveedores: {response.StatusCode}");
                    }
                }
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            GetAllProviders();
        }
    }
}
