L = input().strip().split()
S = []
for i in range(len(L) - 1):
    for j in range(i + 1, len(L)):
        if (L[i] + L[j]) == (L[i] + L[j])[::-1]:
            S.append(L[i] + L[j])
        if (L[j] + L[i]) == (L[j] + L[i])[::-1]:
            S.append(L[j] + L[i])
print(len(S))