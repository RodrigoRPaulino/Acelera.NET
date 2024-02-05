function gerarRnd(n) {
	const letras = 'abcdefghijklmnopqrstuvwxyz123456789';
  let gerador = '';
  for (let i = 0; i < n; i++) {
  	const rnd = Math.floor(Math.random() * letras.length);
  	gerador += letras[rnd];
  }
	return gerador; 
}

function gerar() {
	const n = document.getElementById('quantidade').value || 10;
	document.getElementById('valorRnd').value = gerarRnd(n);
}