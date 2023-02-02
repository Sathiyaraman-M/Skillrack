S = input().strip()
R = ""
for i in S:
    if i not in "1234567890":
        R += ' '
    else:
        R += i
L = R.strip().split()
if len(L) % 2 != 0:
    print(L[len(L) // 2])
else:
    print(*L[(len(L) // 2) - 1: (len(L) // 2) + 1])