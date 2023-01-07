S = input().strip()
L = len(S)
S1, S2 = S[: L // 2], S[L // 2:]
if L % 2 != 0:
    S2 = S[(L // 2) + 1:]
print("yes" if S1 == S2 else "no")