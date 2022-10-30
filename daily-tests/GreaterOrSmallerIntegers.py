N, X = map(int, input().split())
L = list(map(int, input().split()))
Min, Max = [], []
for i in L:
    if i >= X:
        Max.append(i)
    else:
        Min.append(i)
if len(Min) <= len(Max):
    print(*Max)
else:
    print(*Min)