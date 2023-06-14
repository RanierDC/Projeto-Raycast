# **PROJETO RAYCAST**
### Alunos: João Caetano e Ranier Dalton 

## Descrição 
<p align="justify"> 
	Neste trabalho foi feito um projeto no Unity, onde se foi utilizado conceitos de movimentação, tiros(Raycast) e iluminação. Sendo um jogo onde o personagem (Bola Vermelha) deve se movimentar horizontalmente com o objetivo de acertar os Zumbis estando na mesma direção que eles.
</p>

## Gameplay
<p align="justify"> 
	A Gameplay se resume em uma bola vermelha no qual tem uma movimentação somente para os lados e tem como objetivo eliminar "hordas" de zumbis para acumular pontos até vencer, você ganha caso chegue na terceira horda. 
<br>
<br>
	Mecânica: 
<br>
<br>
	:small_blue_diamond: Você pode controlar a bola da esquerda para direita com os direcionais esquerda e direita ou botões A e D.
<br>
	:small_blue_diamond: Com o botão esquerdo do mouse voçê ataca e elimina os zumbis em frente.
</p>

### O que são as hordas de zumbis?
<p align="justify"> 
	As hordas de zumbis se resumem a três zumbis aparecendo simultaneamente e aleatoriamente na cena onde o jogador (esfera vermelha), irá ter que se alinhar na mesma direção dos zumbis e eliminá-los, assim ganhando pontos. 
</p>
	
### Como funciona o sistema de pontuação?
<p align="justify"> 
	O sistema de pontuação funciona por acerto ou erro dos tiros nos alvos. Ao acertar os zumbis, ganha 10 pontos, porém ao falhar na tentativa você perde 4 pontos. Inicialmente o jogador começa com 0 pontos, que caso desacerte o alvo logo de início, deve reiniciar, e ir assim até chegar na terceira horda.
</p>
	
### Elementos do HUD/GUI
<p align="justify"> 
	Contém poucas informações na tela, durante a gameplay, temos a presença de dois Text's, um informando a atual pontuação do jogador e outra informando ao jogador se ele conseguiu atingir os alvos, tendo duas possibilidades de mensagens, uma sendo "Errou!" de coloração vermelha e outra "Acertou!" com coloração azul. Ao perder ou ganhar, aparece um novo elemento Text na tela, que se o jogador teve uma pontuação igual ou menor que 0, tem um texto informando "Você perdeu!!" em vermelho, e no caso de chegar a terceira horda, tem a mensagem "Você venceu!!" em tom azul, no caso da aparição destes dois elementos, o tempo da cena diminui drasticamente, assim desacelerand a cena. 
</p>
	
	


### Escolha de iluminação
<p align="justify"> 
	Ajustamos a luz para que pudéssemos deixar o ambiente bem escuro, porém com uma iluminação artificial acima dos objetos, assim deixando um ar de suspence a cena, por mais que não seja um jogo para amedrontar. Para realizar esta iluminação, rotacionamos o Directional Light para deixarmos a cena totalmente escura, logo após isso não se podia enxergar nada, então foi criado um objeto com Point Light, que ilumina a cena de cima, possibilitando o jogador ver os zumbis para atingi-los e não iluminar a cena ao redor. 
</p>



