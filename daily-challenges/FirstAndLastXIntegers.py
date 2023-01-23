N = int(input())
L = list(map(int, input().strip().split()))
X = int(input())
Len = len(L)
for i in range(X):
    if L[i] != L[Len - X + i]:
        print("no")
        exit()
print("yes")