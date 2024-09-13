/*
 * Alex Bueno, Gabriel Cokin, Nicolas Oliveira, Guilherme Guimarães
 */
import java.net.*;// importando a biblioteca java.net, responsavel pelas conexões da aplicação.
import java.io.*;//  importando a biblioteca java.io, responsavel pelos inputs e outputs.adicionado.
/*
 *  Iniciação da classe TcpCliente que fara a conexão com o servidor.
 */
public class TcpCliente{// Início da classe TcpCliente.
	public static void main(String args[]){ // Início da função principal de TcpCliente.
		Socket s = null; // Instanciação do Socket nulo;
		/*
         * Bloco try-catch-finally. Primeiro o aplicativo irá tentar estanciar os dados de entrada e saida.
         * Caso encontre uma falha, o catch pega essa exceção. Se tudo correr bem, faz o bloco finally.
         */		
		try { // Início do bloco try.
			int serverPort = 7896; // Instanciação da porta de conexão com o servidor.
			s = new Socket(args[1],serverPort); // Instanciação do socket na porta 7896 recebendo argumento na posição 1
			DataInputStream in = new DataInputStream(s.getInputStream()); // Instanciação do dado de entrada.
			DataOutputStream out = new DataOutputStream(s.getOutputStream());// Instanciação do dado de saída.
			out.writeUTF(args[0]); // Escrita da string na posição 0.
			String data = in.readUTF(); // Leitura do dado de entrada.
			/**
			 * Laço para receber os dados do servidor e fazer a leitura para o cliente. Usando o for para lançar as leituras dos dados para o Cliente
			 */
			if (args[0].toLowerCase() == "cpu"){ // Se o parametro do argumento em 0 for igual a "cpu" em minuscula, inicia-se o if.
				for (int i = 0; i < 11; i++){ // Incio do laço for.
					System.out.println(data); // Liberando as saídas dos dados para o Cliente.
				}// Fim laço for
			}else{// Fim if e início se caso for outros paramêtros de entrada.
				System.out.println(data); // Saida da mensagem de recebido.
			}// Fim else.
		}catch(UnknownHostException e) { // Exceção de host desconhecido.
			System.out.println("Sock: " + e.getMessage()); // Mensagem de exceção de host desconhecido.
		}catch(EOFException e){// Exceção de fim de arquivo.
			System.out.println("EOF: " + e.getMessage()); // Mensagem de exceção de fim de arquivo.
		}catch(IOException e){// Exceção de IO.
			System.out.println("IO: " + e.getMessage()); // Mensagem de exceção de IO.
		}finally{ // Início do bloco finally.
			if(s!=null) // Se o socket estiver aberto (diferente de null), faz um ultimo try-catch para fecha-lo.
				try {// Início bloco try.
						s.close(); // Fecha o socket.
				}catch(IOException e){// Pega a exceção de io.
					System.out.println("IO: " + e.getMessage()); // Mensagem de exceção de IO.
				}// Fim catch
		}// Fim do bloco finally.
	}// Fim função main.
}// Fim da classe.