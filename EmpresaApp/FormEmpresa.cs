using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmpresaApp
{
    public partial class FormEmpresa : Form
    {
        private string connstr;
        private SqlDataAdapter dataAdapterDepartamento;
        private DataSet dataSetDepatamento;
        private SqlCommand sqlCmd;

 

        public FormEmpresa()
        {
            InitializeComponent();
            connstr = Utility.GetConnectionString(); //string de ligação à base de dados
            
            groupBoxDepartamentos.Hide();
            AtualizaDatagridviewDepartamentos();

        }

        /// <summary>
        /// Método para tornar visível os controlos para a gestão de departamentos (inserir, apagar...)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuNovoDepartamento_Click(object sender, EventArgs e)
        {
            groupBoxDepartamentos.Show();
        }

        /// <summary>
        /// Método para atualizar a DataGridView que contém a lista de departamentos com base
        /// na culsulta à base de dados.
        /// </summary>
        public void AtualizaDatagridviewDepartamentos()
        {
            string queryString = "SELECT * FROM Departamento ";

            try
            {
                using (SqlConnection connection = new SqlConnection(connstr))
                {
                    using (dataAdapterDepartamento = new SqlDataAdapter(queryString, connection))
                    {
                        dataSetDepatamento = new DataSet();
                        dataAdapterDepartamento.Fill(dataSetDepatamento);
                        dataGridViewDepartamentos.DataSource = dataSetDepatamento.Tables[0];
                        dataGridViewDepartamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridViewDepartamentos.Refresh();
                        dataGridViewDepartamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter os dados da base de dados: " + ex.Message,
                "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LimpaTextBoxes();
        }

        private void LimpaTextBoxes()
        {
            textBoxIdDepartamento.Clear();
            textBoxNomeDepartamento.Clear();
            dataGridViewDepartamentos.ClearSelection();
        }

        /// <summary>
        /// Método para inserir um novo registo na tabela 'Departamento' da base de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCriarDepartamento_Click(object sender, EventArgs e)
        {
            string queryString = "INSERT INTO Departamento(Id, Nome) VALUES(@Id, @Nome )";
            string id = textBoxIdDepartamento.Text;
            string nome = textBoxNomeDepartamento.Text;

            try
            {
                //a utilização de 'using' fecha automáticamente a ligação, assim não é necessário conn.Close()
                using (SqlConnection connection = new SqlConnection(connstr))
                {
                    using (sqlCmd = new SqlCommand(queryString, connection))
                    {
                        sqlCmd.Parameters.Add("@Id", SqlDbType.VarChar);
                        sqlCmd.Parameters["@Id"].Value = id;

                        sqlCmd.Parameters.Add("@Nome", SqlDbType.VarChar);
                        sqlCmd.Parameters["@Nome"].Value = nome;

                        sqlCmd.Connection.Open();
                        dataAdapterDepartamento.InsertCommand = sqlCmd;
                        dataAdapterDepartamento.InsertCommand.ExecuteNonQuery();

                        id = (string)sqlCmd.Parameters["@Id"].Value;

                        MessageBox.Show("Criado o departamento com o id: " + id,
                                        "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AtualizaDatagridviewDepartamentos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na inserção do departamento: " + ex.Message,
                "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método para apagar um registo da tabela 'Departamento' da base de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonApagar_Click(object sender, EventArgs e)
        {
            string queryString = "DELETE FROM Departamento WHERE Id = @Id ";

              try
              {
                  using (SqlConnection connection = new SqlConnection(connstr))
                  {
                      using (SqlCommand sqlCmd = new SqlCommand(queryString, connection))
                      {
                          sqlCmd.Parameters.Add("@Id", SqlDbType.VarChar);
                          sqlCmd.Parameters["@Id"].Value = dataGridViewDepartamentos.SelectedRows[0].Cells[0].Value;

                          sqlCmd.Connection.Open();
                          dataAdapterDepartamento.DeleteCommand = sqlCmd;
                          dataAdapterDepartamento.DeleteCommand.ExecuteNonQuery();
                          dataGridViewDepartamentos.Rows.RemoveAt(dataGridViewDepartamentos.CurrentRow.Index);

                      }
                  }
              }
              catch (Exception ex)
              {
                  MessageBox.Show("Erro ao apagar registo: " + ex.Message,
                  "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }

        }

        /// <summary>
        /// Método para selecionar uma linha ao clicar em qualquer célula da DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewDepartamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxIdDepartamento.Text = dataGridViewDepartamentos.SelectedRows[0].Cells[0].Value.ToString();
            textBoxNomeDepartamento.Text = dataGridViewDepartamentos.SelectedRows[0].Cells[1].Value.ToString();
        }


        /// <summary>
        /// Método para atualiza um registo na base de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAtualizarDepartamento_Click(object sender, EventArgs e)
        {
            string queryString = "UPDATE Departamento SET Id=@Id, Nome=@Nome WHERE Id=@Id";

            string id = textBoxIdDepartamento.Text;
            string nome = textBoxNomeDepartamento.Text;

            try
            {
                //a utilização de 'using' fecha automáticamente a ligação, assim não é necessário conn.Close()
                using (SqlConnection connection = new SqlConnection(connstr))
                {
                    using (sqlCmd = new SqlCommand(queryString, connection))
                    {
                        sqlCmd.Parameters.Add("@Id", SqlDbType.VarChar);
                        sqlCmd.Parameters["@Id"].Value = id;

                        sqlCmd.Parameters.Add("@Nome", SqlDbType.VarChar);
                        sqlCmd.Parameters["@Nome"].Value = nome;

                        sqlCmd.Connection.Open();
                        dataAdapterDepartamento.UpdateCommand = sqlCmd;
                        dataAdapterDepartamento.UpdateCommand.ExecuteNonQuery();

                        id = (string)sqlCmd.Parameters["@Id"].Value;

                        MessageBox.Show("Alterado o departamento com o id: " + id,
                                        "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        AtualizaDatagridviewDepartamentos();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na inserção do departamento: " + ex.Message,
                "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método que aplica filtragem na DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonProcurarDepartamento_Click(object sender, EventArgs e)
        {
            DataView dv = dataSetDepatamento.Tables[0].DefaultView;

            dv.RowFilter = string.Format("Id LIKE '%{0}%' OR Nome LIKE '%{0}%' ",
                                        textBoxProcurarDepartamento.Text, textBoxProcurarDepartamento.Text);
            dataGridViewDepartamentos.DataSource = dv;
        }


        /// <summary>
        /// Método para sair da aplicação a aplicação.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuFicheiroImportarCSV_Click(object sender, EventArgs e)
        {
            FormImportarCSV formCSV = new FormImportarCSV(this);
            formCSV.Show();

        }

    }
}
