import java.net.*; // Faz a importação de todas as classes da superclasse java.net, no qual é responsável pela implementação de protocolos de rede.
import java.io.*;//Faz a importação de todas as classes da superclasse java.io, no qual é responsável pela entrada e saída de dados do programa.
/*
 * Criação da classe TcpServidor, que enviara ao cliente os dados para o cliente.
 */

public class TcpServidor{  // Instânciação da classe principal do arquivo. Essa classe é que fará o envio de dados para o servidor.
	public static void main(String args[]){ // Início da função principal de TcpServidor que fará a escuta da conexão
		try { // Início do bloco try-catch-finally.
			int serverPort=7896; // Criação da porta que fará a comunicação entre o cliente e o servidor.
			ServerSocket listensocket=new ServerSocket(serverPort); // Instanciação do socket que conectar cliente com servidor.
			System.out.println("AGUARDANDO REQUISIÇÃO: "); // Envio de mensagem aguardando a requisição.
			/*
			 * No laço do while, como é passado um argumento true para o processo, ele irá funcionar continuamente,
			 * pois não há nada que possa falsear o while fazendo parar.
			 */
			while(true){// Início do while, enquanto receber true irá funcionar continuamente.
				Socket clientSocket = listensocket.accept(); // Instanciação do clientsockcet para receber qualquer requisição do cliente.
				Connection c= new Connection(clientSocket); // Instanciação entre a conexão do servidor com o cliente.
			}// Fim laço do while.
		}catch(IOException e) { // Início da exceção de IO.
			System.out.println("Listen: "+e.getMessage()); // Mensagem de exceção para IO.
		}// Fim catch
	} // Fim função principal
}// 



