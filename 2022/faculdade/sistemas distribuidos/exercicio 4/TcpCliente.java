 // Faz a importação de todas as classes da superclasse java.net, no qual é responsável pela implementação de protocolos de rede.
import java.net.*;
//Faz a importação de todas as classes da superclasse java.io, no qual é responsável pela entrada e saída de dados do programa.
import java.io.*;
public class TcpCliente{
	public static void main(String args[]){
		//
		Socket s = null;
		try {
			// Porta para realizar a comunicação com o servidor
			int serverPort = 7896;
			// Criação do socket através do argumento passado pelo terminal
			s = new Socket(args[1],serverPort);
			// Criação do stream de dados para receber do servidor
			DataInputStream in = new DataInputStream(s.getInputStream());
			// Criação do stream de dados para enviar para o servidor
			DataOutputStream out = new DataOutputStream(s.getOutputStream());
			// Envia a informação para o servidor através do argumento do terminal
			out.writeUTF(args[0]);
			// Recebe os dados através do servidor
			String data = in.readUTF();
			System.out.println("RECEBIDO: "+data);
		}catch(UnknownHostException e) {
			// Tratamento de exceção caso algum erro aconteça
			System.out.println("Sock: "+e.getMessage());
		}catch(EOFException e){
			// Tratativa de erro caso algo com EOF aconteça
			System.out.println("EOF: "+e.getMessage());
		}catch(IOException e){
			// Tratativa de erro caso algo com a saida de dados falhe
			System.out.println("IO: "+e.getMessage());
		}finally{
			// Caso a string de dados não seja nula fecha o socket
			if(s!=null)
				try {
					s.close();
				}catch(IOException e){
					// close
				}
		}
	}
}