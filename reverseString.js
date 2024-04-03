function reverseString(s) {
  let rs = ""; //reversed string
  for (let i = s.length - 1; i >= 0; i--) {
    rs = rs + s[i];
  }
  return rs;
}

console.log(reverseString("My name is Philip."));
