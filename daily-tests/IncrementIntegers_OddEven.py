N = int(input())
L = list(map(int, input().split()))
R = []
for i in L:
    if (i % 10) % 2 == 0:
        R.append(i + 1)
    else:
        T = ((i % 100) // 10)
        if T != 9:
            R.append(i + 10)
        else:
            R.append(i - 90)
print(*R)