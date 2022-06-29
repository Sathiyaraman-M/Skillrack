N = int(input())
L = list(map(int, input().split()))
Count = 0
for i in range(len(L) - 1):
  if L[i] + 1 == L[i + 1]:
    Count += 1
print(Count)
