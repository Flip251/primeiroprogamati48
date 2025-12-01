using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Connection con = new Connection();

        bool EmailValido(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
        }

        List<Contato> lista = new List<Contato>();
      

        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtNome.Focus();
        }

        private void AtualizarGrid()
        {
            using (SqlConnection conn = con.Connect())
            {
                string sql = "SELECT * FROM Contatos";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Dg.DataSource = dt;
            }
        }

        private void Dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    var contato = lista[e.RowIndex];

                    txtId.Text = Dg.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    txtNome.Text = Dg.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                    txtTelefone.Text = Dg.Rows[e.RowIndex].Cells["Telefone"].Value.ToString();
                    txtEmail.Text = Dg.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                    txtData.Value = Convert.ToDateTime(Dg.Rows[e.RowIndex].Cells["DataRegistro"].Value);
                }
            }
        }


        private void btnAdiconar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = con.Connect())  //  usa a conexão correta (Antes era new)
                {
                    string sql =
                        "INSERT INTO Contatos (Nome, Telefone, Email, DataRegistro) " +
                        "VALUES (@Nome, @Telefone, @Email, @DataRegistro)"; //  sem @ inválidos

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@DataRegistro", txtData.Value);

                    cmd.ExecuteNonQuery();  //  agora funciona
                }

                MessageBox.Show("Registro Inserido!");
                AtualizarGrid();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }




        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Selecione um registro para alterar!");
                return;
            }

            using (SqlConnection conn = con.Connect())  //  conexão correta
            {
                string sql =
                    "UPDATE Contatos SET " +
                    "Nome=@Nome, Telefone=@Telefone, Email=@Email, DataRegistro=@DataRegistro " +
                    "WHERE ID=@ID";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", txtId.Text);
                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@DataRegistro", txtData.Value);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Registro alterado!");
            AtualizarGrid();
            LimparCampos();
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Selecione um registro para excluir!");
                return;
            }

            using (SqlConnection conn = con.Connect())
            {
                string sql = "DELETE FROM Contatos WHERE ID=@ID";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", txtId.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Registro Excluido!");
            AtualizarGrid();
            LimparCampos();
        }


    }
}
