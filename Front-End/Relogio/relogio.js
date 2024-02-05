var isClockRunning = false; //verifica se o relogio esta rodando
var intervalReference;

function startClock() {
    if (!isClockRunning) {
        // Inicia o intervalo para atualizar o relógio a cada segundo
        intervalReference = setInterval(updateClock, 1000);
        isClockRunning = true;
    }
}

//método para formar a logica do funcionamento do relogio.
//pega como parametro a data, hora, minuto e segundos 
// como um DateTime.Now()
function updateClock() {
    var now = new Date();
    var hours = now.getHours();
    var minutes = now.getMinutes();
    var seconds = now.getSeconds();

    // Adiciona um zero à esquerda se o número for menor que 10
    // caso seja maior, recebe o proprio valor 
    hours = hours < 10 ? "0" + hours : hours;
    minutes = minutes < 10 ? "0" + minutes : minutes;
    seconds = seconds < 10 ? "0" + seconds : seconds;

    //monta a string do relogio concatenando com :
    var timeString = hours + ":" + minutes + ":" + seconds;

    // Atualiza o elemento com o horário atual
    document.getElementById("time").innerText = timeString;
}

// Adicione um ouvinte de evento ao botão "Zerar" para reiniciar o relógio
document.getElementById("iniciar").addEventListener("click", function () {
    document.getElementById("time").innerText = "00:00:00";
    isClockRunning = false;
});

// Adicione um ouvinte de evento ao botão "Desligar" para parar o relógio
document.getElementById("desligar").addEventListener("click", function () {
    clearInterval(intervalReference);
    isClockRunning = false;
});
