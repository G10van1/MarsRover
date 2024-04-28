[\[English\]](README.md) [\[Português\]](#MarsRover)
_______________________________________________________________________________________________________________________________________
# MarsRover
Mova um Rover(veículo de exploração) em uma grade.

## Instruções:

Um esquadrão de rovers robóticos será pousado pela NASA em um platô em Marte.

Este platô, que é curiosamente retangular, deve ser percorrido pelos rovers para que suas câmeras a bordo possam obter uma visão completa do terreno circundante e enviá-la de volta à Terra.

Sua tarefa é desenvolver uma API que mova os rovers pelo platô.

Nesta API, o platô é representado como uma grade 10x10, e um rover possui um estado que consiste em duas partes:

sua posição na grade (representada por um par de coordenadas X,Y)
a direção que a bússola está apontando (representada por uma letra, uma de 'N', 'S', 'E', 'W')
a posição inicial do rover é '0:0:N'

## Entrada

A entrada para o programa é uma sequência de comandos de movimentação de um caractere:

'L' e 'R' giram na direção em que o rover está voltado
'M' move o rover um quadrado da grade para frente na direção para a qual está atualmente voltado.
Se um rover chegar ao final do planalto, ele contornará o final da grade.

## Saída

A saída do programa é a posição final do rover após todos os comandos de movimento terem sido executados. A posição é representada como um par de coordenadas e uma direção, unidos por dois pontos para formar uma string. Por exemplo: um rover cuja posição é `2:3:W` está no quadrado (2,3), voltado para oeste.

## Exemplos

dada uma entrada 'MMRMMLM', a saída deve ser '2:3:N'

dada uma entrada 'MMMMMMMMMM' dá uma saída '0:0:N' (devido ao wrap-around)

## Regras:
O rover recebe uma matriz de comandos, por exemplo, 'RMMLM' e retorna o ponto final após os movimentos, por exemplo. '2:1:N'
O rover dá a volta se atingir o final da grade.



