S = input().strip()
F = ""
L = ""
for i in range((len(S) // 2) + 1):
    F = F + S[i]
    L = S[len(S) - i - 1] + L
    if F != L[::-1]:
        break
print(len(F) - 1 if len(F) != 1 else -1)