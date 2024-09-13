 // Faz a importação de todas as classes da superclasse java.net, no qual é responsável pela implementação de protocolos de rede.
import java.net.*; 
//Faz a importação de todas as classes da superclasse java.io, no qual é responsável pela entrada e saída de dados do programa.
import java.io.*; 
public class TcpServidor{ // Instânciação da classe principal do arquivo. Essa classe é que fará o envio de dados para o servidor.
	public static void main(String args[]){ // Início do metódo main.
		try { // Início do bloco try-catch-finally.
			// Criação da porta que fará a comunicação entre o cliente e o servidor.
			int serverPort=7896;
			// Cria um socket através da porta de conexão
			ServerSocket listensocket=new ServerSocket(serverPort);
			System.out.println("AGUARDANDO REQUISIÇÃO: ");
			// Laço de repetição sempre verdadeiro
			while(true){
				// Realiza o aceite da conexão com o cliente
				Socket clientSocket = listensocket.accept();
				// Realiza a conexão com o cliente
				Connection c= new Connection(clientSocket);
			}
	 /*
		* Início do primeiro catch do algoritmo, primeira exceção que irá tratar é com relação se o socket já está instaciado. Se houver um socket já instaciado, o programa lançará um erro e será finalizado com uma mensagem personalizada da exceção ocorrida. 
		*/
		}catch(IOException e) {
			System.out.println("Listen: "+e.getMessage());
		}
	}
}
// Classe de conexão que extende a classe Thread
class Connection extends Thread {
	// Cria o protocolo de conexão de entrada
	DataInputStream in;
	// Cria o protocolo de conexão de saída
	DataOutputStream out;
	// Cria o cliente através do Socket
	Socket clientSocket;
	// Cria o método "Connection" recebendo como parâmetro o Cliente Socket
	public Connection(Socket aClientSocket) {
		try{
			// Recebe o parâmetro da função
			clientSocket = aClientSocket;
			// Instância um novo stream de dados do socket através do DataInputStream para receber os dados do cliente
			in = new DataInputStream(clientSocket.getInputStream());
			// Instância um novo stream de dados do socket através do DataOutputStream para enviar os dados para o cliente
			out = new DataOutputStream(clientSocket.getOutputStream());
			// Inicia a classe
			this.start();
	 /*
		* Início do primeiro catch do algoritmo, primeira exceção que irá tratar é com relação se o socket já está instaciado. Se houver um socket já instaciado, o programa lançará um erro e será finalizado com uma mensagem personalizada da exceção ocorrida. 
		*/
		} catch(IOException e) {
			System.out.println("Connections: "+e.getMessage());
		}
	}
	// Inicio do método run() que executa a saida de dados no terminal
	public void run(){
		try{
			// Transforma o texto recebido em string
			String data = in.readUTF();
			System.out.println("MsN RECEBIDA : "+data);
			// Escreve através do out os dados recebidos
			out.writeUTF(data);
		}catch(EOFException e){
			Sytem.out.println("EAF: "e.getMessage());
		}catch(IOException e) {
			System.outprintln("IO: "+e.getMessage());
		}finnaly{
			try{
				clientSocket.close();
			}catch(IOException e){
				System.out.println("IO: "+e.getMessage());
			}finally{
				try{
					clientSocket.close();
				}catch(IOException e) {
					// close
				}
			}
		}
	}
}
