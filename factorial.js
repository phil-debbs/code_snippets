function factorial(n) {
  //n * (n-1)!
  if (n <= 2) {
    return 2;
  }
  return n * factorial(n - 1);
}

console.log(factorial(5));
