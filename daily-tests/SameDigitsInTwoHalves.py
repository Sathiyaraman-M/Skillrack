N = input().strip()
_1H = sorted([int(i) for i in N[:len(N) // 2]])
_2H = sorted([int(i) for i in N[len(N) // 2:]])
for i in range(len(N) // 2):
    if _1H[i] != _2H[i]:
        print("no")
        exit()
print("yes")