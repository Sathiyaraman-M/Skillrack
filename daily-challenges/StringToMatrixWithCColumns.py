S, A = map(str, input().strip().split())
N = int(A)
if len(S) % N != 0:
    S += '*' * (N - (len(S) % N))
for i in range(len(S) // N):
    print(S[i * N: i * N + N])