N = int(input())
L = list(map(int, input().split()))
O = L.copy()
X, Y = map(int, input().split())
for i in range(X):
    L.insert(0, L.pop())
for j in range(Y):
    L.append(L.pop(0))
print(*L)