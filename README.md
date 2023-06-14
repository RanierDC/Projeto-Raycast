# **PROJETO RAYCAST**
### Alunos: João Caetano e Ranier Dalton 

## Descrição 
<p align="justify"> 
	Neste trabalho foi feito um projeto no Unity, onde se foi utilizado conceitos de movimentação, tiros (Raycast) e iluminação. Sendo um jogo onde o personagem (Bola Azul) deve se movimentar horizontalmente com o objetivo de acertar os Zumbis estando na mesma direção que eles.
</p>

<div align="center">
<img height="300px" src="https://github.com/RanierDC/Projeto-Raycast/assets/90422755/3878d04c-fb55-4e59-86d6-f10e7855d30f"/>
</div>

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
	:small_blue_diamond: Com o botão esquerdo do mouse você ataca e elimina os zumbis em frente.
<br>
	:small_blue_diamond: Você deve alinhar o personagem com os zumbis (linha reta), para que possa entrar na trajetória do ataque.
</p>

<div align="center">
<img height="350px" src="https://github.com/RanierDC/Projeto-Raycast/assets/90422755/bafbe426-5310-4de8-97e3-a2c1fb5434ce"/>
</div>

### O que são as hordas de zumbis?
<p align="justify"> 
	As hordas de zumbis se resumem a três zumbis aparecendo simultaneamente e aleatoriamente na cena onde o jogador (esfera vermelha), irá ter que se alinhar e eliminá-los, assim ganhando pontos. 
</p>

<div align="center">
<img height="300px" src="https://github.com/RanierDC/Projeto-Raycast/assets/90422755/34aaad14-0c35-435d-be65-9cf6180b574b"/>
</div>
	
### Como funciona o sistema de pontuação?
<p align="justify"> 
	O sistema de pontuação funciona por acerto ou erro dos tiros nos alvos. Ao acertar os zumbis, ganha 10 pontos, porém ao falhar na tentativa você perde 4 pontos. Inicialmente o jogador começa com 0 pontos, que caso desacerte o alvo logo de início, deve reiniciar, e ir assim até chegar na terceira horda.
</p>
	
### Elementos do HUD/GUI
<p align="justify"> 
	Contém poucas informações na tela, durante a gameplay, temos a presença de dois Text's, um informando a atual pontuação do jogador e outra informando ao jogador se ele conseguiu atingir os alvos. O texto verificador de colisão tem duas possibilidades de mensagens, uma sendo "Errou!" de coloração vermelha e outra "Acertou!" com coloração azul, a serventia é facilitar o uso da mecânica que complica o jogo, que seria o alinhamento do personagem. 
</p>
<div align="center">
<img height="100px" src="https://github.com/RanierDC/Projeto-Raycast/assets/90422755/30915bca-e7fa-4fb8-98ea-0689738e70ef"/>
</div>
<p align="justify"> 
	 Ao perder ou ganhar, aparece um novo elemento Text na tela, que se o jogador teve uma pontuação igual ou menor que 0, tem um texto informando "Você perdeu!!" em vermelho, e no caso de chegar a terceira horda, tem a mensagem "Você venceu!!" em tom azul, no caso da aparição destes dois elementos, o tempo da cena diminui drasticamente, assim desacelerand a cena.
</p>
<br>
<div align="center">
<img height="300px" src="https://github.com/RanierDC/Projeto-Raycast/assets/90422755/d6b3a03e-ac62-4ab3-94b6-b9286784a4b6"/>
<img height="300px" src="https://github.com/RanierDC/Projeto-Raycast/assets/90422755/9538147a-70cc-431c-b203-6cbd6203efdb"/>
</div>

## Escolha de iluminação
<p align="justify"> 
	Ajustamos a luz para que pudéssemos deixar o ambiente bem escuro, porém com uma iluminação artificial acima dos objetos, assim deixando um ar de suspence a cena, por mais que não seja um jogo para amedrontar. Para realizar esta iluminação, rotacionamos o Directional Light para deixarmos a cena totalmente escura, logo após isso não se podia enxergar nada, então foi criado um objeto com Point Light, que ilumina a cena de cima, possibilitando o jogador ver os zumbis para atingi-los e não iluminar a cena ao redor. 
</p>



