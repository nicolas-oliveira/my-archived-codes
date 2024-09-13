using System;

namespace TRABALHOPROGRAMACAO {
  class Program {
    static void Main(string[] args) {
      Curso curso = new Curso();
      Pessoa pessoa;
      Endereço endereco;
      Livro livro;
      Exemplar exemplo;
      Emprestimo emprest;

      int opcao;
      int nlivro = 0; // para conseguir inserir livros no array em ordem
      int VerificarLivro = 0; //As variaveis de verificação irão validar as inserções necessárias validando os pré requisitos para cadastrar exemplar e emprestimo
      int VerificarExemplar = 0;
      do {
        System.Console.Clear();
        Console.WriteLine("MENU");
        Console.WriteLine("1 - Cadastrar Cursos");
        Console.WriteLine("2 - Cadastrar Pessoas");
        Console.WriteLine("3 - Cadastrar Livros");
        Console.WriteLine("4 - Cadastrar Exemplares");
        Console.WriteLine("5 - Cadastrar Emprestimos");
        Console.WriteLine("6 - Cadastrar Enderecos");
        Console.WriteLine("7 - Sair");
        Console.WriteLine("Digite a opcao desejada: ");
        int op = int.Parse(Console.ReadLine());
        switch (op) {
        case 1:
          {
            Console.WriteLine("Digite o nome do curso:");
            string nomecurso = Console.ReadLine();
            curso.setNome(nomecurso);
            string Area = Console.ReadLine();
            curso.setArea(Area);
            "\nDigite o valor da mensalidade:";
            cin >> mensal;

            curso1.nome = setNome(Ar);
            curso1.setValorMensalidade(mensal);
            curso1.cadastrar();
            cout << "Curso: " << curso1.getNome() << endl;
            cout << "Area: " << curso1.getArea() << endl;
            Console.WriteLine(curso1.getValorMensalidade());

            system("pause");
            break;
          }
        case 2: {
            do {
              cout << "\n1 - Alunos\n";
              cout << "\n2 - Professores\n";
              cout << "\n3 - Funcionarios\n";
              cout << "\n4 - Voltar ao menu anterior\n";
              cout << "\nSua opcao:";
              cin >> opcao;

              switch (opcao) {
              case 1: {
                  std::string nome;
                  string cpf;
                  string rg;
                  std::string curso;
                  string telefone;
                  string email;
                  Endereco ende;
                  std::string dataInicio;
                  std::string dataConclusao;
                  std::string dataNa;

                  string matri;
                  double valorDescont;
                  std::string situac;

                  cout << "\nDigite o nome:";
                  setbuf(stdin, NULL);
                  std::getline(std::cin, nome);
                  cout << "\nDigite o cpf:";
                  cin >> cpf;
                  cout << "\nDigite o rg:";
                  cin >> rg;
                  cout << "\nDigite a matricula:";
                  cin >> matri;
                  cout << "\nDigite o valor do desconto:";
                  cin >> valorDescont;
                  cout << "\nDigite o curso:";
                  setbuf(stdin, NULL);
                  std::getline(std::cin, curso);
                  cout << "\nDigite a situacao do aluno (aprovado ou reprovado):";
                  setbuf(stdin, NULL);
                  std::getline(std::cin, situac);
                  cout << "\nDigite a data de inicio (_/_/_):";
                  setbuf(stdin, NULL);
                  std::getline(std::cin, dataInicio);
                  cout << "\nDigite a data de conclusao (_/_/_):";
                  setbuf(stdin, NULL);
                  std::getline(std::cin, dataConclusao);
                  cout << "\nDigite a data de nascimento (_/_/_):";
                  setbuf(stdin, NULL);
                  std::getline(std::cin, dataNa);

                  cout << "\nDigite o telefone:";
                  cin >> telefone;
                  cout << "\nDigite o email:";
                  cin >> email;
                  //Criar um método construtor exigido no trabalho enchuga para apenas uma linha

                  ende.inserirEndereco();
                  alun.setEndereco(ende);
                  alun.cadastrarAluno();
                  alun.setNome(nome);
                  alun.setCpf(cpf);
                  alun.setCurso(curso);
                  alun.setRg(rg);
                  alun.setDataNascimento(dataNa);
                  alun.setTelefone(telefone);
                  alun.setEmail(email);
                  alun.setMatricula(matri);
                  alun.setDataInicio(dataInicio);
                  alun.setDataConclusao(dataConclusao);
                  alun.setValorDesconto(valorDescont);
                  alun.setSituacao(situac);

                  cout << "Cpf: " << alun.getCpf() << endl;
                  cout << "Nome: " << alun.getNome() << endl;
                  cout << "Rg: " << alun.getRg() << endl;
                  cout << "Data de Nascimento: " << alun.getDataNascimento() << endl;
                  cout << "Telefone: " << alun.getTelefone() << endl;
                  cout << "Email: " << alun.getEmail() << endl;
                  cout << "Matricula: " << alun.getMatricula() << endl;
                  cout << "Curso: " << alun.getCurso() << endl;
                  cout << "Data de inicio: " << alun.getDataInicio() << endl;
                  cout << "Data de conclusao: " << alun.getDataConclusao() << endl;
                  cout << "Valor do desconto: " << alun.getValorDesconto() << endl;
                  cout << "Situacao: " << alun.getSituacao() << endl;

                  system("pause");
                }
                break;

              case 2: {
                  std::string nome;
                  string cpf;
                  string rg;
                  std::string dataAdmis;
                  string telefone;
                  string email;
                  Endereco ender;
                  int codigo;
                  std::string graduacao;
                  double salar;
                  std::string dataN;

                  cout << "\nDigite o nome:";
                  setbuf(stdin, NULL);
                  std::getline(std::cin, nome);
                  cout << "\nDigite o cpf:";
                  cin >> cpf;
                  cout << "\nDigite o rg:";
                  cin >> rg;
                  cout << "\nDigite o telefone:";
                  cin >> telefone;
                  cout << "\nDigite o email:";
                  cin >> email;
                  cout << "\nDigite o codigo:";
                  cin >> codigo;
                  cout << "\nDigite a graduacao:";
                  setbuf(stdin, NULL);
                  std::getline(std::cin, graduacao);
                  cout << "\nDigite a data de admissao (_/_/_):";
                  setbuf(stdin, NULL);
                  std::getline(std::cin, dataAdmis);
                  cout << "\nDigite o salario:";
                  cin >> salar;
                  cout << "\nDigite a data de nascimento (_/_/_):";
                  setbuf(stdin, NULL);
                  std::getline(std::cin, dataN);

                  //Criar um método construtor exigido no trabalho enchuga para apenas uma linha
                  ender.inserirEndereco();
                  prof.setEndereco(ender);
                  prof.cadastrarProfessor();
                  prof.setNome(nome);
                  prof.setCpf(cpf);
                  prof.setRg(rg);
                  prof.setTelefone(telefone);
                  prof.setGraduacao(graduacao);
                  prof.setEmail(email);
                  prof.setCodigo(codigo);
                  prof.setDataAdmissao(dataAdmis);
                  prof.setSalario(salar);
                  prof.setDataNascimento(dataN);

                  cout << "\nNome: " << prof.getNome() << endl;
                  cout << "Cpf: " << prof.getCpf() << endl;
                  cout << "Rg: " << prof.getRg() << endl;
                  cout << "Telefone: " << prof.getTelefone() << endl;
                  cout << "E-mail: " << prof.getEmail() << endl;
                  cout << "Codigo: " << prof.getCodigo() << endl;
                  cout << "Graduacao: " << prof.getGraduacao() << endl;
                  cout << "Data de admissao: " << prof.getDataAdmissao() << endl;
                  cout << "Salario: " << prof.getSalario() << endl;
                  cout << "Data de nascimento: " << prof.getDataNascimento() << endl;
                  system("pause");
                }
                break;

              case 3:
                {
                  std::string nome;
                  string cpf;
                  string rg;
                  std::string dataNasc;
                  string telefone;
                  string email;
                  Endereco endere;
                  int codigo;
                  std::string cargo;
                  std::string dataAdmissao;
                  double salario;

                  cout << "\nDigite o nome:";
                  setbuf(stdin, NULL);
                  std::getline(std::cin, nome);
                  cout << "\nDigite o cpf:";
                  cin >> cpf;
                  cout << "\nDigite o rg:";
                  cin >> rg;
                  cout << "\nDigite o telefone:";
                  cin >> telefone;
                  cout << "\nDigite o email:";
                  cin >> email;
                  cout << "\nDigite o codigo:";
                  cin >> codigo;
                  cout << "\nDigite o salario:";
                  cin >> salario;
                  cout << "\nDigite o cargo:";
                  setbuf(stdin, NULL);
                  std::getline(std::cin, cargo);
                  cout << "\nDigite a data de nascimento (_/_/_):";
                  setbuf(stdin, NULL);
                  std::getline(std::cin, dataNasc);

                  //Criar um método construtor exigido no trabalho enchuga para apenas uma linha
                  endere.inserirEndereco();
                  func.setEndereco(endere);
                  func.cadastrarFuncionario();
                  func.setNome(nome);
                  func.setCpf(cpf);
                  func.setCargo(cargo);
                  func.setRg(rg);
                  func.setTelefone(telefone);
                  func.setEmail(email);
                  func.setCodigo(codigo);
                  func.setSalario(salario);
                  func.setDataNascimento(dataNasc);

                  cout << "\nNome: " << func.getNome() << endl;
                  cout << "Cpf: " << func.getCpf() << endl;
                  cout << "Rg: " << func.getRg() << endl;
                  cout << "Telefone: " << func.getTelefone() << endl;
                  cout << "Email: " << func.getEmail() << endl;
                  cout << "Codigo: " << func.getCodigo() << endl;
                  cout << "Salario: " << func.getSalario() << endl;
                  cout << "Cargo: " << func.getCargo() << endl;
                  cout << "Data de nascimento: " << func.getDataNascimento() << endl;

                  system("pause");
                }
                break;
              }

              //system("pause");
            }
            while ( opcao != 4 );
            //fechamento caso 2
          }
          break;
        case 3:
          {
            int cod = 0;
            string n = "";
            string aut = "";
            string anoLanc = "";
            string edit = "";
            string edic = "";

            system("cls");

            cout << "\nDigite o codigo do livro:";
            cin >> cod;
            cout << "\nDigite o nome do livro:";
            setbuf(stdin, NULL);
            std::getline(std::cin, n);
            cout << "\nDigite o autor do livro:";
            setbuf(stdin, NULL);
            std::getline(std::cin, aut);
            cout << "\nDigite o ano de lancamento do livro:";
            setbuf(stdin, NULL);
            std::getline(std::cin, anoLanc);
            cout << "\nDigite a editora do livro:";
            setbuf(stdin, NULL);
            std::getline(std::cin, edit);
            cout << "\nDigite a edicao do livro:";
            setbuf(stdin, NULL);
            std::getline(std::cin, edic);

            livro[nlivro] = Livro(cod, n, aut, anoLanc, edit, edic);

            system("cls");

            cout << "\nCodigo do livro: " << livro[nlivro].getCodigo() << endl;
            cout << "Nome do livro: " << livro[nlivro].getNome() << endl;
            cout << "Autor do livro: " << livro[nlivro].getAutor() << endl;
            cout << "Ano de lancamento do livro: " << livro[nlivro].getAnoLancamento() << endl;
            cout << "Editora do livro: " << livro[nlivro].getEditora() << endl;
            cout << "Edicao do livro: " << livro[nlivro].getEdicao() << endl;
            VerificarLivro = true; // Validação - Irá validar a inserção de livro, assim o programa saberá que tem pelo menos um livro cadastrado
            nlivro++;
            system("pause");

          }
          break;

        case 4:
          {
            //inserido IF para verificar se algum livro foi cadastrado, impedindo o cadastro de exemplar sem cadastrar um livro.
            if (!VerificarLivro) {
              system("cls");
              cout << "\nNENHUM LIVRO FOI CADASTRADO. FAVOR, INSIRA ALGUM LIVRO PARA POSTERIORMENTE CADASTRAR O EXEMPLAR\n\n";
              system("pause");
            }
            else {

              int cod;
              int nroExemplar;
              Livro livro;
              bool exclusivo;

              system("cls");

              cout << "\nDigite o codigo do exemplar:";
              cin >> cod;
              cout << "\nDigite o numero do exemplar:";
              cin >> nroExemplar;

              exemplo.cadastrarE();

              VerificarExemplar = true; // Validação - Irá validar a inserção de Exemplar, assim o programa saberá que tem pelo menos um exemplar cadastrado

              system("pause");
            }

          }
          break;

        case 5:
          {
            //inserido IF para verificar se algum livro foi cadastrado, impedindo o cadastro de exemplar sem cadastrar um livro.
            if (!VerificarExemplar) {
              system("cls");
              cout << "\nNENHUM EXEMPLAR FOI CADASTRADO. FAVOR, INSIRA ALGUM EXEMPLAR PARA POSTERIORMENTE CADASTRAR O EMPRESTIMO\n\n";
              system("pause");
            }
            else {
              int codi;
              string dataEmprestimo;
              string dataDevolucao;
              double valorMulta;

              system("cls");

              cout << "\nDigite o codigo do emprestimo:";
              cin >> codi;
              cout << "\nDigite a data do emprestimo:";
              cin >> dataEmprestimo;
              cout << "\nDigite a data de devolucao:";
              cin >> dataDevolucao;
              cout << "\nDigite o valor da multa:";
              cin >> valorMulta;

              //metodo de construção e inserção inserido
              emprest = Emprestimo(codi, dataEmprestimo, dataDevolucao, valorMulta);

              system("pause");
            }
          }
          break;
          //fechamento switch
        case 6:
          endereco.inserirEndereco();
          break;
        }
      }
      while ( op != 7 );
    }
  }
}
}