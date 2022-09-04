N = input().strip()
X, Y = map(int, input().split())
Count = 0
for i in range(X + 1, Y):
    Count += str(i).count(N)
print(Count)