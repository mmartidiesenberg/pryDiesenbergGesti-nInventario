namespace pryDiesenbergGestiónInventario
{
    public partial class frmGestión : Form
    {
        public frmGestión()
        {
            InitializeComponent();
        }
        //
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (btnAgregar.Checked)
                MessageBox.Show("Producto Agregado Correctamente");
            if (btnModificar.Checked)
                MessageBox.Show("Producto Modificado Correctamente");
            if (btnEliminar.Checked)
                MessageBox.Show("Producto Eliminado Correctamente");
        }

        private void btnAgregar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGestión_Load(object sender, EventArgs e)
        {

        }
    }
}
