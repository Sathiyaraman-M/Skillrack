N = int(input())
L = list(map(int, input().split()))
S = []
i, Curr = 1, L[0]
while i < N:
    if L[i] <= L[i - 1]:
        S.append(Curr)
        Curr = L[i]
    else:
        Curr += L[i]
    i += 1
S.append(Curr)
print(max(S))