function checkParity(parity, bin) {
    var bits = bin.split("").map(Number);
    var sum = bits.reduce(function(a,b){
      return a + b;
    }, 0);
  if (parity == 'even') {
    if (sum % 2 == 0) {
      return 0
    } else {
      return 1
    }
  }
  if (parity == 'odd') {
    if (sum % 2 == 1) {
      return 0
    } else {
      return 1
    }
  }
}

checkParity('even', '101010')