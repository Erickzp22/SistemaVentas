using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;  // para que no salga una fila en blanco en el principio del data gridview
            dataGridView1.Font = new Font("Showcard Gothic",20); // cambiamos el tamaño el font de la letra
            txt_cod_barra.Visible = false;
            txt_cod_barra.Focus();
           
        }

        private void txt_cod_barra_KeyPress(object sender, KeyPressEventArgs e)
        {
             // el codigo de barra lee y preciona el enter en la siguiente linea de codigo capturamos ese enter
            if (e.KeyChar == (char)13)
            {
                string[] producto;

                /*
                producto = new Business_Logic.BL.BL_CRUD().BL_BuscarProducto(txt_cod_M.Text);
                
                if (producto.Length > 0)
                {


                }
                else
                {

                    MessageBox.Show("El producto no esta disponible para la venta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                 */
            }
        }
    }
}
