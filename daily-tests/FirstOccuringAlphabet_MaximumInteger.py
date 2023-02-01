N = int(input())
L = sorted(input().split())
A = L[0][0]
R = []
for i in range(N):
    if L[i][0] == A:
        R.append(int(L[i][1:]))
    else:
        break
print(A, sorted(R)[-1], sep = '')