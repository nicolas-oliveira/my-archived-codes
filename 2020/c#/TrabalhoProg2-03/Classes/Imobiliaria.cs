using System;
using System.Collections.Generic;

namespace Imobiliaria {
  // Classe responsável pela a criação das instâncias das classes, cadastrar e 
  // buscar por objetos nas listas
  class Imobiliaria {
      // Lista de pessoas
      public List<Cliente> clientes =  new List<Cliente>();
      public List<Funcionario> funcionarios =  new List<Funcionario>();

      // Lista de imóveis        
      public List<Casa> casas =  new List<Casa>();
      public List<Apartamento> apartamentos =  new List<Apartamento>();
      public List<Terreno> terrenos =  new List<Terreno>();

      public Imobiliaria() {}
      
      // Alguns objetos temporários criados para o teste do programa
      public void Iniciar() {
        Endereco endereco0 = new Endereco("Rua Pitanga","Califonia","Californiana","Minas Gerais","2344-34",23);
        Pessoa pessoa0 = new Pessoa("Alex Mendes","105678909-67", endereco0);
        Cliente cliente0 = new Cliente(pessoa0._cpf,pessoa0._nome,endereco0,false);
        Funcionario funcionario0 = new Funcionario(pessoa0._cpf,pessoa0._nome,endereco0,1000,0.6);
        Casa casa0 = new Casa(200,2," ","Disponivel",200,200000);
        Apartamento apartamento0 = new Apartamento();
        
        clientes.Add(cliente0);
        funcionarios.Add(funcionario0);
        casas.Add(casa0);
      }
      
      // Devido a falta de um parâmetro decente com um objeto genérico
      // esse código irá se repetir
      public void imprimeClientes(List<Cliente> lista) {
        int count = 0;
        foreach (var item in lista) {
          count++;
          if(item != null) {
            Console.WriteLine($"{item.imprimir()}");
          }
        }
        Console.WriteLine($"Numero de clientes: {count}");
        Console.Write("Digite qualquer tecla para continuar...");
        Console.ReadLine();
      }

      public void imprimeFuncionarios(List<Funcionario> lista) {
        int count = 0;
        foreach (var item in lista) {
          count++;
          if(item != null) {
            Console.WriteLine($"{item.imprimir()}");
          }
        }
        Console.WriteLine($"Numero de Funcionários: {count}");
        Console.Write("Digite qualquer tecla para continuar...");
        Console.ReadLine();
      }

      public void imprimeCasas(List<Casa> lista) {
        int count = 0;
        foreach (var item in lista) {
          count++;
          if(item != null) {
            Console.WriteLine($"{item.imprimir()}");
          }
        }
        Console.WriteLine($"Numero de Casas: {count}");
        Console.Write("Digite qualquer tecla para continuar...");
        Console.ReadLine();
      }

      public void imprimeApartamentos(List<Apartamento> lista) {
        int count = 0;
        foreach (var item in lista) {
          count++;
          if(item != null) {
            Console.WriteLine($"{item.imprimir()}");
          }
        }
        Console.WriteLine($"Numero de Casas: {count}");
        Console.Write("Digite qualquer tecla para continuar...");
        Console.ReadLine();
      }

      public void imprimeTerrenos(List<Terreno> lista) {
        int count = 0;
        foreach (var item in lista) {
          count++;
          if(item != null) {
            Console.WriteLine($"{item.imprimir()}");
          }
        }
        Console.WriteLine($"Numero de Casas: {count}");
        Console.Write("Digite qualquer tecla para continuar...");
        Console.ReadLine();
      }

      // Realiza a ação de compra e venda
      public void realizarCompra() {

      }
      // Realiza a ação de aluguel
      public void realizarAluguel() {

      }

      // Realiza o cadastro de Endereço e retorna um novo objeto Endereço
      private Endereco cadastrarEndereco() {
        string logradouro, bairro, cidade, estado, cep;
        int numero;

        Console.Write("CEP: "); 
        cep = Console.ReadLine();

        Console.Write("Nome da rua: "); 
        logradouro = Console.ReadLine();

        Console.Write("Nome do Bairro: "); 
        bairro = Console.ReadLine();

        Console.Write("Nome da Cidade: "); 
        cidade = Console.ReadLine();

        Console.Write("Nome do estado: "); 
        estado = Console.ReadLine();

        Console.Write("Numero da casa: "); 
        numero = int.Parse(Console.ReadLine());

        return new Endereco(logradouro, bairro, cidade, estado, cep, numero);
      }
      
      // Realiza o cadastro de pessoa e retorna um novo objeto Pessoa
      private Pessoa cadastrarPessoa() {
        string nome, cpf;

        Console.Write("Nome: "); 
        nome = Console.ReadLine();
        
        Console.Write("CPF: "); 
        cpf = Console.ReadLine();

        Endereco endereco = this.cadastrarEndereco();

        return new Pessoa(nome, cpf, endereco);
      }

      // Realiza o cadastro de vendedor
      public bool cadastrarVendedor() {
        double salario, percComissao;

        Console.WriteLine("Cadastro de Vendedor");
        Pessoa pessoa = this.cadastrarPessoa();
        
        Console.Write("Salário: "); 
        salario = double.Parse(Console.ReadLine());

        Console.Write("Porcentagem de Comissão: "); 
        percComissao = double.Parse(Console.ReadLine());
        Console.Clear();

        Funcionario funcionario = new Funcionario(pessoa._cpf, pessoa._nome, 
        pessoa._endereco, salario, percComissao);

        funcionarios.Add(funcionario);
        return true;
      }
      
      // Realiza o cadastro de Cliente
      public bool cadastrarCliente() {
        Console.WriteLine("Cadastro de Cliente");
        
        Pessoa pessoa = this.cadastrarPessoa();
        Cliente cliente = new Cliente(pessoa._cpf, pessoa._nome, pessoa._endereco, false);

        clientes.Add(cliente);
        Console.Clear();

        return true;
      }
      
      // Devido a falta de um retorno de objeto decente e por Imóvel 
      // ser uma classe abstrata, impossibilitando a abstração do cadastro de imóvel,
      // esse trecho de código irá se repetir.
      public bool cadastrarCasa() {
        double areaConstruida, area, valor;;
        int quadra;
        string lote, situacao;

        Console.WriteLine("Cadastro de Casa");

        Console.Write("Quadra: "); 
        quadra = int.Parse(Console.ReadLine());

        Console.Write("lote: "); 
        lote = Console.ReadLine();

        Console.Write("situacao: "); 
        situacao = Console.ReadLine();

        Console.Write("area: "); 
        area = double.Parse(Console.ReadLine());

        Console.Write("valor: "); 
        valor = double.Parse(Console.ReadLine());

        // Endereco endereco = this.cadastrarEndereco();
        // Cliente cliente = this.cadastrarCliente();

        Console.Write("Area construida: "); 
        areaConstruida = double.Parse(Console.ReadLine());

        Casa casa = new Casa(areaConstruida,quadra,lote,situacao,area,valor);
        casas.Add(casa);
        Console.Clear();

        return true;
      }

      public bool cadastrarApartamento() {
        double area, valor;
        int quadra, andar;
        string lote, situacao, condominio;

        Console.WriteLine("Cadastro de Apartamento");

        Console.Write("Quadra: "); 
        quadra = int.Parse(Console.ReadLine());

        Console.Write("lote: "); 
        lote = Console.ReadLine();

        Console.Write("situacao: "); 
        situacao = Console.ReadLine();

        Console.Write("area: "); 
        area = double.Parse(Console.ReadLine());

        Console.Write("valor: "); 
        valor = double.Parse(Console.ReadLine());

        Console.Write("Condominio: "); 
        condominio = Console.ReadLine();

        Console.Write("Andar: "); 
        andar = int.Parse(Console.ReadLine());

        Apartamento apartamento = new Apartamento(condominio,andar,quadra,lote,situacao,area,valor);
        apartamentos.Add(apartamento);
        Console.Clear();
        
        return true;
      }

      public bool cadastrarTerreno() {
        double area, valor;
        int quadra, andar;
        string lote, situacao, condominio;

        Console.WriteLine("Cadastro de Terreno");

        Console.Write("Quadra: "); 
        quadra = int.Parse(Console.ReadLine());

        Console.Write("lote: "); 
        lote = Console.ReadLine();

        Console.Write("situacao: "); 
        situacao = Console.ReadLine();

        Console.Write("area: "); 
        area = double.Parse(Console.ReadLine());

        Console.Write("valor: "); 
        valor = double.Parse(Console.ReadLine());

        Terreno terreno = new Terreno(quadra,lote,situacao,area,valor);
        terrenos.Add(terreno);
        Console.Clear();
        
        return true;
      }
  }
}