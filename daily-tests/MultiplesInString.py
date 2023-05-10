S = input().strip()
N = int(input())
L = len(S)
if L % N == 0:
    print("".join([S[i] for i in range(L) if (i + 1) % N == 0]))
else:
    print("".join([S[i] for i in range(L) if (i + 1) % N != 0]))