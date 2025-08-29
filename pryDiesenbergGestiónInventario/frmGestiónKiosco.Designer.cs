namespace pryDiesenbergGestiónInventario
{
    partial class frmGestión
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
            lblNombre = new Label();
            lblCodProd = new Label();
            lblStock = new Label();
            lblPrecio = new Label();
            txtNombre = new TextBox();
            txtCodProd = new TextBox();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            btnAgregar = new RadioButton();
            btnModificar = new RadioButton();
            btnEliminar = new RadioButton();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(35, 54);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(167, 19);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre del Producto";
            // 
            // lblCodProd
            // 
            lblCodProd.AutoSize = true;
            lblCodProd.Location = new Point(35, 111);
            lblCodProd.Margin = new Padding(4, 0, 4, 0);
            lblCodProd.Name = "lblCodProd";
            lblCodProd.Size = new Size(159, 19);
            lblCodProd.TabIndex = 1;
            lblCodProd.Text = "Código del Producto";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(35, 170);
            lblStock.Margin = new Padding(4, 0, 4, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(49, 19);
            lblStock.TabIndex = 2;
            lblStock.Text = "Stock";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(35, 225);
            lblPrecio.Margin = new Padding(4, 0, 4, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(56, 19);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(192, 192, 255);
            txtNombre.Location = new Point(246, 45);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(127, 26);
            txtNombre.TabIndex = 4;
            // 
            // txtCodProd
            // 
            txtCodProd.BackColor = Color.FromArgb(192, 192, 255);
            txtCodProd.Location = new Point(246, 107);
            txtCodProd.Margin = new Padding(4);
            txtCodProd.Name = "txtCodProd";
            txtCodProd.Size = new Size(127, 26);
            txtCodProd.TabIndex = 5;
            // 
            // txtStock
            // 
            txtStock.BackColor = Color.FromArgb(192, 192, 255);
            txtStock.Location = new Point(246, 166);
            txtStock.Margin = new Padding(4);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(127, 26);
            txtStock.TabIndex = 6;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.FromArgb(192, 192, 255);
            txtPrecio.Location = new Point(246, 221);
            txtPrecio.Margin = new Padding(4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(127, 26);
            txtPrecio.TabIndex = 7;
            // 
            // btnAgregar
            // 
            btnAgregar.AutoSize = true;
            btnAgregar.Location = new Point(496, 54);
            btnAgregar.Margin = new Padding(4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(157, 23);
            btnAgregar.TabIndex = 8;
            btnAgregar.TabStop = true;
            btnAgregar.Text = "Agregar Producto";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.CheckedChanged += btnAgregar_CheckedChanged;
            // 
            // btnModificar
            // 
            btnModificar.AutoSize = true;
            btnModificar.Location = new Point(496, 126);
            btnModificar.Margin = new Padding(4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(172, 23);
            btnModificar.TabIndex = 9;
            btnModificar.TabStop = true;
            btnModificar.Text = "Modificar Producto";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.CheckedChanged += btnModificar_CheckedChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.AutoSize = true;
            btnEliminar.Location = new Point(496, 195);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(164, 23);
            btnEliminar.TabIndex = 10;
            btnEliminar.TabStop = true;
            btnEliminar.Text = "Eliminar Producto";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.CheckedChanged += btnEliminar_CheckedChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(176, 343);
            btnAceptar.Margin = new Padding(4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(96, 29);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(418, 343);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 29);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmGestión
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(739, 462);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtPrecio);
            Controls.Add(txtStock);
            Controls.Add(txtCodProd);
            Controls.Add(txtNombre);
            Controls.Add(lblPrecio);
            Controls.Add(lblStock);
            Controls.Add(lblCodProd);
            Controls.Add(lblNombre);
            Font = new Font("Cambria", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "frmGestión";
            Text = "Gestión de Inventario Kiosco";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblCodProd;
        private Label lblStock;
        private Label lblPrecio;
        private TextBox txtNombre;
        private TextBox txtCodProd;
        private TextBox txtStock;
        private TextBox txtPrecio;
        private RadioButton btnAgregar;
        private RadioButton btnModificar;
        private RadioButton btnEliminar;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}
