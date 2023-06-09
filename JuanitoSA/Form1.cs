namespace JuanitoSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AbrirFormPanel(Object FormHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }


        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Inicio());
        }


        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            if (panelMenuVertical.Width == 77)
            {
                panelMenuVertical.Width = 187;
            }
            else
                panelMenuVertical.Width = 77;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnInicio_Click(null, e);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Productos());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Clientes());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Ventas());
        }

        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            AbrirFormPanel(new Inicio());
        }
    }
}