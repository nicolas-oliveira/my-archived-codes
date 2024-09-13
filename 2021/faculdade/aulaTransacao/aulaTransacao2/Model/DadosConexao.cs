﻿using System;
namespace aulaTransacao.Model {
    public class DadosConexao {
        public string host { get; set; }
        public string user { get; set; }
        public string password { get; set; }
        public string dataBase { get; set; }
        public int port { get; set; }

        public DadosConexao(string host, string user, string password, string dataBase, int port) {
            this.host = host;
            this.user = user;
            this.dataBase = dataBase;
            this.port = port;
        }
    }
}
