N, X = map(int, input().split())
C = 0
for i in range(N):
    I = input().strip()
    if len(I) != X:
        print(I)
        C += 1
if C == 0:
    print('-1')