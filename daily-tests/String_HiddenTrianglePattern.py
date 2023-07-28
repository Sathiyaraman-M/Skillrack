S = input().strip()
L = len(S)
R = [S]
for i in range(L // 2):
    T = S[L - i - 1:] + S[i + 1: L - i - 1] + S[: i + 1]
    R.append(T)
print("\n".join(*R[::-1]))