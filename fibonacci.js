let cal = 0;
function fibonacci(n) {
  cal++;
  console.log(cal);
  //return the nth index of series
  if (n < 2) {
    return n;
  }
  return fibonacci(n - 1) + fibonacci(n - 2);
}

// function fibonacciDp() {
//   const memoi = {};
//   return function fibo(n) {
//     cal++;
//     console.log(cal);

//     if (n < 2) {
//       if (memoi[n] === undefined) {
//         memoi[n] = n;
//       }
//       return n;
//     }

//     if (memoi[n - 1] === undefined) {
//       memoi[n - 1] = fibo(n - 1);
//     }
//     if (memoi[n - 2] === undefined) {
//       memoi[n - 2] = fibo(n - 2);
//     }
//     return memoi[n - 1] + memoi[n - 2];
//   };
// }

// for (const key in object) {
//   if (Object.hasOwnProperty.call(object, key)) {
//     const element = object[key];
//   }
// }
// function fibonacciDp() {
//   const memoi = {};
//   return function fibo(n) {
//     console.log(cal++);
//     if (n in memoi) {
//       return memoi[n];
//     }
//     if (n < 2) {
//       return n;
//     }

//     memoi[n] = fibo(n - 1) + fibo(n - 2);
//     return memoi[n];
//   };
// }

function fib(n) {
  const memo = {};
  // Compute the nth Fibonacci number
   function fibo(n, memo){
    //using recursion
    if(n < 0){
      assertThrowsError(negativeFib, desc);
      return;
    }
    
    if(n in memo){
      return memo[n];
    }
    
    if(n < 2){
      return n;
    }
    
    
    memo[n] = fibo(n - 1, memo) + fibo(n - 2, memo);
    return memo[n];
  }
  
  return fibo(n, memo);
}



const getSum = function (a, b) {
  // 1- get carry(left shifted by 1) using AND operator - a & b << 1
  // 2- get sum (no carry) with XOR operator - a ^ b
  // get actual sum by XORING above two
  // if step 1 & step 2 two gives futher carry, keep doing above process until carry is 0

  let temp;
  while ((a & b) !== 0) {
    debugger;
    temp = (a & b) << 1;
    a = a ^ b;
    b = temp;
  }
  return a ^ b;
};
// const fib = fibonacciDp();

console.log(getSum(4, 8));
