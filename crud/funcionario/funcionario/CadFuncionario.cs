using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcionario
{
    internal class CadastroFuncionario
    {
        private int id;
        private string nome;
        private string email;
        private string cpf;
        private string endereco;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public bool CadastrarFuncionarios()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.conexaoServer);
                MysqlConexaoBanco.Open();

                string insert = $" insert into funcionarios (nome,email,cpf,endereco) values ('{Nome}','{Email}','{Cpf}','{Endereco}') ";
                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = insert;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método cadFuncionarios:" + ex.Message);
                return false;
            }
        }

        public MySqlDataReader LocalizarFuncionario()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.conexaoServer);
                MysqlConexaoBanco.Open();

                string select = $"select id, nome, email, cpf, endereco from funcionarios where cpf = '{Cpf}';";
                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = select;

                MySqlDataReader reader = comandoSql.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método localizarFuncionario: - " + ex.Message);
                return null;
            }
        }

        public bool atualiazarFuncionario()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.conexaoServer);
                MysqlConexaoBanco.Open();

                string update = $"update funcionarios set email = '{Email}', endereco = '{Endereco}' where id = '{Id}';";
                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = update;

                MySqlDataReader reader = comandoSql.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método atualizarFuncionario: " + ex.Message);
                return false;
            }
        }

        public bool deletarFuncionarios()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.conexaoServer);
                MysqlConexaoBanco.Open();

                string delete = $"delete from funcionarios where id = '{Id}';";
                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = delete;

                MySqlDataReader reader = comandoSql.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro banco de dados - método deletarFuncionario: " + ex.Message);
                return false;
            }
        }
    }
}
