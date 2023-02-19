N, K = map(int, input().split())
L = [input().strip() for _ in range(N)]
R = 0
for i in L:
    C = 0
    for j in set(i):
        if i.count(j) == 1:
            C += 1
    if C <= K:
        R += 1
print(R)