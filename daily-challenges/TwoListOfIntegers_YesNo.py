L1 = list(map(int, input().split()))
L2 = list(map(int, input().split()))
for i in set(L2):
    if i not in L1 or L1.count(i) != L2.count(i):
        print("NO")
        exit()
print("YES")