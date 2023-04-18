N = int(input())
M = [[0] * N for _ in range(N)]
End = N * (N - 1)
O, E = [i for i in range(1, End + 1, 2)], [i for i in range(2, End + 1, 2)]
O1, E1 = 0, 0
for i in range(N):
    for j in range(N):
        if i != j:
            if j < i:
                M[j][i] = O[O1]
                O1 += 1
            else:
                M[j][i] = E[E1]
                E1 += 1
for i in M:
    print(*i)