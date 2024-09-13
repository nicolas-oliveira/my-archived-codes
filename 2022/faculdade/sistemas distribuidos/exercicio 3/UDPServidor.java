/*
 * Exercício Sistemas Distribuidos
 * 
 * Nicolas Oliveira Mariano
 * 
 */
//Faz a importação de todas as classes da superclasse java.net, no qual é responsável pela implementação de protocolos de rede.
import java.net.*; 
//Faz a importação de todas as classes da superclasse java.io, no qual é responsável pela entrada e saída de dados do programa.
import java.io.*; 
// Instânciação da classe principal do arquivo. Essa classe é que fará o envio de dados para o servidor.
public class UDPServidor{ 
		/*
		* Principal método da classe UDPSERVIDOR, é estatica pois não pode ser instanciada além dos membros especificados
		* Recebe como argumento um array de Strings com o nome de args, no qual serão usados e convertidos durante a execução do método.
		*/
		// Início do metódo main.
	public static void main (String args[]){ 
		 // Criação do socket para envio e transmissão dos pacotes, inicialidado como null.
		DatagramSocket aSocket = null;
		/*
		* Um bloco try-catch-finally é uma forma de lidar com erros durante a execução. Inicialmente coloca-se no bloco.
		* try a execução desejada; para tratar os erros durante a execução, implementa-se os catchs, que são ações realizadas.
		* em qualquer erro occorrido. Se caso a execução for realizada com sucesso, tem-se a execução do bloco descrito em finally.
		*/
		// Início do bloco try-catch-finally.
		try{ 
			// Instânciação do socket na porta que receberá a request do cliente.
			aSocket = new DatagramSocket(6789); 
			// Criação de um buffer, que é um espaço na memória RAM para acomodar o pacote, de tamanho 100.
			byte[] buffer = new byte[100]; 
			/*
			 * O laço while faz com que seja gerado um bloco que se repetirá infinitamente, até que haja uma condição que falseie o laço e finalize o loop.
			 * No caso, o while nunca terminará por formas tradicionais pois não haverá nada que falseie o laço, ficando em loop eterno e esperando
			 * sinal do cliente.
			 */
			while(true) // Marcação do laço do while, que se repetirá infinitamente enquanto for true.
				{ // Início do bloco while
					DatagramPacket request = new DatagramPacket (buffer, buffer.length); // Criação do buffer para captura do pacote.
					aSocket.receive (request); // Recebimento do request que retornará o endereço da memoria do buffer.
					/*
					 * Criação do reply que será enviado ao cliente. tendo um construtor com 4 argumentos:
					 * 1) request.getData() -> os dados do pacote recebido do cliente em bytes;
					 * 2) request.getLength() -> tamanhgo da string recebida do cliente;
					 * 3) request.getAddress() -> IP do pacote de cliente;
					 * 4) request.getPort() -> porta do cliente.
					 */
					System.out.println("Requisição recebida:" + new String(request.getData())); // Requisição que o servidor recebeu do cliente fazer.
					String test = new String (request.getData()); // Pegando os valores da string recebido pelo request.
					String[] test1 = test.split(";"); // Tirando o ponto e virgula da string recebida do request.
					String result; // Instanciando uma nova string
					Double test2;// Instanciando uma nova variavel de double.
					/*
					 * No caso switch irá verificar a operação solicitada:
					 * 1) + para adição;
					 * 2) - para subtrair;
					 * 3) * para multiplicar;
					 * 4) / para dividir;
					 * 5) Enviar mensagem de erro de operador não compatível.
					 * Para cada caso um resultado diferento:
					 * 1) Somar o primeiro número com o segundo número;
					 * 2) Subtrair o primeiro número com o segundo número;
					 * 3) Multiplicar o primeiro número com o segundo número;
					 * 4) Dividir o primeiro número com o segundo número SE o segundo número não for zero, caso contrário, retornar infinito.					 
					 * Em todos os resultados será gerado uma string, naqueles que é feito um operação é feito a conversão para String. Isso
					 * se deve ao fato de fazer o byte [] para a operação.
					 */
					switch (test1[1]){ // Início do switch.
						case "+": // Primeiro caso para soma.
							test2 = (Double.parseDouble(test1[0]) + Double.parseDouble(test1[2])); // Conversão do primeiro e do segundo numero para Double e posteriormente
							// somar os números.
							result = test2.toString(); //Transofmar o resultado numa string.
						break; // Fim soma.

						case "-": // Primeiro caso para subtração.
							test2 = (Double.parseDouble(test1[0]) - Double.parseDouble(test1[2]));
							result = test2.toString();
						break;

						case "x":
							test2 = (Double.parseDouble(test1[0]) * Double.parseDouble(test1[2]));
							result = test2.toString();
						break;

						case "/":
							if (Double.parseDouble(test1[2]) == 0){
								result = "Infinity";
							}else{
								test2 = (Double.parseDouble(test1[0]) / Double.parseDouble(test1[2]));
								result = test2.toString();
							}
						break;
						default: result = "Operador invalido use os seguintes operadores: + para somar, - para subtrair, * para multiplicar e / para dividir";
						break;
					}
					DatagramPacket reply = new DatagramPacket (result.getBytes(), result.length(), // Criação do reply que será enviado ao cliente.
					request.getAddress(),request.getPort()); // Criação do reply que será enviado ao cliente.
					aSocket.send(reply); // Envio da resposta para o cliente
					System.out.println("Enviando resposta para cliente: " + new String (result.getBytes())); // Retorno da string recebida do cliente.
				} // Fim do bloco while.
	    	} // Fim do bloco try.
		/*
         * Início do primeiro catch do algoritmo, primeira exceção que irá tratar é com relação se o socket já está instaciado. Se houver um socket já instaciado, o programa lançará um erro e será finalizado com uma mensagem personalizada da exceção ocorrida. 
         */
		catch (SocketException e){ // Início do catch do SocketException
			System.out.println("Socket: " + e.getMessage()); // Enviando mensagem personalizada do SocketException.
			} // Fim do bloco do catch de SocketException.
		catch (IOException e){ // Início do catch do IOException
			System.out.println("IO: " + e.getMessage()); // Enviando mensagem personalizada do IOException.
			} 
		/*
		* Início do bloco do finally, no qual se após o try não houver nenhuma exceção (tratadas pelo catch), ele começa o finally. Nesse caso, o finally irá verificar se o socket for diferente de null, o socket é fechado para não gastar recursos.
		*/
		finally{ 
			// Verifica a atual situação que o socket se encotra.
			if (aSocket !=null) 
			// Fecha o socket se o socket for diferente de null.
				aSocket.close(); 
			} 
		} 
	} 
