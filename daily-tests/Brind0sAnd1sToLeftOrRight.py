R, C = map(int, input().split())
M = [list(map(int, input().split())) for _ in range(R)]
for i in range(R):
    if i % 2 == 0:
        print(*sorted(M[i]))
    else:
        print(*sorted(M[i])[::-1])