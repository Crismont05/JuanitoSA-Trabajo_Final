namespace JuanitoSA
{
    partial class Clientes
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnAgregar = new Button();
            groupBox2 = new GroupBox();
            txtNumero = new TextBox();
            label8 = new Label();
            txtFecha_Nacimiento = new TextBox();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            txtDireccion = new TextBox();
            label9 = new Label();
            listBox1 = new ListBox();
            label6 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            txtIDCliente = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabPage2 = new TabPage();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            dgvListado = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListado).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(313, 9);
            label1.Name = "label1";
            label1.Size = new Size(228, 24);
            label1.TabIndex = 0;
            label1.Text = "DETALLES DE CLIENTES";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(66, 36);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(749, 495);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(28, 37, 48);
            tabPage1.Controls.Add(btnAgregar);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(741, 465);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Datos Generales";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(28, 37, 48);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(282, 381);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(189, 44);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(64, 64, 64);
            groupBox2.Controls.Add(txtNumero);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtFecha_Nacimiento);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(445, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(242, 338);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del Perfil";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(18, 284);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(183, 23);
            txtNumero.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(18, 264);
            label8.Name = "label8";
            label8.Size = new Size(153, 17);
            label8.TabIndex = 5;
            label8.Text = "Número de Contacto:";
            // 
            // txtFecha_Nacimiento
            // 
            txtFecha_Nacimiento.Location = new Point(18, 225);
            txtFecha_Nacimiento.Name = "txtFecha_Nacimiento";
            txtFecha_Nacimiento.Size = new Size(183, 23);
            txtFecha_Nacimiento.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(18, 204);
            label7.Name = "label7";
            label7.Size = new Size(152, 17);
            label7.TabIndex = 3;
            label7.Text = "Fecha de Nacimiento:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1682531;
            pictureBox1.Location = new Point(35, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(64, 64, 64);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(txtIDCliente);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(15, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(364, 338);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Proveedores";
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccion.ForeColor = Color.Black;
            txtDireccion.Location = new Point(87, 148);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(241, 55);
            txtDireccion.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(6, 151);
            label9.Name = "label9";
            label9.Size = new Size(73, 17);
            label9.TabIndex = 11;
            label9.Text = "Dirección:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 16;
            listBox1.Items.AddRange(new object[] { "Honduras", "Guatemala", "San Salvador", "Nicaragua", "Costa Rica", "Panamá" });
            listBox1.Location = new Point(113, 289);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(176, 20);
            listBox1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(6, 289);
            label6.Name = "label6";
            label6.Size = new Size(101, 17);
            label6.TabIndex = 9;
            label6.Text = "Nacionalidad:";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.ForeColor = Color.White;
            radioButton2.Location = new Point(87, 250);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(84, 21);
            radioButton2.TabIndex = 8;
            radioButton2.Text = "Femenino";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(87, 225);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(86, 21);
            radioButton1.TabIndex = 7;
            radioButton1.Text = "Masculino";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtIDCliente
            // 
            txtIDCliente.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtIDCliente.ForeColor = Color.Black;
            txtIDCliente.Location = new Point(101, 105);
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.Size = new Size(227, 22);
            txtIDCliente.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.ForeColor = Color.Black;
            txtApellido.Location = new Point(101, 67);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(227, 22);
            txtApellido.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(101, 33);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(227, 22);
            txtNombre.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(6, 229);
            label5.Name = "label5";
            label5.Size = new Size(41, 17);
            label5.TabIndex = 3;
            label5.Text = "Sexo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(6, 108);
            label4.Name = "label4";
            label4.Size = new Size(95, 17);
            label4.TabIndex = 2;
            label4.Text = "Id Proveedor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(6, 67);
            label3.Name = "label3";
            label3.Size = new Size(70, 17);
            label3.TabIndex = 1;
            label3.Text = "Apellidos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(6, 33);
            label2.Name = "label2";
            label2.Size = new Size(70, 17);
            label2.TabIndex = 0;
            label2.Text = "Nombres:";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(28, 37, 48);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(dgvListado);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(741, 465);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Listado";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(28, 37, 48);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(140, 410);
            button3.Name = "button3";
            button3.Size = new Size(117, 36);
            button3.TabIndex = 8;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(28, 37, 48);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(447, 410);
            button1.Name = "button1";
            button1.Size = new Size(117, 36);
            button1.TabIndex = 7;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(28, 37, 48);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(288, 410);
            button2.Name = "button2";
            button2.Size = new Size(117, 36);
            button2.TabIndex = 6;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = false;
            // 
            // dgvListado
            // 
            dgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListado.Location = new Point(2, 6);
            dgvListado.Name = "dgvListado";
            dgvListado.RowTemplate.Height = 25;
            dgvListado.Size = new Size(733, 389);
            dgvListado.TabIndex = 0;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 37, 48);
            ClientSize = new Size(960, 604);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Clientes";
            Text = "Clientes";
            Load += Clientes_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox txtIDCliente;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ListBox listBox1;
        private Label label6;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private TextBox txtNumero;
        private Label label8;
        private TextBox txtFecha_Nacimiento;
        private Label label7;
        private Button btnAgregar;
        private TextBox txtDireccion;
        private Label label9;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dgvListado;
    }
}