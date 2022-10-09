## Projeto

Este projeto foi desenvolvido com Visual Studio com VB.NET e atualizado para a versão 2022 com o .NET 4.8 mas exige > .NET 4.5.2)
(Pode ser alterado no arquivo de solução)

## Introdução

Este trabalho consiste em aplicar e avaliar um algoritmo genético com duas variáveis (x, y) para a maximização da função f, no intervalos [ -3.1,12] e [4.1,5.8] e definida por: 21.5 + x * sin(4 * PI * x) + y * * sin(20 * PI * y) usando o método de seleção com Hanking e aplicando o elitismo para o cruzamento de dois pontos dos indivíduos.

<p align="center"> 
<img src=https://github.com/geraldoaax/AlgoritmoGenetico-MaxFunction2Var/blob/main/img/grafico_funcao_f.png/>
<br/>
Figura 1 – Gráfico da Função f
</p>

## Representação dos Indivíduos

O trabalho proposto utiliza a codificação binária para os indivíduos. Contudo, como se trata de uma função de 2 variáveis, uma segmentação deve ser feita no momento da decodificação para separá-las. Nesse caso, é desejável um número par de bits, se as variáveis independentes demandem a mesma precisão.

<p align="center"> 
<img src=https://github.com/geraldoaax/AlgoritmoGenetico-MaxFunction2Var/blob/main/img/segmentacao_individuos.png/>
<br/>
Figura 2 – Segmentação dos Indivíduos
</p>

## Ranking

A Seleção por Hanking primeiro classifica a população e então atribui a cada cromossomo um valor de adequação determinado pela sua classificação. O pior terá adequação igual a 1, o segundo pior 2 etc. de forma que o melhor terá adequação igual a N (número de cromossomos na população).

Elitismo: A técnica do elitismo consiste em manter os melhores n indivíduos intactos durante um ciclo evolutivo. Mesmo tendo um lugar reservado na nova população, esses indivíduos continuam fazendo parte do conjunto de candidatos para cruzamento. O elitismo elimina a necessidade de se manter um histórico dos melhores indivíduos de todas gerações, tendo em vista que esses certamente estarão presentes na última geração. No entanto, uma quantidade exagerada de indivíduos na elite pode prejudicar o encontro do máximo global. O uso de 10% dos indivíduos da população para a elite é adequado para esse problema.

## Cruzamento de 2 pontos

São definidos dois pontos de cruzamento, a série binária desde o início do cromossomo até o primeiro ponto de cruzamento é copiada do primeiro pai, a parte do primeiro ponto de cruzamento até o segundo ponto é copiada do outro pai e o resto do cromossomo é copiado do primeiro pai novamente.
Solução Desenvolvida

<p align="center"> 
<img src=https://github.com/geraldoaax/AlgoritmoGenetico-MaxFunction2Var/blob/main/img/resolucao.png/>
<br/>
Figura 3 – Resultado da Solução Desenvolvida
</p> 

<p align="center"> 
<img src=https://github.com/geraldoaax/AlgoritmoGenetico-MaxFunction2Var/blob/main/img/desempenho.png/>
<br/>
Figura 4 – Gráfico de Desempenho
</p>

Tamanho da população: Quanto mais indivíduos na população, menos épocas serão necessárias para o encontro da solução ótima. No entanto, a aplicação dos operadores genéticos será mais lenta para cada época. Além disso, mais memória será necessária para a execução do processo. O algoritmo evolutivo conseguiu encontrar a solução ótima com apenas 100 indivíduos e 70 gerações.

Número de bits: A quantidade de bits usada na codificação dos indivíduos influencia na precisão da solução encontrada. Para o problema em questão, 20 bits (10 Bit´para cada variável) é suficiente.

Taxa de Recombinação: O uso de elevadas taxas de recombinação sem o elitismo pode prejudicar o algoritmo ao longo das gerações, pois não há muita expectativa que indivíduos fortes (talvez os mais fortes já obtidos) sejam mantidos intactos no decorrer da evolução. Ao mesmo tempo, taxas muito pequenas de recombinação tornam o algoritmo mais lento. O melhor valor encontrado para essa aplicação foi pc = 0,80.

Taxa de Mutação: Da mesma forma que ocorre na recombinação, altas taxas de mutação prejudicam a convergência do algoritmo, sobretudo se o elitismo não for usado. Baixas probabilidades de mutação tornam o algoritmo lento e prejudicam o encontro do máximo global, concentrando os indivíduos ao redor de máximos locais. O melhor valor encontrado para essa aplicação foi pm = 0,03.

Limite de Gerações: Esse parâmetro define o critério de parada do algoritmo genético. Ele deve ser definido de modo que ocorra a convergência para uma solução ótima. Para o problema em questão, 70 gerações são suficientes.

## Conclusão

Técnicas evolutivas podem ser aplicadas em problemas de otimização e busca. Notavelmente, os algoritmos genéticos representam valiosas ferramentas em problemas de minimização e maximização de funções. A parametrização desses algoritmos, contudo, deve ser feita de modo a garantir uma evolução numa taxa razoável, suficientemente rápida para o processamento computacional e suficientemente lenta para não convergir para máximos locais ou divergir. Além disso, faz-se necessário escolher adequadamente as formas de codificação dos indivíduos, para reduzir o esforço computacional necessário pelo algoritmo e facilitar sua implementação. Finalmente, os operadores genéticos devem ser escolhidos de forma a garantir uma convergência mais rápida.
