
document.getElementById('btn').addEventListener('click', (e) => {
    const texto = document.getElementById('texto').value;
    const total = document.getElementById('total');
    const palavras = texto.split(/\s+/).filter(function(word) {
      return word.length > 0;
    });
  
    total.innerText = palavras.length;
  });
  