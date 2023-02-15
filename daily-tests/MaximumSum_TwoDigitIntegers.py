N = sorted(list(input().strip()))[::-1]
S = 0
C = len(N) // 2
R = [0] * C
for i in range(C):
    R[i] = int(N[i]) * 10
for i in range(C):
    R[i] += int(N[C + i])
print(sum(R))