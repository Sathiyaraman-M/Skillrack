N = int(input())
Temp = N
Odd = -1
while Temp > 0:
    digit = Temp % 10
    if digit % 2 != 0 and Odd < digit:
        Odd = digit
    Temp //= 10
print(N * Odd if Odd != -1 else -1)