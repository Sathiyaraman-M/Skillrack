R, C = map(int, input().split())
M = [list(map(int, input().split())) for i in range(R)]
Max = 0
MaxIndex = 0
index = 0
for i in M:
    count = 0
    for j in i:
        count += 1 if j < 0 else 0
    if Max < count:
        Max = count
        MaxIndex = index
    index += 1
if Max != 0:
    print(*M[MaxIndex])
else:
    print(-1)