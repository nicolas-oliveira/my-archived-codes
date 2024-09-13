# Introduction to Computational Thinking (MIT OpenCourse 6.0002)

Muitos problemas no mundo são pontas soltas e não tem solução. Um problema comum e sem solução é o problema da Super Promoção do Aniversário Guanabara.

Imagine que você foi premiado, e nesse prêmio você tem 1 hora para encher sua mochila com tudo que couber dentro dela. Você é uma pessoa esperta e busca o lucro e irá tentar olhar o preço do que pega enquanto coloca numa mochila.

Será que você irá conseguir encher sua mochila com o que há de mais valioso?

Ou melhor ainda, você consegue imaginar qual é a combinação que irá trazer o melhor lucro sem exceder o peso da mochila?

Normalmente, uma pessoa normal não teria o conhecimento de todos os produtos do supermercado, mas vamos supor que você tenha. Será que ainda é possível achar a combinação perfeita de peso e preço?

Vamos tirar a questão do tempo limite. Qual seria seus passos para realizar isso?

Provavelmente seria:

    1. Pegar um item qualquer

    2. Comparar com o anterior e ver se é mais valioso ou mais pesado.

Porém isso não resolve o problema, você pode descartar algo pesado porém valioso, ou pegar algo leve mas que somado vale mais. Há milhares de combinações possíveis!

A única forma de chegar perto de uma solução é você somando todos os produtos em seu peso, criar uma lista de todas as combinações possíveis de items que cabem na mochila e para que uma nova possibilidade entre na sua lista ela não pode exceder o peso suportável da mochila. Isso deve ser feito para cada possibilidade.

Para chegar próximo de uma resposta satisfatória, podemos descrever funções e vetores para isso:

```
Items[<valor,peso>];
ItemsDisponiveis[<Items>];
ItemsPegos[]; // Sendo 0 ou 1
```

$$
\sum_{i=0}^{n-1} ItemsPegos[i]*ItemsDisponiveis[i].valor
$$

    Sendo que:

$$
\sum_{i=0}^{n-1} ItensPegos[i]*ItensDisponiveis[i].peso <= pesoMochila
$$

Para fins de conclusão, o algoritmo descrito é chamado de brute force e pode ser feito em 3 passos:

1. Enumere todas as possibilidades de combinações possíveis de items. Isso é chamado de power set. Ele tem todas as possibilidades matemáticas possíveis.

2. Separe dentre essas possibilidades, o subconjunto que satisfaz a condição do peso da mochila.

3. Das possibilidades remanescentes, listada no passo 2, encontre uma que satisfaça o maior valor.

Isso torna possível, porém não prático a solução. Obviamente após executar todos esses passos é claro que obteremos uma resposta. Porém, tudo isso que falamos ainda não satisfaz nossa condição de tempo, pois basta que o número de items possíveis seja maior que o power set irá crescer exponencialmente, tornando o valor muito grande e o tempo para realizar tais passos tão demorado que nunca será prático realizá-lo. É preciso entender que todos os problemas de optimização acontecem por meio de contextos limitados.

#### Outras soluções: Greedy Algorithm

```
while backpack is not full
    put "best" available item in backpack
```

Aqui tem um problema no "best". O que é melhor para você? Valor? Menos Caloria? Até então demos os exemplo de encher a mochila de coisas valiosas. Porém, aqui podemos encaixar qualquer tipo de definição.
