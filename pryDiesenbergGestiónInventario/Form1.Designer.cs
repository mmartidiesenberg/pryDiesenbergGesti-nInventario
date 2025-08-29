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
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(27, 43);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(122, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre del Producto";
            // 
            // lblCodProd
            // 
            lblCodProd.AutoSize = true;
            lblCodProd.Location = new Point(27, 88);
            lblCodProd.Name = "lblCodProd";
            lblCodProd.Size = new Size(117, 15);
            lblCodProd.TabIndex = 1;
            lblCodProd.Text = "Código del Producto";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(27, 134);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 2;
            lblStock.Text = "Stock";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(27, 178);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(191, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtCodProd
            // 
            txtCodProd.Location = new Point(191, 85);
            txtCodProd.Name = "txtCodProd";
            txtCodProd.Size = new Size(100, 23);
            txtCodProd.TabIndex = 5;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(191, 131);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 6;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(191, 175);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 7;
            // 
            // frmGestión
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPrecio);
            Controls.Add(txtStock);
            Controls.Add(txtCodProd);
            Controls.Add(txtNombre);
            Controls.Add(lblPrecio);
            Controls.Add(lblStock);
            Controls.Add(lblCodProd);
            Controls.Add(lblNombre);
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
    }
}
