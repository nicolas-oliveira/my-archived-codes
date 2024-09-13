using System;
using System.Collections.Generic;
using System.Text;

namespace Imobiliaria {
  // Inicio do programa
  class Principal {
    public static void Main() {
      // Obtém todas as instâncias das classes em forma de lista
      // Contém os métodos de cadastro, busca etc..
      Imobiliaria imob = new Imobiliaria();

      // Cria nomes temporários para o cadastro
      imob.Iniciar();

      // Variáveis que armazenam as escolhas do usuário
      int op, op2, op3;

      // Loop de repetição do menu 
      do {
        Console.WriteLine("    Chaves Imobiliaria");
        Console.WriteLine("----------------------------");
        Console.WriteLine("1 - Alugar ou Comprar imóvel");
        Console.WriteLine("2 - Realizar consulta");
        Console.WriteLine("3 - Cadastrar Pessoa");
        Console.WriteLine("4 - Cadastrar Imóvel\n");
        Console.WriteLine("0 - Sair\n");

        Console.Write("Escolha uma opção: ");
        op = int.Parse(Console.ReadLine());
        Console.Clear();

        // Alugar ou comprar imoveis
        if(op == 1) {
          do{
            Console.Clear();
            Console.WriteLine("1 - Comprar imóvel");
            Console.WriteLine("2 - Alugar imóvel\n");
            Console.WriteLine("0 - Voltar\n");
            Console.Write("Escolha uma opção: ");
            op2 = int.Parse(Console.ReadLine());
            // Comprar Imóvel
            if(op2 == 1) {

            }
            // Alugar Imóvel
            if(op2 == 2) {

            }
          } while(op2 != 0);
        }

        // Realizar consulta
        if(op == 2) {
          do{
            Console.WriteLine("1 - Consultar situação dos imóveis");
            Console.WriteLine("2 - Consultar clientes");
            Console.WriteLine("3 - Consultar funcionários\n");
            Console.WriteLine("0 - Voltar\n");
            Console.Write("Escolha uma opção: ");
            op2 = int.Parse(Console.ReadLine());
            Console.Clear();
            // Consultar imóvel
            if(op2 == 1) {
              do {
                Console.WriteLine("1 - Casa");
                Console.WriteLine("2 - Apartamento");
                Console.WriteLine("3 - Terreno\n");
                Console.WriteLine("0 - Voltar\n");
                Console.Write("Escolha uma opção: ");
                op3 = int.Parse(Console.ReadLine());
                Console.Clear();
                if(op3 == 1) {
                  // imob.busca(imob.casas);
                }
                if(op3 == 2) {
                  // imob.busca(imob.apartamentos);
                }
                if(op3 == 3) {
                  // imob.busca(imob.terrenos);
                }
              } while(op3 != 0);
            }
            // Consultar clientes
            if(op2 == 2) {
              imob.imprimeClientes(imob.clientes);
              Console.Clear();
            }
            // Consultar Funcionários
            if(op2 == 3) {
              imob.imprimeFuncionarios(imob.funcionarios);
              Console.Clear();
            }
          } while(op2 != 0);
        }
        
        // Cadastrar Pessoa
        if(op == 3) {
          do {
            Console.WriteLine("1 - Novo cliente");
            Console.WriteLine("2 - Novo Vendedor\n");
            Console.WriteLine("0 - Voltar\n");
            Console.Write("Escolha uma opção: ");
            op2 = int.Parse(Console.ReadLine());
            Console.Clear();

            // Cliente
            if(op2 == 1) {
              bool cadastro = imob.cadastrarCliente();

              if(cadastro) {
                Console.WriteLine("Cliente cadastrado com sucesso!");
              } else {
                Console.WriteLine("Ocorreu um erro no cadastro!");
              }
            }
            // Vendedor
            if(op2 == 2) {
              bool cadastro = imob.cadastrarVendedor();

              if(cadastro) {
                Console.WriteLine("Vendedor cadastrado com sucesso!");
              } else {
                Console.WriteLine("Ocorreu um erro no cadastro!");
              }
            }
          } while (op2 != 0);
        }
        
        // Cadastrar Imóvel
        if(op == 4) {
          do {
            Console.WriteLine("1 - Nova Casa");
            Console.WriteLine("2 - Novo Apartamento");
            Console.WriteLine("3 - Novo Terreno\n");
            Console.WriteLine("0 - Voltar\n");
            Console.Write("Escolha uma opção: ");
            op2 = int.Parse(Console.ReadLine());
            Console.Clear();
            // Nova casa
            if(op2 == 1) {
              bool cadastro = imob.cadastrarCasa();

              if(cadastro) {
                Console.WriteLine("Casa cadastrada com sucesso!");
              } else {
                Console.WriteLine("Ocorreu um erro no cadastro!");
              }
            }
            // Novo apartamento
            if(op2 == 2) {
              bool cadastro = imob.cadastrarApartamento();

              if(cadastro) {
                Console.WriteLine("Apartamento cadastrado com sucesso!");
              } else {
                Console.WriteLine("Ocorreu um erro no cadastro!");
              }
            }
            // Novo terreno
            if(op2 == 3) {
              bool cadastro = imob.cadastrarTerreno();

              if(cadastro) {
                Console.WriteLine("Terreno cadastrado com sucesso!");
              } else {
                Console.WriteLine("Ocorreu um erro no cadastro!");
              }
            }
          }while(op2 != 0);
        }
      } while (op != 0);
    }
  }
}