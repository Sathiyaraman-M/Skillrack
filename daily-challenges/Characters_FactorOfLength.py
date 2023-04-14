S = input().strip()
L = len(S)
print("".join([S[i - 1] for i in range(1, L + 1) if L % i == 0]))