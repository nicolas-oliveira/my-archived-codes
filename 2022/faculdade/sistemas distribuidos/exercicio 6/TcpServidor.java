/*
 * Alex Bueno, Gabriel Cokin, Nicolas Oliveira, Guilherme Guimarães
 */

import java.net.*; // importando a biblioteca java.net, responsavel pelas conexões da aplicação.
import java.io.*;//  importando a biblioteca java.io, responsavel pelos inputs e outputs.adicionado.

/*
 * Criação da classe TcpServidor, que enviara ao cliente os dados para o cliente.
 */

public class TcpServidor{ // Início da classe TcpServidor 
	public static void main(String args[]){ // Início da função principal de TcpServidor que fará a escuta da conexão
		try { // Início bloco try.
			int serverPort = 7896; // Instanciação da porta que irá conectar servidor com client.
			ServerSocket listensocket = new ServerSocket(serverPort); // Instanciação do socket que conectar cliente com servidor.
			
			System.out.println("AGUARDANDO REQUISIÇÃO: "); // Envio de mensagem aguardando a requisição.
			/*
			 * No laço do while, como é passado um argumento true para o processo, ele irá funcionar continuamente,
			 * pois não há nada que possa falsear o while fazendo parar.
			 */
			while(true){// Início do while, enquanto receber true irá funcionar continuamente.
				Socket clientSocket = listensocket.accept(); // Instanciação do clientsockcet para receber qualquer requisição do cliente.
				Connection c = new Connection(clientSocket); // Instanciação entre a conexão do servidor com o cliente.					
			}// Fim laço do while.
		}catch(IOException e) { // Início da exceção de IO.
			System.out.println("Listening: " + e.getMessage()); // Mensagem de exceção para IO.
		}
	} // Fim função principal
}// 



