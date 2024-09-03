let sequenciaFib = [0, 1]; 

function fibonacci(n) {
  if (n < sequenciaFib .length) {
    return sequenciaFib [n];
  } else {
    let nextFib = fibonacci(n-1) + fibonacci(n-2);
    sequenciaFib .push(nextFib);
    return nextFib;
  }
}

function pertenceFibonacci(num) {
  let i = 0;
  while (true) {
    let fib = fibonacci(i);
    if (fib === parseInt(num)) { 
      return true;
    } else if (fib > parseInt(num)) { 
      return false; 
    }
    i++;
  }
}

function calculoFibonacci() {
  let num = document.getElementById("num").value;
  let resultado = document.getElementById("resultado");

  if (pertenceFibonacci(num)) {
    resultado.innerHTML = `O numero ${num} pertence a sequencia de Fibonacci.`;
  } else {
    resultado.innerHTML = `O numero ${num} nao pertence a sequencia de Fibonacci.`;
  }
}