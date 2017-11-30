using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace EmpresaApp
{
    public partial class FormImportarCSV : Form
    {
        private string connstr;
        private FormEmpresa formEmpresa;


        public FormImportarCSV(FormEmpresa form)
        {
            InitializeComponent();
            connstr = Utility.GetConnectionString(); //string de ligação à base de dados
            formEmpresa = form;
        }

        private void ButtonProcurarrCSV_Click(object sender, EventArgs e)
        {
            Stream stream = null;
            OpenFileDialog openFileDialogCSV = new OpenFileDialog();

            openFileDialogCSV.InitialDirectory = "c:\\";
            openFileDialogCSV.Filter = "Ficheiros CSV separados por vígula (*.csv)|*.csv";
            openFileDialogCSV.RestoreDirectory = true;

            if (openFileDialogCSV.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((stream = openFileDialogCSV.OpenFile()) != null)
                    {
                        using (stream)
                        {
                            textBoxLocalizacaoCSV.Text = openFileDialogCSV.FileName;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao abrir o ficheiro: " + ex.Message,
                                    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAbirCSV_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader streamReader = new StreamReader(textBoxLocalizacaoCSV.Text);
                textBoxConteudoCSV.Text = streamReader.ReadToEnd();
                streamReader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao abrir o ficheiro: " + ex.Message,
                               "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonImportarCSV_Click(object sender, EventArgs e)
        {
            
            if (comboBoxTabela.Text =="Departamento")
            {
                ImportarDepartamentos();
            }
            else if (comboBoxTabela.Text == "Funcionario")
            {
                ImportarFuncionarios();
            }
            else
            {
                MessageBox.Show("Deve selecionar uma tabela ","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            formEmpresa.AtualizaDatagridviewDepartamentos();
  
        }



        private void ImportarDepartamentos()
        {
            string queryString = "INSERT INTO Departamento(Id, Nome) VALUES(@Id, @Nome )";

            try
            {
                //a utilização de 'using' fecha automáticamente a ligação, assim não é necessário conn.Close()
                using (SqlConnection connection = new SqlConnection(connstr))
                {

                    for (int i = 0; i < textBoxConteudoCSV.Lines.Length; i++)
                    {

                        string linha = textBoxConteudoCSV.Lines[i];

                        if (string.IsNullOrEmpty(linha))
                        {
                            break;
                        }

                        string[] valoresLinha = linha.Split(';');

                        using (SqlCommand sqlCmd = new SqlCommand(queryString, connection))
                        {
                            sqlCmd.Parameters.Add("@Id", SqlDbType.VarChar);
                            sqlCmd.Parameters["@Id"].Value = valoresLinha[0];

                            sqlCmd.Parameters.Add("@Nome", SqlDbType.VarChar);
                            sqlCmd.Parameters["@Nome"].Value = valoresLinha[1];

                            sqlCmd.Connection.Open();
                            sqlCmd.ExecuteNonQuery();
                            sqlCmd.Connection.Close();
                        }
                    }

                    MessageBox.Show("Importação realizada com sucesso",
                                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na inserção do departamento: " + ex.Message,
                "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void ImportarFuncionarios()
        {

        }
    }
}
