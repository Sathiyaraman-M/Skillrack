N = int(input())
M = []
M.append([i for i in range(1, N + 1)])
val = N + 1
for i in range(2, N + 1):
    if i % 2 == 0:
        M.append([i for i in range(val + N - i, val - 1, -1)])
        val = val + N - i
    else:
        M.append([i for i in range(val + 1, val + N - i + 2)])
        val = val + N - i + 2
count = 0
for i in range(N):
    M[i] = [0 for j in range(count)] + M[i]
    for j in range(N):
        print(M[j][i] if M[i][j] == 0 else M[i][j], end = " ")
    print()
    count += 1