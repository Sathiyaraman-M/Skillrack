N = input().strip()
for i in range(len(N) - 1):
    P1, P2 = N[:i + 1], N[i + 1:]
    print(int(P1) * int(P2), end = ' ')