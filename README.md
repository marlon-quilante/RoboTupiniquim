# Central de Controle do Robô Tupiniquim

![](https://imgur.com/L5SqYRA.gif)

## Introdução

Bem-vindo(a) à central de controle do Robô Tupiniquim. Aqui você irá definir a quantidade de
robôs exploratórios, o tamanho da área que deseja explorar, a posição inicial do robô e o
comando de movimentação. Com base nisso, o programa irá calcular e apresentar a posição final
do robô, bem como o desenho da área de exploração em tempo real enquanto o robô explora.

## Funcionalidades

- **Definição da quantidade de robôs:** Ao iniciar o programa, o usuário pode escolher
a quantidade de robôs que irão explorar um determinado local.

- **Definição da área de exploração:** É feita através de coordenadas x e y, sendo a 
coordenada inicial 0,0. Para definir a coordenada máxima de x e y, deve ser escrito
com um espaçamento entre x e y. Exemplo: "5 5".

- **Definição da posição inicial:** É feita através de coordenadas x e y do robô 
e a sua direção, respectivamente. As direções podem ser "N", "S", "L", "O" e deve
ser escrito com espaçamento entre as informações. Exemplo: "1 2 N".

- **Instrução de movimento**: É feita através de comandos para o robô girar 90º à esquerda (E),
girar 90º à direita (D) e se mover (M). Exemplo: "EMEMEMEMM".

- **Apresentação da Área de Exploração:** Após digitar a área limite de área e a posição
inicial do robô, é apresentado um desenho da área de exploração com a posição do robô. Cada posição
possível na área é representado por um "x" e o robô é representado pela direção em que está apontado
atualmente, ou seja, "N", "S", "L" e "O".

- **Atualização em Tempo Real:** À cada execução de uma instrução "E", "D" ou "M", o desenho da área
de exploração é atualizado 

- **Validação de entrada**: São feitas validações de entrada para garantir que os inputs sejam
feitos da forma correta e, consequentemente, para que o programa possa funcionar corretamente.

- **Novas explorações**: Ao final de cada exploração, o usuário pode escolher se deseja iniciar
uma nova ou sair do programa.

## Tecnologias
[![Tecnologias](https://skillicons.dev/icons?i=git,github,cs,dotnet,visualstudio,whimsical)](https://skillicons.dev)