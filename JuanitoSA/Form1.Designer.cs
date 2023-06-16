namespace JuanitoSA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelMenuVertical = new Panel();
            pictureBox4 = new PictureBox();
            panel3 = new Panel();
            btnVentas = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            panel1 = new Panel();
            btnClientes = new Button();
            btnProductos = new Button();
            btnInicio = new PictureBox();
            panelBarraTitulo = new Panel();
            pictureBox6 = new PictureBox();
            label1 = new Label();
            panelContenedor = new Panel();
            panelMenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnInicio).BeginInit();
            panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panelMenuVertical
            // 
            panelMenuVertical.BackColor = Color.FromArgb(28, 37, 48);
            panelMenuVertical.Controls.Add(pictureBox4);
            panelMenuVertical.Controls.Add(panel3);
            panelMenuVertical.Controls.Add(btnVentas);
            panelMenuVertical.Controls.Add(pictureBox3);
            panelMenuVertical.Controls.Add(pictureBox2);
            panelMenuVertical.Controls.Add(panel2);
            panelMenuVertical.Controls.Add(panel1);
            panelMenuVertical.Controls.Add(btnClientes);
            panelMenuVertical.Controls.Add(btnProductos);
            panelMenuVertical.Controls.Add(btnInicio);
            panelMenuVertical.Dock = DockStyle.Left;
            panelMenuVertical.Location = new Point(0, 0);
            panelMenuVertical.Name = "panelMenuVertical";
            panelMenuVertical.Size = new Size(77, 536);
            panelMenuVertical.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(23, 343);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(51, 41);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumBlue;
            panel3.Location = new Point(0, 329);
            panel3.Name = "panel3";
            panel3.Size = new Size(17, 63);
            panel3.TabIndex = 6;
            // 
            // btnVentas
            // 
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(0, 329);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(242, 63);
            btnVentas.TabIndex = 7;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.people_blue;
            pictureBox3.Location = new Point(23, 264);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(51, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Investor_Icons_01;
            pictureBox2.Location = new Point(23, 186);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumBlue;
            panel2.Location = new Point(0, 248);
            panel2.Name = "panel2";
            panel2.Size = new Size(17, 66);
            panel2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumBlue;
            panel1.Location = new Point(0, 170);
            panel1.Name = "panel1";
            panel1.Size = new Size(17, 63);
            panel1.TabIndex = 0;
            // 
            // btnClientes
            // 
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(0, 248);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(261, 66);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "Proveedores";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProductos
            // 
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductos.ForeColor = Color.White;
            btnProductos.Location = new Point(0, 170);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(242, 63);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnInicio
            // 
            btnInicio.Dock = DockStyle.Top;
            btnInicio.Image = Properties.Resources.logo_transparent2;
            btnInicio.Location = new Point(0, 0);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(77, 132);
            btnInicio.SizeMode = PictureBoxSizeMode.StretchImage;
            btnInicio.TabIndex = 0;
            btnInicio.TabStop = false;
            // 
            // panelBarraTitulo
            // 
            panelBarraTitulo.BackColor = Color.MediumBlue;
            panelBarraTitulo.Controls.Add(pictureBox6);
            panelBarraTitulo.Controls.Add(label1);
            panelBarraTitulo.Dock = DockStyle.Top;
            panelBarraTitulo.Location = new Point(77, 0);
            panelBarraTitulo.Name = "panelBarraTitulo";
            panelBarraTitulo.Size = new Size(903, 41);
            panelBarraTitulo.TabIndex = 1;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.menu;
            pictureBox6.Location = new Point(0, 6);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(50, 32);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(122, 9);
            label1.Name = "label1";
            label1.Size = new Size(360, 22);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA DE INVENTARIOS JUANITO S.A";
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(64, 64, 64);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(77, 41);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(903, 495);
            panelContenedor.TabIndex = 2;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 536);
            Controls.Add(panelContenedor);
            Controls.Add(panelBarraTitulo);
            Controls.Add(panelMenuVertical);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelMenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnInicio).EndInit();
            panelBarraTitulo.ResumeLayout(false);
            panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenuVertical;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Panel panel1;
        private Button btnClientes;
        private Button btnProductos;
        private PictureBox btnInicio;
        private Panel panelBarraTitulo;
        private Panel panelContenedor;
        private Label label1;
        private PictureBox pictureBox4;
        private Panel panel3;
        private Button btnVentas;
        private PictureBox pictureBox6;
    }
}