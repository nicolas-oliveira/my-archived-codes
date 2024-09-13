using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using aulaTransacao.Model;

namespace aulaTransacao.Controller {
    public class ConexaoDB {
        MySqlConnection conexao = new MySqlConnection();
        DadosConexao dadosConexao = null;

        public ConexaoDB(DadosConexao dadosConexao) {

        }

        public bool conectar() {
            if(dadosConexao != null) {
                try {
                    if(conexao.State == System.Data.ConnectionState.Open)
                        desconectar();

                    string sql = "Server=" + dadosConexao.host.Trim() + ";" +
                                 "Database=" + dadosConexao.dataBase.Trim() + ";" +
                                 "Uid=" + dadosConexao.user.Trim() + ";" +
                                 "Pwd=" + dadosConexao.password.Trim() + ";" +
                                 "Connections Timeout=900;" +
                                 "Port" + dadosConexao.port.ToString() + ";";
                    conexao = new MySqlConnection(sql);
                    conexao.Open();
                    return true;
                } catch (Exception err) {
                    MessageBox.Show("Erro ao conectar com o banco de dados:\n" + err.ToString(), "Aplicacao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            } else {
                MessageBox.Show("Nenhum banco de dados foi encontrado.", "Aplicacao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool desconectar() {
            try {
                if (conexao.State == System.Data.ConnectionState.Open)
                    desconectar();
                return true;
            } catch (Exception err) {
                MessageBox.Show("Erro ao desconectar com o banco de dados:\n" + err.ToString(), "Aplicacao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
