def check(i):
    return i not in "aeiouAEIOU"
S = input().strip()
C = 0
for i in range(len(S) - 1):
    if check(S[i]) and check(S[i + 1]):
        C += 1
print(C)