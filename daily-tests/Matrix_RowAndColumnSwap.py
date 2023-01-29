R, C = map(int, input().split())
M = [list(map(int, input().split())) for i in range(R)]
M[0], M[-1] = M[-1], M[0]
for i in M:
    i[0], i[-1] = i[-1], i[0]
    print(*i)