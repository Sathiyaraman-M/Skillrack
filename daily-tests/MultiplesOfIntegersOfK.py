S, X = map(str, input().strip().split())
K, L = int(X), len(S)
I = (K - 1) % L
while I != L - 1:
    print(S[I], end = '')
    I = (I + K) % L
print(S[-1])