namespace JuanitoSA
{
    partial class Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtIdProveedor = new TextBox();
            label6 = new Label();
            txtexistencia = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            txtCosto = new TextBox();
            txtPrecio = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            dgvProductos = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(318, 18);
            label1.Name = "label1";
            label1.Size = new Size(265, 24);
            label1.TabIndex = 0;
            label1.Text = "DETALLES DE PRODUCTOS";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtIdProveedor);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtexistencia);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(txtCosto);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(58, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(828, 222);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Productos";
            // 
            // txtIdProveedor
            // 
            txtIdProveedor.Location = new Point(174, 184);
            txtIdProveedor.Margin = new Padding(3, 2, 3, 2);
            txtIdProveedor.Name = "txtIdProveedor";
            txtIdProveedor.Size = new Size(222, 26);
            txtIdProveedor.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 186);
            label6.Name = "label6";
            label6.Size = new Size(139, 20);
            label6.TabIndex = 12;
            label6.Text = "Id del proveedor:";
            // 
            // txtexistencia
            // 
            txtexistencia.Location = new Point(174, 140);
            txtexistencia.Margin = new Padding(3, 2, 3, 2);
            txtexistencia.Name = "txtexistencia";
            txtexistencia.Size = new Size(222, 26);
            txtexistencia.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 142);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 10;
            label3.Text = "Existencia:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Investor_Icons_01;
            pictureBox1.Location = new Point(540, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(174, 94);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(222, 26);
            txtCosto.TabIndex = 8;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(174, 52);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(222, 26);
            txtPrecio.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 97);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 4;
            label5.Text = "Costo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 58);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 3;
            label4.Text = "Precio:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(174, 18);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(222, 26);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 24);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(217, 352);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(544, 222);
            dgvProductos.TabIndex = 2;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.MediumBlue;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(85, 287);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(130, 37);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.MediumBlue;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(277, 287);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(130, 37);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.MediumBlue;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(486, 287);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(130, 37);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(720, 287);
            button1.Name = "button1";
            button1.Size = new Size(129, 37);
            button1.TabIndex = 7;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 37, 48);
            ClientSize = new Size(960, 591);
            Controls.Add(button1);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvProductos);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Productos";
            Text = "Productos";
            Load += Productos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private TextBox txtCosto;
        private TextBox txtPrecio;
        private Label label5;
        private Label label4;
        private TextBox txtNombre;
        private Label label2;
        private DataGridView dgvProductos;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private TextBox txtIdProveedor;
        private Label label6;
        private TextBox txtexistencia;
        private Label label3;
        private Button button1;
    }
}