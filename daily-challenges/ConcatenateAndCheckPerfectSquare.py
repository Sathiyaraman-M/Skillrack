from math import sqrt
X, Y = map(str, input().split())
Z = sqrt(int(X + Y))
print("Yes" if int(Z) == Z else "No")