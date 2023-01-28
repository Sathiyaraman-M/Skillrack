N = int(input())
L = input().split()
R = []
for i in L:
    if i[-2:] == "10":
        R.append(i)
if len(R) > 0:
    print(*R)
else:
    print("-1")