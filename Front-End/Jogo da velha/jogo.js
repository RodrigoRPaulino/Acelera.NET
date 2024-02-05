
//vamos selecionar todas as divs com essa variavel
const cellElements = document.querySelectorAll("[data-cell]");

//selecionar board
const board = document.querySelector("[data-board]");

//selecionar mensagem 
const winningMessageElement = document.querySelector
("[data-text-message]");

//selecionar texto ganhador 
const teamWinnerMessage = document.getElementById("team-winner");

const winningMessage = document.querySelector
("[data-winning-message]");


//variavel booleana 
let isCircleTurn;

//botao para reiniciar o jogo
const buttonReload = document.getElementById("btn-reiniciar");

//variavel para acompanhar o numero de jogadas realizadas
let movesCount = 0;

buttonReload.addEventListener('click', function()
{
    location.reload();
});

//armazenar combinaçoes de vitorias em forma de lista
//os resultados tambem serao em forma de lista passando a posição das celulas
const winningCombinations = [
    [0,1,2],[3,4,5],[6,7,8],
    [0,3,6],[1,4,7],[2,5,8],
    [0,4,8],[2,4,6]
];


//método para iniciar o jogo
const startGame = () =>
{
    for(const cell of cellElements)
    {
      cell.addEventListener('click',handleClick,{once:true});
    }
    // let isCircleTurn = false;
    board.classList.add("X");
};

//encerra o jogo
const endGame = (isDraw) =>
{
    if(isDraw)
    {
        teamWinnerMessage.innerText = 'Empatou!\n Jogar Novamente'
       
    }
    else
    {
        teamWinnerMessage.innerText = 
        isCircleTurn ? 'O Ganhou!': 'X Ganhou!'
    }
        winningMessage.classList.add("show-winning-message");
};

//função que recebe por parametro o jogador atual e verifica
// se alguma combinacao do array foi atendida pegando a index
// e se a lista contem o player atual 
const checkForWin = (currentPlayer) =>
{
    return winningCombinations.some(combination =>
        {
            return combination.every((index) =>
            {
                return cellElements[index].classList.contains(currentPlayer);
            });
        });
};

const placeMark = (cell, classToAdd) =>
{
    cell.classList.add(classToAdd);
};

 //depois que o X faz a jogada, esse método muda o turno para o O
 // invertendo a lógica da variavel 
 //limpando a board e vericicando a condição
const swapTurns = () =>
{
    isCircleTurn = !isCircleTurn;
    //remove a jogada anterior para a proxima
    board.classList.remove("O");
    board.classList.remove("X");

    //se for a vez do O ele adiciona
    //senao, ele adiciona o X
    if(isCircleTurn)
    {
        board.classList.add("O");
    }
    else
    {
        board.classList.add("X");
    }
};
const handleClick = (e) => 
{
    //colocar a marca (X ou O)
    const cell = e.target;
    //adiciona qual jogador sera inserido
    const classToAdd = isCircleTurn ? 'O':'X';
    placeMark(cell,classToAdd);
    //verificar por vitoria
    const isWin = checkForWin(classToAdd);
     movesCount ++; //Incrementa o numero de movimentos

    if (isWin)
    {
        endGame(false);
    }
        /*verifica se todas as celulas foram preenchidase nenhum
        jogador venceu*/
    else if(movesCount === cellElements.length)
    {
        endGame(true);
    }
    else
    {
        //mudar o simbolo por jogador
        swapTurns();
    }
  
};

startGame();
