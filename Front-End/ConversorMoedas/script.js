function ConvertValue() {
    const amount = document.getElementById('amountInput').value;
    const selectedCurrency = document.getElementById('Coins').value;

    if (amount === '' || selectedCurrency === '') {
        alert("Digite um valor e selecione uma moeda para conversão!");
        return;
    }

    // Mapeia as moedas selecionadas para as correspondentes na API
    const currencyMapping = {
        'Dolar': 'USD',
        'Euro': 'EUR',
        'BitCoin': 'BTC'
    };

    const currencyCode = currencyMapping[selectedCurrency];

    const url = `https://economia.awesomeapi.com.br/json/all/`;

    fetch(url)
        .then(response => response.json())
        .then(data => {
            if (!data[currencyCode]) {
                throw new Error(`Valores de conversão para ${selectedCurrency} não encontrados na resposta da API`);
            }

            const rate = data[currencyCode].ask;
            let decimalPlaces = 2; // Padrão de 2 casas decimais

            if (currencyCode === 'BTC') {
                decimalPlaces = 6; // Altera para 6 casas decimais se a moeda for Bitcoin
            }

            const convertedValue = (amount / parseFloat(rate)).toFixed(decimalPlaces);

            // Atualiza os valores nos elementos do DOM
            switch (currencyCode) {
                case 'USD':
                    document.getElementById('usdValue').innerText = convertedValue;
                    break;
                case 'EUR':
                    document.getElementById('eurValue').innerText = convertedValue;
                    break;
                case 'BTC':
                    document.getElementById('btcValue').innerText = convertedValue;
                    break;
            }
            // Atualize os outros elementos conforme necessário
        })
        .catch(error => {
            console.log('Erro na conversão', error);
            alert('Ocorreu um erro ao converter o valor. Tente Novamente!');
        });
}
