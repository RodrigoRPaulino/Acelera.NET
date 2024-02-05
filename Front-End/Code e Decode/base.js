document.querySelector('button').addEventListener('click', (e) => {
    const option = document.querySelector('select').value;
    const input = document.getElementById('input').value;
    let output = '';
    try {
        output = option == "0" ? atob(input) : btoa(input);
    } catch (e) {
    }
    document.getElementById('output').value = output;
  });
  