N = int(input())
M = [list(map(int, input().split())) for _ in range(N)]
T = []
for i in M[0]:
    T.append([])
    for j in M[i - 1]:
        T[-1].append(j)
for i in range(N):
    for j in range(N):
        print(T[j][i], end = ' ')
    print()