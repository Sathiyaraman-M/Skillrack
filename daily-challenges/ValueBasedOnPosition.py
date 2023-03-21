N = input().strip()
L = len(N)
for i in range(L):
    print(int(N[i]) * int(pow(10, L - i - 1)), end = ' ')