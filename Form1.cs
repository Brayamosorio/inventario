using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace inventario
{
    [DebuggerDisplay($"{{{nameof(Form1Helpers.GetDebuggerDisplay)}(),nq}}")]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool edit = false;
        int id = 1;
        int rows = 0;



        private void Form1_Load(object sender, EventArgs e)
        {

            txtname.ForeColor = Color.Gray;
            txtprecio.ForeColor = Color.Gray;
            txtcant.ForeColor = Color.Gray;
            btnguardar.Enabled = false;
            btnguardar.BackColor = Color.Gray;
            btnguardar.ForeColor = Color.White;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtid_Enter(object sender, EventArgs e)
        {

        }

        private void txtid_Leave(object sender, EventArgs e)
        {

        }

        private void txtname_Enter(object sender, EventArgs e)
        {
            if (txtname.Text == "producto")
            {
                txtname.Text = "";
                txtname.ForeColor = Color.Black;

            }
        }

        private void txtname_Leave(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                txtname.Text = "producto";
                txtname.ForeColor = Color.Gray;

            }
        }

        private void txtprecio_Enter(object sender, EventArgs e)
        {
            if (txtprecio.Text == "precio")
            {

                txtprecio.Text = "";
                txtprecio.ForeColor = Color.Black;

            }
        }

        private void txtprecio_Leave(object sender, EventArgs e)
        {
            if (txtprecio.Text == "")
            {

                txtprecio.Text = "precio";
                txtprecio.ForeColor = Color.Gray;

            }
        }

        private void txtcant_Enter(object sender, EventArgs e)
        {
            if (txtcant.Text == "cantidad")
            {
                txtcant.Text = "";
                txtcant.ForeColor = Color.Black;
            }
        }

        private void txtcant_Leave(object sender, EventArgs e)
        {
            if (txtcant.Text == "")
            {
                txtcant.Text = "cantidad";
                txtcant.ForeColor = Color.Gray;
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            edit = false;
            btnguardar.Enabled = true;
            btnguardar.BackColor = Color.SteelBlue;
            btnguardar.ForeColor = Color.White;
            btnnuevo.Enabled = false;
            btnnuevo.BackColor = Color.Gray;
            btnnuevo.ForeColor = Color.White;





        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }


        private void cleartxt()
        {
            ;
            txtname.Text = "producto";
            txtprecio.Text = "precio";
            txtcant.Text = "cantidad";


        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (!edit)
            {
                int x = dvgdatos.Rows.Add();
                user user = new user();
                user.Id = id;
                user.Name = txtname.Text;
                user.Precio = Convert.ToInt32(txtprecio.Text);
                user.Cant = Convert.ToInt32(txtcant.Text);
                dvgdatos.Rows[x].Cells[0].Value = user.Id;
                dvgdatos.Rows[x].Cells[1].Value = user.Name;
                dvgdatos.Rows[x].Cells[2].Value = user.Precio;
                dvgdatos.Rows[x].Cells[3].Value = user.Cant;
                cleartxt();
                id++;
                btnguardar.Enabled = false;
                btnguardar.BackColor = Color.Gray;
                btnguardar.ForeColor = Color.White;
                btnnuevo.Enabled = true;
                btnnuevo.BackColor = Color.SteelBlue;
                btnnuevo.ForeColor = Color.White;


            }
            else
            {
                if (dvgdatos.Rows.Count > 0)
                {


                    user user = new user();

                    user.Name = txtname.Text;
                    user.Precio = Convert.ToInt32(txtprecio.Text);
                    user.Cant = Convert.ToInt32(txtcant.Text);

                    dvgdatos.Rows[rows].Cells[1].Value = user.Name;
                    dvgdatos.Rows[rows].Cells[2].Value = user.Precio;
                    dvgdatos.Rows[rows].Cells[3].Value = user.Cant;
                    rows = 0;
                    cleartxt();
                    edit = false;
                    btnguardar.Enabled = false;
                    btnguardar.BackColor = Color.Gray;
                    btnguardar.ForeColor = Color.White;
                    btnnuevo.Enabled = true;
                    btnnuevo.BackColor = Color.SteelBlue;
                    btnnuevo.ForeColor = Color.White;
                }

            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dvgdatos.SelectedRows.Count > 0)
            {
                btnguardar.Enabled = true;
                btnguardar.BackColor = Color.SteelBlue;
                btnguardar.ForeColor = Color.White;
                btnnuevo.Enabled = false;
                btnnuevo.BackColor = Color.Gray;
                btnnuevo.ForeColor = Color.White;

                edit = true;
                rows = dvgdatos.SelectedRows[0].Index;
                txtname.Text = dvgdatos.CurrentRow.Cells[1].Value.ToString();
                txtprecio.Text = dvgdatos.CurrentRow.Cells[2].Value.ToString();
                txtcant.Text = dvgdatos.CurrentRow.Cells[3].Value.ToString();

            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dvgdatos.SelectedRows.Count > 0)
            {
                int r = dvgdatos.SelectedRows[0].Index;
                dvgdatos.Rows.RemoveAt(r);
            }
        }
    }
}

