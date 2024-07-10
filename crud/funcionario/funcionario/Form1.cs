using MySql.Data.MySqlClient;
using System.Linq.Expressions;

namespace funcionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCad_Click(object sender, EventArgs e)
        {
            try
            {
                if (!NomeTxt.Text.Equals("") && !EmailTxt.Text.Equals("") && !CpfTxt.Text.Equals("") && !EnderecoTxt.Text.Equals(""))
                {
                    CadastroFuncionario cadFuncionarios = new CadastroFuncionario();
                    cadFuncionarios.Nome = NomeTxt.Text;
                    cadFuncionarios.Email = EmailTxt.Text;
                    cadFuncionarios.Cpf = CpfTxt.Text;
                    cadFuncionarios.Endereco = EnderecoTxt.Text;

                    if (cadFuncionarios.CadastrarFuncionarios())
                    {
                        MessageBox.Show($"O funcion�rio {cadFuncionarios.Nome} foi cadastrado com sucesso !");
                        NomeTxt.Clear();
                        EmailTxt.Clear();
                        CpfTxt.Clear();
                        EnderecoTxt.Clear();
                        NomeTxt.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher todos os campos corretamente");
                    NomeTxt.Clear();
                    EmailTxt.Clear();
                    CpfTxt.Clear();
                    EnderecoTxt.Clear();
                    NomeTxt.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar funcion�rio: " + ex.Message);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CpfTxt.Text.Equals(""))
                {
                    CadastroFuncionario cadFuncionario = new CadastroFuncionario();
                    cadFuncionario.Cpf = CpfTxt.Text;

                    MySqlDataReader reader = cadFuncionario.LocalizarFuncionario();

                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            LblId.Text = reader["Id"].ToString();
                            NomeTxt.Text = reader["Nome"].ToString();
                            EmailTxt.Text = reader["Email"].ToString();
                            EnderecoTxt.Text = reader["endereco"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("Funcion�rio n�o encontrado");
                            NomeTxt.Clear();
                            EmailTxt.Clear();
                            CpfTxt.Clear();
                            EnderecoTxt.Clear();
                            CpfTxt.Focus();
                            LblId.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Funcion�rio n�o encontrado");
                        NomeTxt.Clear();
                        EmailTxt.Clear();
                        CpfTxt.Clear();
                        EnderecoTxt.Clear();
                        CpfTxt.Focus();
                        LblId.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher o cpf para pesquisa!");
                    NomeTxt.Clear();
                    EmailTxt.Clear();
                    CpfTxt.Clear();
                    EnderecoTxt.Clear();
                    CpfTxt.Focus();
                    LblId.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao localizar funcion�rio: " + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            NomeTxt.Clear();
            EmailTxt.Clear();
            CpfTxt.Clear();
            EnderecoTxt.Clear();
            CpfTxt.Focus();
            LblId.Text = "";
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CpfTxt.Text.Equals("") && !EmailTxt.Text.Equals("") && !EnderecoTxt.Text.Equals("") && !NomeTxt.Text.Equals(""))
                {
                    CadastroFuncionario cadFuncionario = new CadastroFuncionario();
                    cadFuncionario.Id = int.Parse(LblId.Text);
                    cadFuncionario.Email = EmailTxt.Text;
                    cadFuncionario.Endereco = EnderecoTxt.Text;

                    if (cadFuncionario.atualiazarFuncionario())
                    {
                        MessageBox.Show("Os dados do funcion�rio foram atualizados com sucesso!");
                        NomeTxt.Clear();
                        EmailTxt.Clear();
                        CpfTxt.Clear();
                        EnderecoTxt.Clear();
                        CpfTxt.Focus();
                        LblId.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("N�o foi poss�vel atualizar os dados");
                        NomeTxt.Clear();
                        EmailTxt.Clear();
                        CpfTxt.Clear();
                        EnderecoTxt.Clear();
                        CpfTxt.Focus();
                        LblId.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Favor lovalizar o funcion�rio que deseja a atualizar os dados");
                    NomeTxt.Clear();
                    EmailTxt.Clear();
                    CpfTxt.Clear();
                    EnderecoTxt.Clear();
                    CpfTxt.Focus();
                    LblId.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados do funcion�rio: " + ex.Message);
            }
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CpfTxt.Text.Equals("") && !EmailTxt.Text.Equals("") && !EnderecoTxt.Text.Equals("") && !NomeTxt.Text.Equals(""))
                {
                    CadastroFuncionario cadFuncionario = new CadastroFuncionario();
                    cadFuncionario.Id = int.Parse(LblId.Text);

                    if (cadFuncionario.deletarFuncionarios())
                    {
                        MessageBox.Show("Funcion�rio exclu�do com sucesso");
                        NomeTxt.Clear();
                        EmailTxt.Clear();
                        CpfTxt.Clear();
                        EnderecoTxt.Clear();
                        LblId.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("N�o foi poss�vel excluir o funcion�rio");
                        NomeTxt.Clear();
                        EmailTxt.Clear();
                        CpfTxt.Clear();
                        EnderecoTxt.Clear();
                        LblId.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Favor pesquisar qual funcion�rio deseja excluir");
                    NomeTxt.Clear();
                    EmailTxt.Clear();
                    CpfTxt.Clear();
                    EnderecoTxt.Clear();
                    CpfTxt.Focus();
                    LblId.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir funcion�rio : " + ex.Message);
            }
        }
    }
}
