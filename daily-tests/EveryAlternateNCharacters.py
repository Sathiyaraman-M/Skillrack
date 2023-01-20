I = input().strip().split()
S, N = I[0], int(I[1])
for i in range(0, len(S), N * 2):
    print(S[i: i + N], end = '')