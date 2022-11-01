N = int(input())
M1 = [list(map(int, input().split())) for i in range(N)]
M2 = [list(map(int, input().split())) for i in range(N)]
S1, S2 = 0, 0
for i in range(N):
    S1 += sum(M1[i][:i + 1])
    S2 += sum(M2[i][:i + 1])
if S1 > S2:
    for i in range(N):
        print(*M1[i][:i + 1])
else:
    for i in range(N):
        print(*M2[i][:i + 1])