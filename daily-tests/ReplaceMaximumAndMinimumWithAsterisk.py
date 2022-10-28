R, C = map(int, input().split())
M = [list(map(int, input().split())) for i in range(R)]
Min, Max = 1000, -1000
for i in range(R):
    Min = min(Min, min(M[i]))
    Max = max(Max, max(M[i]))
for i in M:
    for j in i:
        print('*' if j == Min or j == Max else j, end = ' ')
    print()