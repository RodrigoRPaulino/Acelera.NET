function InsertValues(number)
{
    var numero = document.getElementById('result').innerHTML;
    document.getElementById('result').innerHTML = numero + number;
}

function Clean()
{
    document.getElementById('result').innerHTML = "";
}
function Back()
{
    var resultado = document.getElementById('result').innerHTML;
    document.getElementById('result').innerHTML = resultado.substring(0,resultado.length -1) 
}

function Calc()
{
    var resultado = document.getElementById('result').innerHTML;
    if(resultado)
    {
        document.getElementById('result').innerHTML = eval(resultado);
    }
    else
    {
        document.getElementById('result').innerHTML = 'Error'
    }
}