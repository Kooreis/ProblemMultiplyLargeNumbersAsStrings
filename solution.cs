Here is a JavaScript solution for multiplying two large numbers represented as strings:

```javascript
function multiply(num1, num2) {
    let len1 = num1.length;
    let len2 = num2.length;
    if (len1 == 0 || len2 == 0) return "0";

    let result = Array(len1 + len2).fill(0);

    let i_n1 = 0;
    let i_n2 = 0;

    for (let i = len1 - 1; i >= 0; i--) {
        let carry = 0;
        let n1 = num1[i].charCodeAt() - '0'.charCodeAt();

        i_n2 = 0;

        for (let j = len2 - 1; j >= 0; j--) {
            let n2 = num2[j].charCodeAt() - '0'.charCodeAt();

            let sum = n1 * n2 + result[i_n1 + i_n2] + carry;

            carry = Math.floor(sum / 10);

            result[i_n1 + i_n2] = sum % 10;

            i_n2++;
        }

        if (carry > 0) result[i_n1 + i_n2] += carry;

        i_n1++;
    }

    let i = result.length - 1;
    while (i >= 0 && result[i] == 0) i--;

    if (i == -1) return "0";

    let s = "";

    while (i >= 0) s += result[i--];

    return s;
}

console.log(multiply("123456789", "987654321"));
```

This program multiplies two large numbers represented as strings by treating each digit as a separate number and multiplying them individually, carrying over any overflow to the next digit. The result is then converted back into a string and returned.