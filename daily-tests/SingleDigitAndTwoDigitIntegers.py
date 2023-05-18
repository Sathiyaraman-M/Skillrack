N = int(input())
L = input().strip().split()
L1 = [i for i in L if len(i) == 1]
L2 = [i for i in L if len(i) == 2]
if len(L1) != 0:
    print(*L1)
else:
    print("-1")
if len(L2) != 0:
    print(*L2)
else:
    print("-1")