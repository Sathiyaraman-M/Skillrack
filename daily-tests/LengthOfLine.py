R, C = map(int, input().strip().split())
M = [input().strip() for _ in range(R)]
Count = 0
for i in M:
    Dots = i.split('#')
    Count = max(max([len(j) for j in Dots]), Count)
T = []
for i in range(C):
    Row = []
    for j in range(R):
        Row.append(M[j][i])
    T.append(Row)
for i in T:
    Dots = ''.join(i).split('#')
    Count = max(max([len(j) for j in Dots]), Count)
print(Count)