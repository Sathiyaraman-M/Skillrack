N = int(input())
L = list(map(int, input().split()))
X, Y = map(int, input().split())
if L.count(X) >= L.count(Y):
    print("YES")
else:
    print("NO")