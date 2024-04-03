function romanToInt(s) {
  const symbols = { I: 1, V: 5, X: 10, L: 50, C: 100, D: 500, M: 1000 };

  let num = 0;
  let i = 0;
  while (i < s.length) {
    const cha = symbols[s[i]];
    const nextCha = symbols[s[i + 1]];
    if (cha < nextCha) {
      num += nextCha - cha;
      i = i + 2;
    } else {
      num += cha;
      i++;
    }
  }
  //   for (let i = 0; i < s.length; i++) {
  //     debugger;
  //     const cha = symbols[s[i]];
  //     const nextCha = symbols[s[i + 1]];
  //     if (cha < nextCha) {
  //       num += nextCha - cha;
  //     } else {
  //       num += cha;
  //     }
  //   }
  return num;
}

console.log(romanToInt("IV"));
