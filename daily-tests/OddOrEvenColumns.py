R, C = map(int, input().split())
M = [list(map(int, input().split())) for _ in range(R)]
T = []
for i in range(C):
    Row = []
    for j in range(R):
        Row.append(M[j][i])
    T.append(Row)
A = []
for i in T:
    F = True
    for j in i[1:]:
        if i[0] % 2 != j % 2:
            F = False
            break
    if F:
        A.append(i)
if len(A) == 0:
    print("-1")
    exit()
for i in range(R):
    for j in range(len(A)):
        print(A[j][i], end = ' ')
    print()