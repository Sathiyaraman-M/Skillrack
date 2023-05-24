N = [i for i in bin(int(input().strip()))[2:]]
I = 1
for i in range(len(N)):
    if N[i] == '1':
        N[i] = str(I)
        I += 1
I = 1
for i in range(len(N) - 1, -1, -1):
    if N[i] == '0':
        N[i] = str(I)
        I += 1
print("".join(N))