N = int(input())
L = list(map(int, input().split()))
X = int(input())
R = []
for i in L:
    if i % 2 == 0:
        R.append(i + X)
    else:
        R.append(i - X)
print(*R)