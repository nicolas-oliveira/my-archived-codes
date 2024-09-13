/*
 * Exercício Sistemas Distribuidos
 * 
 * Nicolas Oliveira Mariano
 * 
 */
 // Faz a importação de todas as classes da superclasse java.net, no qual é responsável pela implementação de protocolos de rede.
import java.net.*; 
//Faz a importação de todas as classes da superclasse java.io, no qual é responsável pela entrada e saída de dados do programa.
import java.io.*; 

public class UDPClient { //Instânciação da classe principal do arquivo. Essa classe é que fará o envio de dados para o servidor.
		/*
		* Método principal da classe UDPCLIENTE, é estatica pois não pode ser instanciada além dos membros especificados
		* Recebe como argumento um array de Strings com o nome de args, eles serão usados e convertidos durante a execução.
		*/
    public static void main (String args[]){ // Início do metódo main.
        DatagramSocket aSocket = null; // Criação do socket para envio e transmissão dos pacotes, inicialmente em estado nulo.
        /*
         * Um bloco try-catch-finally é uma forma de lidar com erros durante a execução. Inicialmente coloca-se no bloco.
         * try a execução desejada; para tratar os erros durante a execução, implementa-se os catchs, que são ações realizadas.
         * em qualquer erro occorrido. Se caso a execução for realizada com sucesso, tem-se a execução do bloco descrito em finally.
         */
        try{ // Início do bloco try-catch-finally.
            aSocket = new DatagramSocket (); // Instânciação do socket de Cliente.
            // Criação de uma array de bytes, utilizando o arg[0], no qual pega a cadeia de caracteres fornecidos e transforma em decimais na tabela ASCII.
            String[] test = new String[3];
            for (int i = 0; i < 3; i++){
                    test[i] = args[i];
            }
            String requestString = String.join(";", test);
						// Mostra no terminal as mensagens a serem enviadas ao servidor
						System.out.println("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
						System.out.println("MENSAGEM A SER ENVIADA AO SERVIDOR : " + requestString);
						System.out.println("ENVIANDO A MENSAGEM (" + requestString + ") PARA O SERVIDOR...");
						System.out.println("AGUARDANDO RESPOSTA...");
						// Utiliza a string localizado em na terceira posição e converte para um endereço IP
            InetAddress aHost = Inet4Address.getByName(args[3]); 
						 // Criação da porta que fará a comunicação entre o cliente e o servidor.
            int serverPort = 6789;
            // Criação da requisição que fará comunicação entre o servidor e o cliente.
            DatagramPacket request = new DatagramPacket (requestString.getBytes(), requestString.length(), aHost, serverPort); // Instânciação do packet de construtor com 4 argumentos.
            aSocket.send(request); // Envio do pacote "request" utilizando o método send.
            byte[] buffer = new byte[100]; // Criação de um buffer, que é um espaço na memória RAM para acomodar o pacote, de tamanho 100.
            DatagramPacket reply = new DatagramPacket (buffer, buffer.length); // Criou-se a resposta que vai ter o tamanho do buffer e receber o array de bytes buffer.
            aSocket.receive(reply); // Recebimento da resposta do servidor endereçado.
            System.out.println("REPLY RESPOSTA DO SERVIDOR: " + new String (reply.getData())); // Saída do resultado 
        } // Fim do bloco try
        /*
         * Início do primeiro catch do algoritmo, primeira exceção que irá tratar é com relação se o socket já está instaciado. Se houver um socket já instaciado, o programa lançará um erro e será finalizado com uma mensagem personalizada da exceção ocorrida. 
         */
        catch (SocketException e){ 
				// Enviando mensagem personalizada do SocketException.
            System.out.println("Socket: " + e.getMessage()); 
        } 
        /*
         * Início do segundo catch do algoritmo, essa exceção é lançada quando há problemas nos inputs, por exemplo, quando se coloca um espaço no meio de uma palavra, fazendo contar mais de dois caracteres na array m. Assim como SocketException, ao acontecer a exceção, o sistema lança uma mensagem personalizada falando do erro. 
         */
        catch (IOException e){ // Início do catch do IOException
            System.out.println("IO: " + e.getMessage()); // Enviando mensagem personalizada do IOException.
        }
        /*
         * Início do bloco do finally, no qual se após o try não houver nenhuma exceção (tratadas pelo catch), ele começa o finally. Nesse caso, o finally irá verificar se o socket for diferente de null, o socket é fechado para não gastar recursos.
         */
				 // Início do bloco finally.
        finally{ 
					// Verifica a atual situação que o socket se encotra.
            if (aSocket != null) 
						// Fecha o socket se o socket for diferente de null.
            aSocket.close(); 
        } 
    }
} 
