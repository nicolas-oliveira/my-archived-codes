import java.net.*;  // Faz a importação de todas as classes da superclasse java.net, no qual é responsável pela implementação de protocolos de rede.
import java.io.*;//Faz a importação de todas as classes da superclasse java.io, no qual é responsável pela entrada e saída de dados do programa.
/*
 * Criação da classe connection, que EXTENDE, thread uma classe que gera um processo para 
 * fazer as conexões de entrada e saida do TCP.
 */
public class Connection extends Thread { // Instanciação da classe connection extendendo thread.
    DataInputStream in; // Instanciação da Entrada de dados chamada in.
	DataOutputStream out; // Instanciação da Saída de dados chamada out.
	Socket clientSocket; // Instaciação do socket que fará a comunicação de dados TCP.
	public Connection(Socket aClientSocket) {// Construtor da classe connection
		try{// Início bloco try.
			clientSocket = aClientSocket; //Instanciação do clientsocket pelo argumento recebido na função.
			in = new DataInputStream(clientSocket.getInputStream()); // Intanciação dos dados de entrada.
			out = new DataOutputStream(clientSocket.getOutputStream()); // Instanciação dos dados de saída.
			this.start(); // Start o construtor.
		}catch(IOException e) { // Catch da exceção de IO.
			System.out.println("Connections: "+e.getMessage());// envio da mensagem de exceção de IO.
		}// Fim bloco catch
	}// Fim bloco construtor.


		// Função que dará inicio as leituras dos dados, que irá transferir o dado de um local para outro.
    public void run(){ // Início da função run
				// Início do bloco try.
        try{ 
            String data = in.readUTF();// Instanciação de uma string que vai receber os dados de entrada convertido em UTF.
            System.out.println("MsN RECEBIDA : "+data); // Envio de mensagem recebida.
            out.writeUTF(data); // Conversão dos dados de saída em UTF.
        }catch(EOFException e){ //Captura da exceção de final de arquivo.
            System.out.println("EAF: "+  e.getMessage()); // Envio de mensagem da exceção capturada com EOF.
				// Captura da exceção de IO.
        }catch(IOException e) { 
            System.out.println("IO: "+e.getMessage()); // Envio de mensagem da exceção capturada com IO.
				// Bloco finally realizdo caso nenhuma exceção seja capturada.
        }finally{
						// Inicio do try dentro do finally.
            try{ 
                clientSocket.close(); // Fechando o socket de client aberto.
						// Exceção de IO.	
            }catch(IOException e){ 
                System.out.println("IO: "+e.getMessage()); // Envio de mensagem de exceção de IO.
            }
        }
    } 
} 
