/*
 * Alex Bueno, Gabriel Cokin, Nicolas Oliveira, Guilherme Guimarães
 */
import java.net.*; // importando a biblioteca java.net, responsavel pelas conexões da aplicação.
import java.text.SimpleDateFormat;
import java.io.*;//  importando a biblioteca java.io, responsavel pelos inputs e outputs.adicionado.
import java.time.LocalDate;
import java.time.LocalTime;
import java.time.format.DateTimeFormatter;
import java.time.format.FormatStyle;
import java.util.Date;
import java.lang.management.*;
import com.sun.management.OperatingSystemMXBean;

/*
 * Criação da classe connection, que EXTENDE, thread uma classe que gera um processo para 
 * fazer as conexões de entrada e saida do TCP.
 */

public class Connection extends Thread { // Instanciação da classe connection extendendo thread.
    public static int i = 0;
    DataInputStream in; // Instanciação da Entrada de dados chamada in.
		DataOutputStream out; // Instanciação da Saída de dados chamada out.
		Socket clientSocket; // Instaciação do socket que fará a comunicação de dados TCP.
    public Connection(Socket aClientSocket) {// Construtor da classe connection
		/*
         * Bloco try-catch-finally. Primeiro o aplicativo irá tentar estanciar os dados de entrada e saida.
         * Caso encontre uma falha, o catch pega essa exceção. Se tudo correr bem, faz o bloco finally.
         */
        try{// Início bloco try.
			clientSocket = aClientSocket; //Instanciação do clientsocket pelo argumento recebido na função.
			in = new DataInputStream(clientSocket.getInputStream()); // Intanciação dos dados de entrada.
			out = new DataOutputStream(clientSocket.getOutputStream()); // Instanciação dos dados de saída.
			this.start(); // Start o construtor.
		}catch(IOException e) { // Catch da exceção de IO.
			System.out.println("Connections: "+e.getMessage());// envio da mensagem de exceção de IO.
		}// Fim bloco catch
	}// Fim bloco construtor.

    /*
     * Função que dará inicio as leituras dos dados, que irá transferir o dado de um local para outro.
     */
    public void run(){ // Início da função run
        /*
         * Bloco try-catch-finally. Primeiro o aplicativo irá tentar estanciar os dados de entrada e saida.
         * Caso encontre uma falha, o catch pega essa exceção. Se tudo correr bem, faz o bloco finally.
         */
         
         try{ // Início do bloco try.
            String data = in.readUTF();// Instanciação de uma string que vai receber os dados de entrada convertido em UTF.
            System.out.println("MENSAGEM RECEBIDA DO CLIENTE: " + data); // Envio de mensagem recebida.
            OperatingSystemMXBean osBean = ManagementFactory.getPlatformMXBean(OperatingSystemMXBean.class);
            /*
             * Laço switch que irá processar o pedido feito pelo Cliente:
             * 1) -help: o servidor enviara uma mensagem sobre como fazer a requisição pedida.
             * 2) cpu: o servidor fará o processamento sobre a porcentagem de uso da cpu. O indice varia de 0 a 1. Sendo 0 em estado de repouso,
             * e 1 carga máxima. Vale ressaltar que o calcúlo do do sistema é em base da JVM.
             * 3) default: qualquer paramêtro enviado diferente de cpu ou -help é considerado um erro. Portanto uma mensagem de erro é enviado.
             */

            switch (data.toLowerCase()){ // Início do switch com o parametro de data.tolowercase(), por que o usuário pode colocar CPU ou cpu que podem ser aceitos.
				default: // Início do caso default.
					out.writeUTF("ERRO1: PARAMÊTRO DE FUNÇÃO INCORRETO. \nUtilize [CPU] ou [cpu] para ler os dados do servidor. \nOu utilize -help para ajuda. Ex: java TcpCliente -help [IP do servidor]. \n*CONEXÃO FECHADA* "); // Mensagem de erro default.
					break; // Quebra do caso default.

				case "-help": // Início do caso -help.
                    out.writeUTF("AJUDA, PARÂMETROS UTILIZADOS: \n[CPU] ou [cpu] -> mostra tabela de consumo de cpu. \nPara entrar um comando, digite: \njava TcpCliente [CPU] ou [cpu] [IP do servidor]. \n*CONEXÃO FECHADA*"); // Mensagem de ajuda.
                    break; // Quebra do caso -help.
					
				case "cpu": // Início do caso "cpu". Caso o digitar CPU ou CpU ou cPu, o código entederá como cpu e computará.
                    /*
                    * Nesse caso o código criará uma array de string de tamanho 10, e fará um laço que instanciará os valores 
                    * do uso do cpu, bem como a hora de cada laço.
                    */ 
                    String [] table = new String[13]; // Instanciação da array de string table.
                    double soma = 0; // Definição da váriavel que irá capturar os tempos de carga do cpu.
                    table[0] = "N°  |   DATA   | HORA |  USO DA CPU";  // Instanciação da primeira casa da array string table.
                    
                    for (int i = 1; i < 11; i++ ){ // Laço for para instanciação da array string table.
                        double cargacpu = osBean.getCpuLoad(); // Obter o tempo de carga do cpu.
                        String cpu = String.format("%.5f", cargacpu * 100);// Instanciação do cpu, em formatação para leitura de 5 digitos.   
                        soma += cargacpu; // Para obter a carga média calculado.
                        table[i] = i + ")   |" + LocalDate.now().format(DateTimeFormatter.ofLocalizedDate(FormatStyle.SHORT)) + // Instanciação da array string table.
                        " | " + LocalTime.now() + " | " +cpu + "%";
                        /**
                         * Como será utilizado o sleep para fazer o calculo do tempo medio de CPU,é necessário o sleep
                         * para fazer o sistema esperar um tempo para funcionar.
                         */
                        try { // Início do bloco try.
                            sleep(1000); // Instanciando o metódo para 1 segundo de espera.
                        } catch (InterruptedException e) { // Catch da exceção de Interrupted Exception.
                            // TODO Auto-generated catch block
                            e.printStackTrace();// Mensagem de exceção de interrupção.
                        } // Fim bloco try 
                    }// Fim do bloco for
                    table[11] = "Média das cargas de CPU foi: " + String.valueOf(String.format("%.5f", soma * 10) + "%"); // Instanciação da carga média da JVM.
                    table[12] = "Tempo total do processo foi de: 10 segundos"; // Mensagem do tempo total do processo.
                    String finaltable = String.join("\n",table); // Para colocar para enviar mensagem para o cliente, é preciso mandar a mansagem para o dataoutputstream.
                    // Para isso, converte cria-se uma array juntando todas as strings de table separando- os com \n, que na hora de enviar para o Cliente, na leitura irá pular uma
                    // linha.
                    out.writeUTF(finaltable); // Envio de finaltable para leitura no TcpCliente.
                    break; // Fim do caso cpu.
			}// Fim do switch
            out.writeUTF(data); // Conversão dos dados de saída em UTF.
        }catch(EOFException e){ //Captura da exceção de final de arquivo.
            System.out.println("EOF: " +  e.getMessage()); // Envio de mensagem da exceção capturada.
        }catch(IOException e) { // Captura da exceção de IO.
            System.out.println("IO: " + e.getMessage()); // Envio de mensagem da exceção capturada.
        }finally{// Bloco finally realizdo caso nenhuma exceção seja capturada.
            try{ // Inicio do try dentro do finally.
                clientSocket.close(); // Fechando o socket de client aberto.
            }catch(IOException e){ // Exceção de IO.
                System.out.println("IO: " + e.getMessage()); // Envio de mensagem de exceção de IO.
            }// Fim bloco catch.
        }// Fim bloco finally.
    } //Fim da função run.
} // Fim da classe connection.

