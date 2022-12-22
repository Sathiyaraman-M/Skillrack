N = int(input())
B = bin(N)[2:]
print(B)
for i in range(1, len(B) - 1):
    print(B[i], '*' * (len(B) -2), B[len(B) - i - 1], sep = '')
print(B[::-1])