N = int(input())
B = int(bin(N)[2:])
C = 0
while B % 10 == 0:
    C += 1
    B //= 10
print(C)