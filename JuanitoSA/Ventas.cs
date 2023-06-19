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
        int i = 1;
        int position; 
        public Ventas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string codigo, numero, proveedor, producto, cantidad, precio_compra, precio_venta, garantia;
            codigo = txtCódigo.Text; numero = txtNumero.Text; proveedor = txtProveedor.Text; producto = txtProducto.Text;
            cantidad = txtCantidad.Text; precio_compra = txtPrecioCompra.Text; precio_venta = txtPrecioVenta.Text; garantia = txtGarantía.Text;

            dgvVentas.Rows.Add(i + "", codigo, numero, proveedor, producto, cantidad, precio_compra, precio_venta, garantia);
            i = i + 1;
            limpiar();
            txtCódigo.Focus();
        }
        void limpiar()
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            txtCódigo.Text = "";
            txtNumero.Text = "";
            txtProveedor.Text = "";
            txtProducto.Text = "";
            txtCantidad.Text = "";
            txtPrecioCompra.Text = "";
            txtPrecioVenta.Text = "";
            txtGarantía.Text = "";
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position = dgvVentas.CurrentRow.Index;
            txtCódigo.Text = dgvVentas[1, position].Value.ToString();
            txtNumero.Text = dgvVentas[2, position].Value.ToString();
            txtProveedor.Text = dgvVentas[3, position].Value.ToString();
            txtProducto.Text = dgvVentas[4, position].Value.ToString();
            txtCantidad.Text = dgvVentas[5, position].Value.ToString();
            txtPrecioCompra.Text = dgvVentas[6, position].Value.ToString();
            txtPrecioVenta.Text= dgvVentas[7, position].Value.ToString();
            txtGarantía.Text = dgvVentas[8, position].Value.ToString();
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            txtCódigo.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
