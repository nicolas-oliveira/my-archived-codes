// Importando bibliotecas java.net
import java.net.*;
// Importando a biblioteca java
import java.io.*;
// Declaração da classe
public class UdpServidor{
	// Declaração do método publico
	public static void main(String args[]) {
		// Inicialização do objeto DatagramSocket
		DatagramSocket aSocket=null;
		// Inicio do escopo do try que caso erre muda pro escopo do catch
		try {
			// Instancia um novo objeto DatagramSocket na porta 6789 através do construtor
			aSocket=new DatagramSocket(6789);
			// Declara um buffer de no mínimo 100 bytes
			byte[] buffer=new byte[100];

			// Estrutura de laço sempre vendadeiro
			while(true) {
				// Inicializa a variável request com o buffer declarado acima como parâmetro e como segundo parâmetro o tamanho do buffer.
				DatagramPacket request=new DatagramPacket(buffer, buffer.length);
				// Utiliza o método de receber os pacotes da classe Datagram e coloca como parâmetro a variável request.
				aSocket.receive(request);
				
				String string = new String(request.getData());
				String[] argsRequest = string.split(";");
				// Arrays.toString(request.getData()).split(";");
				
				// Variavel que pega o numero da url para realizar a conta
				Double num1 = Double.parseDouble(argsRequest[0]);
				// Variavel que representa o operador a
				String operador = argsRequest[1];
				Double num2 = Double.parseDouble(argsRequest[2]);
				
				switch (operador) {
					case "+":
						Double x = num1 + num2;
						break;
				
					default:
						break;
				}

				// Utiliza os métodos getters do objeto request com os parâmetros de dados, tamanho e endereço
				DatagramPacket reply=new DatagramPacket(request.getData(), request.getLength(),request.getAddress(),request.getPort());
				// Envia um pacote ao socket de conexão
				aSocket.send(reply);
				// Printa o valor recebido do pacote com o getter getData
				System.out.println("REQUISIÇÃO RECEBIDA: "+new String(reply.getData()));
			}
			// Caso encontre um erro de exceção durante a execução do socket
		} catch(SocketException e) {
			// Printar o erro de exceção
			System.out.println("Socket: "+e.getMessage());
			// Caso o erro de exceção não seja relacionado ao Socket
		} catch(IOException e) {
			// Caso o erro de exceção seja de sistema ele printa a mensagem
			System.out.println("IO: "+ e.getMessage());
			// Escopo que é executado após sucesso ou falha
		} finally{
			// Após realizar o try ou o catch ele finaliza o socket caso ele seja diferente de nulo
			if(aSocket != null) aSocket.close();
		}
	}
}