n, tokens = map(str, input().split())
N = int(n)
ind = 0
S = tokens * 99
for i in range(N):
    print(' ' * (N - i), end = "")
    for j in range(2 * i + 1):
        print(S[ind], end = "")
        ind += 1
    print()