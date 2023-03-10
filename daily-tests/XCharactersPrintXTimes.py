S = input().strip()
N = int(input())
for i in range(0, len(S), N):
    print(N * S[i: i + N], end = '')