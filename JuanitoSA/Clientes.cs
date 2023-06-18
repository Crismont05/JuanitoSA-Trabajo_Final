using InventarioAPI.Models;
using InventarioAPI.Models.ProductoDto;
using InventarioAPI.Models.ProveedorDto;
using Microsoft.AspNetCore.Antiforgery;
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
        private static int id = 0;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AddProvider();
        }

        private async void AddProvider()
        {
            if (txtNombre.Text != "" || txtApellido.Text != "" || txtIDProvider.Text != "" || txtDireccion.Text != "" || txtNumero.Text != "" || txtNacionalidad.Text != "")
            {
                CreateProveedorDto provider = new CreateProveedorDto();
                provider.Nombre = txtNombre.Text;
                provider.Apellido = txtApellido.Text;
                provider.Id = int.Parse(txtIDProvider.Text);
                provider.Direccion = txtDireccion.Text;
                if (rbMasculino.Checked == true)
                {
                    provider.Sexo = 'm';
                }
                else
                {
                    provider.Sexo = 'f';
                }
                provider.Nacionalidad = txtNacionalidad.Text;
                provider.Nacimiento = dtpBirthDate.Value;
                provider.Telefono = txtNumero.Text;
                using (var client = new HttpClient())
                {
                    var serializerProvider = JsonConvert.SerializeObject(provider);
                    var content = new StringContent(serializerProvider, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("https://localhost:7220/api/Proveedor", content);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Proveedor agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetAllProviders();
                    }
                    else
                        MessageBox.Show($"Error al guardar el proveedor: {response.Content.ReadAsStringAsync().Result}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Debe rellenar todos los campos antes de agregar un proveedor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Clear()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtIDProvider.Clear();
            txtNumero.Clear();
            id = 0;
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvListado.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    id = int.Parse(row.Cells[0].Value.ToString());
                    GetProviderByID(id);
                }
            }
        }

        private async void GetProviderByID(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}", "https://localhost:7220/api/Proveedor", id));
                if (response.IsSuccessStatusCode)
                {
                    var proveedor = await response.Content.ReadAsStringAsync();
                    ProveedorDto provider = JsonConvert.DeserializeObject<ProveedorDto>(proveedor);
                    txtNombre.Text = provider.Nombre;
                    txtApellido.Text = provider.Apellido;
                    txtIDProvider.Text = provider.Id.ToString();
                    txtDireccion.Text = provider.Direccion;
                    txtNumero.Text = provider.Telefono;
                    txtNacionalidad.Text = provider.Nacionalidad;
                    if (provider.Sexo == 'm')
                    {
                        rbMasculino.Checked = true;
                        rbFemenino.Checked = false;
                    }
                    else
                    {
                        rbFemenino.Checked = true;
                        rbMasculino.Checked = false;
                    }
                    dtpBirthDate.Value = provider.Nacimiento;
                }
                else
                    MessageBox.Show($"No se puede obtener el proveedor: {response.StatusCode}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private async void Deleteprovider(int id)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7220/api/Proveedor");
                var response = await client.DeleteAsync(String.Format("{0}/{1}",
                    "https://localhost:7220/api/Proveedor", id));
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Proveedor Eliminado con éxito");
                else
                    MessageBox.Show($"El proveedor no pudo ser eliminado: {response.StatusCode}");
            }
            Clear();
            GetAllProviders();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Deleteprovider(id);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProvider();
        }

        private async void UpdateProvider()
        {
            if(txtNombre.Text != "" || txtApellido.Text != "" || txtIDProvider.Text != "" || txtDireccion.Text != "" || txtNacionalidad.Text != "" || txtNumero.Text != "")
            {
                UpdateProveedorDto provider = new UpdateProveedorDto();
                provider.Nombre = txtNombre.Text;
                provider.Apellido = txtApellido.Text;
                provider.Id = int.Parse(txtIDProvider.Text);
                provider.Direccion = txtDireccion.Text;
                if (rbMasculino.Checked == true)
                {
                    provider.Sexo = 'm';
                }
                else
                {
                    provider.Sexo = 'f';
                }
                provider.Nacionalidad = txtNacionalidad.Text;
                provider.Nacimiento = dtpBirthDate.Value;
                provider.Telefono = txtNumero.Text;
                using (var client = new HttpClient())
                {
                    var Proveedor = JsonConvert.SerializeObject(provider);
                    var content = new StringContent(Proveedor, Encoding.UTF8, "application/json");
                    var response = await client.PutAsync(String.Format("{0}/{1}", "https://localhost:7220/api/Proveedor", id), content);
                    if (response.IsSuccessStatusCode)
                        MessageBox.Show("Proveedor actualizado");
                    else
                        MessageBox.Show($"Error al actualizar el proveedor: {response.StatusCode}");
                }
                Clear();
                GetAllProviders();
            }
            else
            {
                MessageBox.Show("Debe haber información para actualizar la información del proveedor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
