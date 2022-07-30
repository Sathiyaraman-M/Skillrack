def transpose(M, R, C):
    T = []
    for i in range(C):
        row = []
        for j in range(R):
            row.append(M[j][i])
        T.append(row)
    return T

R, C = map(int, input().split())
M = [list(map(int, input().split())) for i in range(R)]
N = int(input())

T = transpose(M, R, C)
    
while N > 0:
    MaxSum = T[0]
    for i in T[1:]:
        if sum(MaxSum) < sum(i):
            MaxSum = i
    T.remove(MaxSum)
    N -= 1

Final = transpose(T, len(T), R)

for i in Final:
    print(*i)