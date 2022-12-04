N = int(input().strip())
B = bin(N)[2:]
for i in range(len(B)):
    print('*' * i, B[i:], sep = '')