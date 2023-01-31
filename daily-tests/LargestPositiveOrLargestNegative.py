N = int(input())
L = list(map(int, input().split()))
Pos, Neg = [], []
for i in L:
    if i == 0:
        continue
    if i > 0:
        Pos.append(i)
    else:
        Neg.append(i)
if len(Pos) == 0 and len(Neg) == 0:
    print("-1")
    exit()
print(max(Pos) if len(Pos) >= len(Neg) else max(Neg))