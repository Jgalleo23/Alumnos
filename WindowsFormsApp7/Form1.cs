using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class formUsers : System.Windows.Forms.Form
    {
        public MySqlCommand Comando { get; private set; }
        public MySqlDataReader Lector { get; private set; }

        public static string CadenaConexion = "server=localhost;user id=root;password=root;persistsecurityinfo=True;database=instituto";

        public MySqlConnection connection;

        public formUsers()
        {
            InitializeComponent();
            institutoDataGridView.CellClick += institutoDataGridView_CellClick;
            notasDataGridView.CellClick += notasDataGridView_CellClick;
        }

        public void LeerDeBaseDeDatos()
        {

            string Consulta = "SELECT * FROM instituto"; // Declaración de la consulta

            using (MySqlConnection conn = new MySqlConnection(CadenaConexion))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(Consulta, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    institutoDataGridView.DataSource = ds.Tables[0];
                }
            }
        }

        public void LeerNotas()
        {
            string Consulta = "SELECT * FROM notas WHERE ID_STUDENT =  '" + lbCode.Text + "'"; // Declaración de la consulta

            using (MySqlConnection conn = new MySqlConnection(CadenaConexion))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(Consulta, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    notasDataGridView.DataSource = ds.Tables[0];
                }
            }
        }

        public void LeerTrimestres()
        {
            string Consulta = "SELECT * FROM trimestres WHERE ID_STUDENT =  '" + lbCode.Text + "'"; // Declaración de la consulta

            using (MySqlConnection conn = new MySqlConnection(CadenaConexion))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(Consulta, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    notasDataGridView.DataSource = ds.Tables[0];
                }
            }
        }

        public void CalcularMediaAlumno()
        {

            string Consulta = $"UPDATE instituto SET AVERAGE = (SELECT AVG(NOTE) FROM notas WHERE ID_STUDENT = instituto.ID)"; // Declaración de la consulta

            label2.Text = Consulta;

            connection = new MySqlConnection(CadenaConexion);
            connection.Open();
            MySqlCommand comando = new MySqlCommand(Consulta, connection);
            comando.ExecuteNonQuery();

            LeerDeBaseDeDatos();
            LeerNotas();
            connection.Close();

        }

        public void CalcularMediaAlumnoTrimestres()
        {

            string Consulta = $"UPDATE trimestres SET QUARTER1_AVG = (SELECT AVG(NOTE) FROM notas WHERE ID_STUDENT = 0 AND QUARTER = 1)"; // Declaración de la consulta

            label2.Text = Consulta;

            connection = new MySqlConnection(CadenaConexion);
            connection.Open();
            MySqlCommand comando = new MySqlCommand(Consulta, connection);
            comando.ExecuteNonQuery();

            LeerDeBaseDeDatos();
            LeerNotas();
            connection.Close();

        }

        public void CalcularMediaClase()
        {

            string Consulta = "SELECT AVG(AVERAGE) FROM instituto"; // Declaración de la consulta

            label2.Text = Consulta;

            connection = new MySqlConnection(CadenaConexion);
            connection.Open();
            MySqlCommand comando = new MySqlCommand(Consulta, connection);

            object result = comando.ExecuteScalar();
            double classAverage = result != null ? Convert.ToDouble(result) : 0;
            label9.Text = classAverage.ToString();
            comando.ExecuteNonQuery();


            LeerDeBaseDeDatos();
            LeerNotas();
            connection.Close();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'institutoDataSet.trimestres' Puede moverla o quitarla según sea necesario.
            this.trimestresTableAdapter.Fill(this.institutoDataSet.trimestres);
            LeerDeBaseDeDatos();
            LeerNotas();
        }




        private void institutoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbCode.Text = e.RowIndex.ToString();
            addNoteToolStripMenuItem.Enabled = true;
            borrarToolStripMenuItem.Enabled = true;
            deleteUserToolStripMenuItem.Enabled = true;
            modificarToolStripMenuItem.Enabled = true;
            modifyUserToolStripMenuItem.Enabled = true;
            LeerNotas();
        }


        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form();

            if (form.ShowDialog() == DialogResult.OK)
            {
                string ID = form.txtID.Text;
                string NAME = form.txtUser.Text;
                string SURNAME = form.txtSurname.Text;
                string QUARTER = form.txtQuarter.Text;

                string Consulta = $"INSERT INTO instituto (ID, NAME, SURNAME, QUARTER) VALUES ('{ID}', '{NAME}', '{SURNAME}', '{QUARTER}')"; // Declaración de la consulta

                label2.Text = Consulta;

                connection = new MySqlConnection(CadenaConexion);
                connection.Open();
                MySqlCommand comando = new MySqlCommand(Consulta, connection);
                comando.ExecuteNonQuery();

                LeerDeBaseDeDatos();
                connection.Close();
            }
        }


        private void modifyUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (institutoDataGridView.SelectedRows.Count > 0)
            {
                int row = institutoDataGridView.SelectedRows[0].Index;

                string id = institutoDataGridView.Rows[row].Cells["dataGridViewTextBoxColumn2"].Value.ToString();
                string name = institutoDataGridView.Rows[row].Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                string surname = institutoDataGridView.Rows[row].Cells["dataGridViewTextBoxColumn3"].Value.ToString();
                string quarter = institutoDataGridView.Rows[row].Cells["dataGridViewTextBoxColumn4"].Value.ToString();

                Form form = new Form();

                form.txtID.Text = id;
                form.txtUser.Text = name;
                form.txtSurname.Text = surname;
                form.txtQuarter.Text = quarter;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string ID = form.txtID.Text;
                    string NAME = form.txtUser.Text;
                    string SURNAME = form.txtSurname.Text;
                    string QUARTER = form.txtQuarter.Text;

                    string Consulta = $"UPDATE instituto SET ID = '{ID}', NAME = '{NAME}', SURNAME = '{SURNAME}', QUARTER = '{QUARTER}' WHERE ID = '{ID}'"; // Declaración de la consulta

                    label2.Text = Consulta;

                    connection = new MySqlConnection(CadenaConexion);
                    connection.Open();
                    MySqlCommand comando = new MySqlCommand(Consulta, connection);
                    comando.ExecuteNonQuery();


                    CalcularMediaAlumno();
                    CalcularMediaClase();
                    LeerDeBaseDeDatos();
                    connection.Close();
                }
            }
        }


        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (institutoDataGridView.SelectedRows.Count > 0)
            {
                string Consulta = "DELETE FROM instituto WHERE ID = '" + lbCode.Text + "'"; // Declaración de la consulta
                string ConsultaNotas = "DELETE FROM notas WHERE ID_STUDENT = '" + lbCode.Text + "'"; // Declaración de la consulta

                label2.Text = Consulta;

                connection = new MySqlConnection(CadenaConexion);
                connection.Open();

                MySqlCommand comando = new MySqlCommand(Consulta, connection);
                MySqlCommand comandoNotas = new MySqlCommand(ConsultaNotas, connection);

                DialogResult comprobar = MessageBox.Show("¿Want to delete an user and notes?", "Delete", MessageBoxButtons.YesNo);
                if (comprobar == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    comandoNotas.ExecuteNonQuery();

                    CalcularMediaAlumno();
                    CalcularMediaClase();
                    LeerDeBaseDeDatos();
                    LeerNotas();
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Select row");
            }
        }


        private void notasDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label5.Text = e.RowIndex.ToString();
            addNoteToolStripMenuItem.Enabled = true;
            borrarToolStripMenuItem.Enabled = true;
            deleteNoteToolStripMenuItem.Enabled = true;
            modificarToolStripMenuItem.Enabled = true;
            modifyNoteToolStripMenuItem.Enabled = true;
        }




        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.lbName.Text = "ID Student";
            form.lbPhone.Text = "Description";
            form.lbDirection.Text = "Note";
            form.comboBox1.Visible = true;
            form.label1.Visible = true;

            if (form.ShowDialog() == DialogResult.OK)
            {
                string ID = form.txtID.Text;
                string ID_STUDENT = form.txtUser.Text;
                string DESCRIPTION = form.txtSurname.Text;
                string NOTE = form.txtQuarter.Text;

                string Consulta = $"INSERT INTO notas (ID, DESCRIPTION, NOTE, ID_STUDENT) VALUES ('{ID}', '{DESCRIPTION}', '{NOTE}', '{ID_STUDENT}')"; // Declaración de la consulta

                label2.Text = Consulta;

                connection = new MySqlConnection(CadenaConexion);
                connection.Open();
                MySqlCommand comando = new MySqlCommand(Consulta, connection);
                comando.ExecuteNonQuery();

                
                CalcularMediaAlumno();
                CalcularMediaClase();
                LeerNotas();
                connection.Close();
                form.comboBox1.Visible = false;
                form.label1.Visible = false;
            }
        }


        private void deleteNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notasDataGridView.SelectedRows.Count > 0)
            {
                string Consulta = "DELETE FROM notas WHERE ID = '" + label5.Text + "' AND ID_STUDENT = '" + lbCode.Text + "'"; // Declaración de la consulta

                label2.Text = Consulta;

                connection = new MySqlConnection(CadenaConexion);
                connection.Open();

                MySqlCommand comando = new MySqlCommand(Consulta, connection);

                DialogResult comprobar = MessageBox.Show("¿Want to delete a note?", "Delete", MessageBoxButtons.YesNo);
                if (comprobar == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();

                    CalcularMediaAlumno();
                    CalcularMediaClase();
                    LeerNotas();
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Select row");
            }
        }


        private void modifyNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notasDataGridView.SelectedRows.Count > 0)
            {
                int row = notasDataGridView.SelectedRows[0].Index;

                string id = notasDataGridView.Rows[row].Cells["dataGridViewTextBoxColumn6"].Value.ToString();
                string id_student = notasDataGridView.Rows[row].Cells["dataGridViewTextBoxColumn9"].Value.ToString();
                string description = notasDataGridView.Rows[row].Cells["dataGridViewTextBoxColumn7"].Value.ToString();
                string note = notasDataGridView.Rows[row].Cells["dataGridViewTextBoxColumn8"].Value.ToString();

                Form form = new Form();

                form.txtID.Text = id;
                form.txtUser.Text = id_student;
                form.txtSurname.Text = description;
                form.txtQuarter.Text = note;
                form.lbName.Text = "ID Student";
                form.lbPhone.Text = "Description";
                form.lbDirection.Text = "Note";

                if (form.ShowDialog() == DialogResult.OK)
                {
                    string ID = form.txtID.Text;
                    string ID_STUDENT = form.txtUser.Text;
                    string DESCRIPTION = form.txtSurname.Text;
                    string NOTE = form.txtQuarter.Text;

                    string Consulta = $"UPDATE notas SET ID = '{ID}', DESCRIPTION = '{DESCRIPTION}', NOTE = '{NOTE}', ID_STUDENT = '{ID_STUDENT}' WHERE ID = '{ID}'"; // Declaración de la consulta

                    label2.Text = Consulta;

                    connection = new MySqlConnection(CadenaConexion);
                    connection.Open();
                    MySqlCommand comando = new MySqlCommand(Consulta, connection);
                    comando.ExecuteNonQuery();

                    CalcularMediaAlumno();
                    CalcularMediaClase();
                    LeerNotas();
                    connection.Close();
                }
            }
        }

    }
}

