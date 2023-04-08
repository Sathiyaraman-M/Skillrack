N = int(input())
I = []
M = 0
for i in range(N):
    P, D = map(int, input().split())
    I.append([P - D, D])
    M = max(M, P - D)
R = []
for i in I:
    if i[0] == M:
        R.append(i[1])
print(min(R))