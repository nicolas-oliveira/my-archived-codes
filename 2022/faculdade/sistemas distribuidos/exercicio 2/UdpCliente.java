// Importando bibliotecas java.net
import java.net.*;
// Importando a biblioteca java
import java.io.*;
// Declaração da classe
public class UdpCliente{
	// Incio do método main que contém instruções principais da classe UdpCliente
	public static void main(String args[]){
		// Declaração do objeto DatagramSocket
		DatagramSocket aSocket=null;
		// Início do escopo do try que trata erros caso aconteçam
		try {
			// Inicializa o DatagramSocket através do construtor buscando a porta disponível para realizar a conexão
			aSocket=new DatagramSocket();
			// Utiliza o primeiro parâmetro utilizado no terminal como data 
			String num1 = args[0];
			String operador = args[1];
			String num2 = args[2];

			String requestString = num1 + ";" +  operador + ";" + num2;

			System.out.println("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
			System.out.println("MENSAGEM A SER ENVIADA AO SERVIDOR : " + requestString);
			System.out.println("ENVIANDO A MENSAGEM (" + requestString + ") PARA O SERVIDOR...");
			System.out.println("AGUARDANDO RESPOSTA...");

			// Utiliza o método getter do parâmetro do terminal como IP do servidor
			InetAddress aHost = Inet4Address.getByName(args[3]);
			// Cria a porta que será usada para enviar o pacote
			int serverPort = 6789;
			// Inicialização do objeto DatagramPacket com mensagem tamanho daS mensagem endereço ip e porta
			DatagramPacket request = new DatagramPacket(requestString.getBytes(), 5, aHost, serverPort);
			// Envia o pacote utilizando o método send
			aSocket.send(request);
			// Cria um espaço na memória para enviar o pacote
			byte[] buffer = new byte[1000];
			// Cria uma resposta com o tamanho do buffer e com o tamanho do buffer
			DatagramPacket reply = new DatagramPacket(buffer, buffer.length);
			// Utiliza o método de recebimento
			aSocket.receive(reply);
			// Printa a resposta do servidor como resposta
			System.out.println("Reply\n RESPOSTA DO SERVIDOR: " + new String(reply.getData()));
			// Captura 
		} catch (SocketException e){
			// Printa a mensagem de erro durante o envio do pactote
			System.out.println("Socket: " + e.getMessage());
			// Printa a mensagem de erro do sistema
		} catch (IOException e){
			// Printa mensagem de erro quando encontrado algo no sistema
			System.out.println("IO: " + e.getMessage());
			// Após a execução ou falha do pacote
		}finally {
			// Após realizar o try ou o catch ele finaliza o socket caso ele seja diferente de nulo
			if(aSocket != null) aSocket.close();
		}
	}
}