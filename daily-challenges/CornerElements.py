R, C = map(int, input().split())
M = [list(map(int, input().split())) for _ in range(R)]
print(M[0][0], M[0][-1], M[-1][0], M[-1][-1])