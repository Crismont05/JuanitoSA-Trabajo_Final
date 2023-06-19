namespace JuanitoSA
{
    partial class Ventas
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
            btnEliminar = new Button();
            btnComprar = new Button();
            btnSell = new Button();
            dgvVentas = new DataGridView();
            txtCantidad = new TextBox();
            txtID = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            dtpFecha = new DateTimePicker();
            pictureBox1 = new PictureBox();
            label13 = new Label();
            lblMontoPagado = new Label();
            label4 = new Label();
            lblMontoVendido = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(346, 21);
            label1.Name = "label1";
            label1.Size = new Size(215, 24);
            label1.TabIndex = 0;
            label1.Text = "DETALLES DE VENTAS";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnComprar);
            groupBox1.Controls.Add(btnSell);
            groupBox1.Controls.Add(dgvVentas);
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(21, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(946, 440);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Área de ventas";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(0, 0, 64);
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(616, 52);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(103, 43);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnComprar
            // 
            btnComprar.BackColor = Color.FromArgb(0, 0, 64);
            btnComprar.Location = new Point(411, 84);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(103, 43);
            btnComprar.TabIndex = 16;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // btnSell
            // 
            btnSell.BackColor = Color.FromArgb(0, 0, 64);
            btnSell.Enabled = false;
            btnSell.Location = new Point(411, 25);
            btnSell.Name = "btnSell";
            btnSell.Size = new Size(103, 43);
            btnSell.TabIndex = 15;
            btnSell.Text = "Vender";
            btnSell.UseVisualStyleBackColor = false;
            btnSell.Click += btnSell_Click;
            // 
            // dgvVentas
            // 
            dgvVentas.BackgroundColor = Color.DarkGray;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.GridColor = Color.DarkGray;
            dgvVentas.Location = new Point(18, 161);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.RowTemplate.Height = 25;
            dgvVentas.Size = new Size(898, 273);
            dgvVentas.TabIndex = 14;
            dgvVentas.CellContentClick += dgvVentas_CellContentClick;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(152, 81);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(169, 26);
            txtCantidad.TabIndex = 10;
            // 
            // txtID
            // 
            txtID.Location = new Point(152, 37);
            txtID.Name = "txtID";
            txtID.Size = new Size(169, 26);
            txtID.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(18, 84);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 7;
            label6.Text = "Cantidad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(18, 43);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 4;
            label3.Text = "Id del producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(563, 77);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 2;
            label2.Text = "Fecha Actual:";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(680, 74);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(172, 23);
            dtpFecha.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bestelportal_500x500;
            pictureBox1.Location = new Point(228, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(56, 557);
            label13.Name = "label13";
            label13.Size = new Size(109, 20);
            label13.TabIndex = 5;
            label13.Text = "Total Pagado:";
            // 
            // lblMontoPagado
            // 
            lblMontoPagado.AutoSize = true;
            lblMontoPagado.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMontoPagado.ForeColor = Color.Lime;
            lblMontoPagado.Location = new Point(173, 554);
            lblMontoPagado.Name = "lblMontoPagado";
            lblMontoPagado.Size = new Size(121, 20);
            lblMontoPagado.TabIndex = 6;
            lblMontoPagado.Text = "Monto Pagado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(393, 557);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 7;
            label4.Text = "Total Vendido:";
            // 
            // lblMontoVendido
            // 
            lblMontoVendido.AutoSize = true;
            lblMontoVendido.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMontoVendido.ForeColor = Color.Lime;
            lblMontoVendido.Location = new Point(508, 557);
            lblMontoVendido.Name = "lblMontoVendido";
            lblMontoVendido.Size = new Size(125, 20);
            lblMontoVendido.TabIndex = 8;
            lblMontoVendido.Text = "Monto Vendido";
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 37, 48);
            ClientSize = new Size(960, 591);
            Controls.Add(lblMontoVendido);
            Controls.Add(label4);
            Controls.Add(lblMontoPagado);
            Controls.Add(label13);
            Controls.Add(pictureBox1);
            Controls.Add(dtpFecha);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ventas";
            Text = "Ventas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtCantidad;
        private TextBox txtID;
        private Label label6;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpFecha;
        private PictureBox pictureBox1;
        private DataGridView dgvVentas;
        private Button btnEliminar;
        private Button btnComprar;
        private Button btnSell;
        private Label label13;
        private Label lblMontoPagado;
        private Label label4;
        private Label lblMontoVendido;
    }
}