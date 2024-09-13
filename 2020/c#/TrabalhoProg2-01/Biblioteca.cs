using System;
namespace Biblioteca {
  class Pessoa {
    private string cpf, nome, rg, dataNascimento, telefone, email;
    private bool liberado;
    private Endereco endereco = new Endereco();

    // Encapsulamento dos atributos através da criação de um atributo paralelo
    // que permite a manipulação da classe
    public string _cpf { get { return this.cpf; } set { this.cpf = value; } }
    public string _nome { get { return this.nome; } set { this.nome = value; } }
    public string _rg { get { return this.rg; } set { this.rg = value; } }
    public string _dataNascimento { get { return this.dataNascimento; } set { this.dataNascimento = value; } }
    public string _telefone { get { return this.telefone; } set { this.telefone = value; } }
    public string _email { get { return this.email; } set { this.email = value; } }
    public bool _liberado { get { return this.liberado; } set { this.liberado = value; } }

    public Pessoa() {
      this.cpf = "";
      this.nome = "";
      this.rg = "";
      this.dataNascimento = "";
      this.telefone = "";
      this.email = "";
      this.liberado = true;
    }

    public Pessoa(string cpf, string nome, string rg, string dataNascimento, 
    Endereco endereco, string telefone, string email, bool liberado) {
      this.cpf = cpf;
      this.nome = nome;
      this.rg = rg;
      this.dataNascimento = dataNascimento;
      this.endereco = endereco;
      this.telefone = telefone;
      this.email = email;
      this.liberado = true;
    }

    // Método responsável por retornar a string de todos os atributos das classes
    // Que por sua vez acessa as classes correspondentes à super-classe
    public virtual string imprimir() {
      string endInfo = endereco.imprimir();
      return String.Format("Pessoa: \n  Nome: {0},\n  Email: {1},\n  Cpf: {2},\n  Telefone: {3},\n  DataDeNascimento: {4},\n  RG: {5},\n{6}",
        this._nome,
        this._email,
        this._cpf,
        this._telefone,
        this._dataNascimento,
        this._rg,
        endInfo
      );
    }
  }

  class Aluno : Pessoa {
    private string matricula, dataInicio, dataConclusao, situacao;
    private double valorDesconto;
    private Pessoa pessoa = new Pessoa();
    private Curso curso = new Curso();

    public string _matricula { get { return this.matricula; } set { this.matricula = value; } }
    public string _dataInicio { get { return this.dataInicio; } set { this.dataInicio = value; } }
    public string _dataConclusao { get { return this.dataConclusao; } set { this.dataConclusao = value; } }
    public string _situacao { get { return this.situacao; } set { this.situacao = value; } }
    public double _valorDesconto { get { return this.valorDesconto; } set { this.valorDesconto = value; } }

    public Aluno() {
      this.matricula = "";
      this.dataInicio = "";
      this.dataConclusao = "";
      this.valorDesconto = 0;
      this.situacao = "";
    }

    public Aluno(string matricula, string dataInicio, string dataConclusao, 
    double valorDesconto, string situacao, Curso curso, Pessoa pessoa) {
      this.matricula = matricula;
      this.dataInicio = dataInicio;
      this.dataConclusao = dataConclusao;
      this.valorDesconto = valorDesconto;
      this.situacao = situacao;
      this.curso = curso;
      this.pessoa = pessoa;
    }

    public bool LiberarAluno(bool liberado) {
      if (liberado) Console.WriteLine("Aluno incluso no sistema");
      else Console.WriteLine("Aluno não incluso no sistema");
      return true;
    }

    public override string imprimir() {
      string pessoaInfo = pessoa.imprimir();
      string cursoInfo = curso.imprimir();
      return String.Format("Aluno: (\n  Matrícula: {0},\n  DataInício: {1},\n  DataConclusão: {2},\n  ValorDesconto: {3},\n  Situação: {4},\n{5}{6})\n",
        this._matricula,
        this._dataInicio,
        this._dataConclusao == null || this._dataConclusao == "" ? "null" : this._dataConclusao,
        this._valorDesconto,
        this._situacao,
        cursoInfo,
        pessoaInfo
      );
    }
  }

  class Professor : Pessoa {
    private int codigo;
    private string graduacao, dataAdmissao;
    private double salario;
    private Pessoa pessoa = new Pessoa();

    public int _codigo { get { return this.codigo; } set { this.codigo = value; } }
    public string _graduacao { get { return this.graduacao; } set { this.graduacao = value; } }
    public string _dataAdmissao { get { return this.dataAdmissao; } set { this.dataAdmissao = value; } }
    public double _salario { get { return this.salario; } set { this.salario = value; } }
  
    public Professor() {
      this.codigo = 0;
      this.graduacao = "";
      this.dataAdmissao = "";
      this.salario = 0;
    }

    public Professor(int codigo, string graduacao, string dataAdmissao, double salario, Pessoa pessoa) {
      this.codigo = codigo;
      this.graduacao = graduacao;
      this.dataAdmissao = dataAdmissao;
      this.salario = salario;
      this.pessoa = pessoa;
    }

    public bool LiberarProfessor(bool liberado) {
      if (liberado) Console.WriteLine("Professor incluso no sistema");
      else Console.WriteLine("Professor não incluso no sistema");
      return true;
    }

    public override string imprimir() {
      string pessoaInfo = pessoa.imprimir();
      return String.Format("Professor: (\n  Código: {0},\n  Graduação: {1},\n  DataAdmissão: {2},\n  Salário: {3},\n{4})\n",
        this._codigo,
        this._graduacao,
        this._dataAdmissao,
        this._salario,
        pessoaInfo
      );
    }
  }
  
  class Funcionario : Pessoa {
      private int codigo;
      private string cargo, dataAdmissao;
      private double salario;
      private Pessoa pessoa = new Pessoa();

      public int _codigo { get { return this.codigo; } set { this.codigo = value; } }
      public string _cargo { get { return this.cargo; } set { this.cargo = value; } }
      public string _dataAdmissao { get { return this.dataAdmissao; } set { this.dataAdmissao = value; } }
      public double _salario { get { return this.salario; } set { this.salario = value; } }

      public Funcionario() {
        this.codigo = 0;
        this.cargo = "";
        this.dataAdmissao = "";
        this.salario = 0;
      }

      public Funcionario(int codigo, string cargo, string dataAdmissao, double salario, Pessoa pessoa) {
        this.codigo = codigo;
        this.cargo = cargo;
        this.dataAdmissao = dataAdmissao;
        this.salario = salario;
        this.pessoa = pessoa;
      }

      bool LiberarFuncionario(bool liberado) {
        if (liberado) Console.WriteLine("Funcionario incluso no sistema");
        else Console.WriteLine("Funcionario não incluso no sistema");
        return true;
      }
      public override string imprimir() {
        string pessoaInfo = pessoa.imprimir();
        return String.Format("Funcionario: (\n  Código: {0},\n  Cargo: {1},\n  DataAdmissão: {2},\n  Salário: {3},\n{4})\n",
          this._codigo,
          this._cargo,
          this._dataAdmissao,
          this._salario,
          pessoaInfo
        );
      }
  }

  class Curso {
    private string nome, area;
    private bool status;
    private double valorMensalidade;

    public string _nome { get { return this.nome; } set { this.nome = value; } }
    public string _area { get { return this.area; } set { this.area = value; } }
    public bool _status { get { return this.status; } set { this.status = value; } }
    public double _valorMensalidade { get { return this.valorMensalidade; } set { this.valorMensalidade = value; } }

    public Curso() {
      this.nome = "";
      this.area = "";
      this.valorMensalidade = 0;
    }

    public Curso(string nome, string area, double valorMensalidade) {
      this.nome = nome;
      this.area = area;
      this.valorMensalidade = valorMensalidade;
    }

    public string imprimir() {
      return String.Format("Curso: \n  Nome: {0},\n  Área: {1},\n  ValorMensalidade: {2}\n",
        this._nome,
        this._area,
        this._valorMensalidade
      );
    }
  }
  
  class Endereco {
    private string cep, rua, bairro, cidade, estado, complemento;
    private int numero;

    public string _cep { get { return this.cep; } set { this.cep = value; } }
    public string _rua { get { return this.rua; } set { this.rua = value; } }
    public string _bairro { get { return this.bairro; } set { this.bairro = value; } }
    public string _cidade { get { return this.cidade; } set { this.cidade = value; } }
    public string _estado { get { return this.estado; } set { this.estado = value; } }
    public string _complemento { get { return this.complemento; } set { this.complemento = value; } }
    public int _numero { get { return this.numero; } set { this.numero = value; } }

    public Endereco() {
      this.cep = "";
      this.rua = "";
      this.bairro = "";
      this.cidade = "";
      this.estado = "";
      this.complemento = "";
      this.numero = 0;
    }

    public Endereco(string cep, string rua, string bairro, string cidade, string estado, int numero, string complemento) {
      this.cep = cep;
      this.rua = rua;
      this.bairro = bairro;
      this.cidade = cidade;
      this.estado = estado;
      this.complemento = complemento;
      this.numero = numero;
    }

    public string imprimir() {
      return String.Format("Endereço:\n  Cep: {0},\n  Rua: {1},\n  Bairro: {2},\n  Cidade: {3},\n  Estado: {4},\n  Complemento: {5},\n  Número: {6},\n",
        this._cep,
        this._rua == "" || this._rua == null ? "null" : this._rua,
        this._bairro,
        this._cidade,
        this._estado,
        this._complemento,
        this._numero
      );
    }
  }
  
  class Emprestimo {
    private int codigo;
    private string dataEmprestimo, dataDevolucao;
    private double valorMulta;
    private Exemplar exemplar = new Exemplar();
    private Pessoa pessoa = new Pessoa();

    public int _codigo { get { return this.codigo; } set { this.codigo = value; } }
    public string _dataEmprestimo { get { return this.dataEmprestimo; } set { this.dataEmprestimo = value; } }
    public string _dataDevolucao { get { return this.dataDevolucao; } set { this.dataDevolucao = value; } }
    public double _valorMulta { get { return this.valorMulta; } set { this.valorMulta = value; } }

    public Emprestimo() {
      this.codigo = 0;
      this.dataDevolucao = "";
      this.dataEmprestimo = "";
      this.valorMulta = 0;
    }

    public Emprestimo(int codigo, string dataEmprestimo, string dataDevolucao, 
    double valorMulta, Pessoa pessoa, Exemplar exemplar) {
      this.codigo = codigo;
      this.dataDevolucao = dataDevolucao;
      this.dataEmprestimo = dataEmprestimo;
      this.valorMulta = valorMulta;
      this.exemplar = exemplar;
    }

    public string imprimir() {
      string exemplarInfo = exemplar.imprimir();
      return String.Format("Empréstimo: (\n  código: {0},\n  dataDevolução: {1},\n  dataDeEmprestimo: {2},\n  valorMulta: {3}\n{4})",
        this._codigo,
        this._dataDevolucao == "" || this._dataDevolucao == null? "null": this._dataDevolucao,
        this._dataEmprestimo,
        this._valorMulta,
        exemplarInfo
      );
    }
  }
  
  class Exemplar {
    private int codigo, nroExemplar;
    private bool exclusivo;
    private Livro livro = new Livro();

    public int _codigo { get { return this.codigo; } set { this.codigo = value; } }
    public int _nroExemplar { get { return this.nroExemplar; } set { this.nroExemplar = value; } }
    public bool _exclusivo { get { return this.exclusivo; } set { this.exclusivo = value; } }

    public Exemplar() {
      this.codigo = 0;
      this.nroExemplar = 0;
      this.exclusivo = false;
    }

    public Exemplar(int codigo, int nroExemplar, bool exclusivo, Livro livro) {
      this.codigo = codigo;
      this.nroExemplar = nroExemplar;
      this.exclusivo = exclusivo;
      this.livro = livro;
    }

    public string imprimir() {
      string livroInfo = livro.imprimir();
      return String.Format("Exemplar: \n  codigo: {0},\n  numeroExemplar: {1},\n  isExclusive: {2},\n{3}",
        this._codigo,
        this._nroExemplar,
        this._exclusivo,
        livroInfo
      );
    }
  }

  class Livro {
    private int codigo, anoLancamento, edicao;
    private string nome, autor, editora;

    public int _codigo { get { return this.codigo; } set { this.codigo = value; } }
    public int _anoLancamento { get { return this.anoLancamento; } set { this.anoLancamento = value; } }
    public int _edicao { get { return this.edicao; } set { this.edicao = value; } }
    public string _nome { get { return this.nome; } set { this.nome = value; } }
    public string _autor { get { return this.autor; } set { this.autor = value; } }
    public string _editora { get { return this.editora; } set { this.editora = value; } }

    public Livro() {
      this.codigo = 0;
      this.nome = "";
      this.autor = "";
      this.editora = "";
      this.anoLancamento = 0;
      this.edicao = 0;
    }

    public Livro(int codigo, string nome, string autor, string editora, int anoLancamento, int edicao) {
      this.codigo = codigo;
      this.nome = nome;
      this.autor = autor;
      this.editora = editora;
      this.anoLancamento = anoLancamento;
      this.edicao = edicao;
    }

    public string imprimir() {
      return String.Format("Livro: \n  codigo: {0},\n  nome: {1},\n  autor: {2},\n  editora: {3}\n  anoDeLançamento: {4}\n  edição: {5}\n",
        this._codigo,
        this._nome,
        this._autor,
        this._editora,
        this._anoLancamento,
        this._edicao
      );
    }
  }
  
  class Program {
    // A estrutura de dados de array no c# está impossibilitando a manipulação 
    // de informações no próprio array, cogita-se ao uso de List<> pois sua implementação
    // parece ser mais abstraída.
    Aluno[] alunos = new Aluno[100];
    Professor[] professores = new Professor[60];
    Funcionario[] funcionarios = new Funcionario[100];
    Curso[] cursos = new Curso[100];
    Exemplar[] exemplares = new Exemplar[100];
    Livro[] livros = new Livro[100];

    // public void imprimir(Object[] obj) {
    //   for(int i = 0; i < obj.Length; i++)
    //     if(obj[i] != null) {
    //       Console.WriteLine(obj[i].imprimir()); // Não está funcionando erro CS1061 - ??
    //     }
    //   Console.ReadLine();
    // }
    
    public Program() {
      // Informações iniciais para o teste do programa
      // Contém 3 Cursos, 3 Professores, 3 Alunos, 1 Funcionários e 1 Empréstimo
      // Para evitar o cadastro repetitivo do programa
      // Endereços e Pessoas não são arrays pois para cada categoria de pessoa
      // já tem reservado na memória a criação desses objetos, por exemplo:
      // 1 `new Professor()` ->(Cria) 1 `new Pessoa()` e 1 `new Endereço()` etc..

      // Endereços
      Endereco endereco0 = new Endereco("37803987","Ipanema Flores","Jardim Paulista", "Pindamonhagaba","SP", 22,"Casa");
      Endereco endereco1 = new Endereco("39568956","Florins Filho","Jardim Realizações", "Passos","MG", 52,"Casa");
      Endereco endereco2 = new Endereco("49568933","Varins Neves","Centro", "Passos","MG", 1800,"Apartamento");
      Endereco endereco3 = new Endereco("88186678","Rio Claro","Centro", "Ribeirão Preto","SP", 99,"Apartamento");
      Endereco endereco4 = new Endereco("19665511","Acácia","Centro", "Passos","MG", 1800,"Apartamento");
      Endereco endereco5 = new Endereco("11869533","Júnior Ferreira","Centro", "Passos","MG", 1800,"Apartamento");
      
      // Pessoas
      Pessoa pessoa0 = new Pessoa("10766543322","Nicolas Oliveira","17277888","22/03/1998", endereco0,"99876542","nome@email.com", true);
      Pessoa pessoa1 = new Pessoa("01559962457","Alex Bueno","17995586","19/07/1968", endereco1,"99876542","nome@email.com", true);
      Pessoa pessoa2 = new Pessoa("01555588165","Fernandinho","179854386","19/07/1968", endereco2,"99587456","nome@email.com", true);
      Pessoa pessoa3 = new Pessoa("81559785135","Vânia Borges","13995733","19/08/1985", endereco3,"98982563","nome@email.com", true);
      Pessoa pessoa4 = new Pessoa("21569889971","Letícia Mattar","18994673","19/08/1985", endereco4,"97856324","nome@email.com", true);
      Pessoa pessoa5 = new Pessoa("10998547231","Wallace Freitas","19236514","19/08/1985", endereco5,"96588427","nome@email.com", true);

      // Cursos
      cursos[0] = new Curso("Direito","Direito", 4500);
      cursos[1] = new Curso("Sistemas de Informação", "Tecnologia", 3500);
      cursos[2] = new Curso("Medicina", "Saúde", 10500);

      // Alunos      
      alunos[0] = new Aluno("34334","09/02/2019","",0.4,"Ativo", cursos[0], pessoa0);
      alunos[1] = new Aluno("18569","09/02/2019","",0,"Ativo", cursos[0], pessoa1);
      alunos[2] = new Aluno("97458","09/02/2019","",0.3,"Ativo", cursos[0], pessoa5);

      // Professores
      professores[0] = new Professor(34,"PHD","02/09/2017",4500, pessoa2);
      professores[1] = new Professor(34,"PHD","02/09/2017",4500, pessoa3);

      // Funcionários
      funcionarios[0] = new Funcionario(33, "Bibliotecário", "02/09/2010", 1200, pessoa4);

      // Livros, exemplares e empréstimos
      livros[0] = new Livro(1,"Dom Quixote","Cervantes","Globo",1640,6);
      livros[1] = new Livro(2,"Estruturas de Dados","Ana Fernanda","Pearson",2010,4);
      livros[2] = new Livro(3,"Conceitos de Linguagens de Programação","Robert W. Sebesta","Bookman",2011,9);
      livros[3] = new Livro(4,"Código Limpo","Robert C. Martin","AltaBooks",2009,1);

      exemplares[0] = new Exemplar(1,1,false,livros[0]);
      exemplares[1] = new Exemplar(2,2,false,livros[1]);
      exemplares[2] = new Exemplar(3,3,false,livros[2]);
      exemplares[3] = new Exemplar(4,4,false,livros[3]);

      // Emprestimo emp = new Emprestimo(1,"02/09/2020","",0,pessoa,exe);
    }
    
    static void Main(string[] args) {
      Program program = new Program();

      int op, op2, op3;

      do {
        Console.WriteLine("┌───────────────────────────────────────────────────────┐");
        Console.WriteLine("│                  ┌────────────────┐                   │");
        Console.WriteLine("│                  │   Biblioteca   │                   │");
        Console.WriteLine("│                  └────────────────┘                   │");
        Console.WriteLine("│ 1 - Criar um empréstimo;                              │");
        Console.WriteLine("│ 2 - Cadastrar Pessoa;                                 │");
        Console.WriteLine("│ 3 - Cadastrar Cursos;                                 │");
        Console.WriteLine("│ 4 - Cadastrar Livros;                                 │");
        Console.WriteLine("│ 5 - Cadastrar Exemplares;                             │");
        Console.WriteLine("│ 6 - Imprimir informações;                             │");
        Console.WriteLine("│ 0 - SAIR                                              │");
        Console.WriteLine("└───────────────────────────────────────────────────────┘");
        Console.Write(" Digite sua opção:  ");
        op = int.Parse(Console.ReadLine());
        Console.Clear();
        if(op == 2) {
          string cpf, nome, rg, dataNascimento, telefone, email;

          Console.WriteLine("Cadastro de nova pessoa:\n");
          Console.Write("CPF: "); cpf = Console.ReadLine();
          Console.Write("NOME: "); nome = Console.ReadLine();
          Console.Write("RG: "); rg = Console.ReadLine();
          Console.Write("Data de Nascimento: "); dataNascimento = Console.ReadLine();
          Console.Write("Telefone: "); telefone = Console.ReadLine();
          Console.Write("Email: "); email = Console.ReadLine();
          Console.Clear();
          do {
            Console.WriteLine("Escolha um opção para cadastrar:\n");
            Console.WriteLine("1 - Aluno;");
            Console.WriteLine("2 - Professor;");
            Console.WriteLine("3 - Funcionário;\n");
            Console.WriteLine("0 - Sair sem salvar;\n");
            Console.Write("Digite sua opção:  ");
            op2 = int.Parse(Console.ReadLine());
            Console.Clear();
              if(op2 == 1) {
                string matricula, dataInicio, dataConclusao, situacao;
                double valorDesconto;
                
                Console.WriteLine("Cadastro de aluno:\n");
                Console.Write("Matricula: "); matricula = Console.ReadLine();
                Console.Write("Data de Inicio: "); dataInicio = Console.ReadLine();
                Console.Write("Data de conclusão: "); dataConclusao = Console.ReadLine();
                Console.Write("Situação: "); situacao = Console.ReadLine();
                // Não encontrei uma forma decente de impedir qualquer tecla que fuja da tipagem definida. 
                // Caso o usuário escreva algo fora da tipagem o programa crasha
                Console.Write("Valor de desconto: "); valorDesconto = int.Parse(Console.ReadLine()); 
                // Falta finalizar
              }
              if(op2 == 2) {
                int codigo;
                string graduacao, dataAdmissao;
                double salario;
                
                Console.WriteLine("Cadastro de Professor:\n");
                Console.Write("Codigo: "); codigo = int.Parse(Console.ReadLine());
                Console.Write("Data de Admissão: "); dataAdmissao = Console.ReadLine();
                Console.Write("Salario: "); salario = double.Parse(Console.ReadLine());
                // Falta finalizar
              }
              if(op2 == 3) {
                // Finalizar
              }
              op2 = 0;
              Console.Clear();
          } while(op2 != 0);
        }
        if(op == 3) {
            // Falta finalizar
        }
        if(op == 4) {
          // Finalizar
        }
        if(op == 5) {
          // Finalizar
        }
        if (op == 6) {
          do {
            Console.WriteLine("Escolha um opção para imprimir:\n");
            Console.WriteLine("1 - Pessoa;");
            Console.WriteLine("2 - Cursos;");
            Console.WriteLine("3 - Livros;");
            Console.WriteLine("4 - Empréstimos;\n");
            Console.WriteLine("0 - Voltar;\n");
            Console.Write("Digite sua opção:  ");
            op2 = int.Parse(Console.ReadLine());
            Console.Clear();
            if(op2 == 1) {
              do {
                Console.WriteLine("Escolha a pessoa a ser impressa:\n");
                Console.WriteLine("1 - Alunos;");
                Console.WriteLine("2 - Professores;");
                Console.WriteLine("3 - Funcionários;\n");
                Console.WriteLine("0 - Voltar;\n");
                Console.Write("Digite sua opção:  ");
                op3 = int.Parse(Console.ReadLine());
                Console.Clear();
                if(op3 == 1) {
                  // Devido a falta de uma forma decente de uma função que recebe 
                  // como parâmetro um array de objetos, este código irá 
                  // se repetir ao decorrer do Código Fonte inteiro.
                  for(int i = 0; i < program.alunos.Length; i++)
                    if(program.alunos[i] != null) {
                      Console.WriteLine(program.alunos[i].imprimir()); 
                    }
                  Console.ReadLine();
                }
                if(op3 == 2) {
                  for(int i = 0; i < program.professores.Length; i++)
                    if(program.professores[i] != null) {
                      Console.WriteLine(program.professores[i].imprimir()); 
                    }
                  Console.ReadLine();
                }
                if(op3 == 3) {
                  for(int i = 0; i < program.funcionarios.Length; i++)
                    if(program.funcionarios[i] != null) {
                      Console.WriteLine(program.funcionarios[i].imprimir()); 
                    }
                  Console.ReadLine();
                }
                Console.Clear();
              } while(op3 != 0);

            }
            if(op2 == 2) {
              for(int i = 0; i < program.cursos.Length; i++)
                if(program.cursos[i] != null) {
                  Console.WriteLine(program.cursos[i].imprimir()); 
                }
              Console.ReadLine();
            }
            Console.Clear();
          } while(op2 != 0);
        }
      } while(op != 0);
    }
  }
}
