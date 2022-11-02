N = int(input())
L = list(map(int, input().split()))
C1, C2 = [], []
for i in L:
    if ((i // 10) % 10) % 2 != 0:
        C1.append(i)
    else:
        C2.append(i)
if len(C1) > len(C2):
    print(*C1)
elif len(C1) < len(C2):
    print(*C2)
else:
    print("-1")