R, C = map(int, input().split())
M = [list(map(int, input().split())) for i in range(R)]
Row, Sum = M[0], sum(M[0])
for i in M[1:]:
    if sum(i) > Sum:
        Sum = sum(i)
        Row = i
M.remove(Row)
for i in M:
    print(*i)
