L = input().strip().split()
minLen = len(L[0])
minIndex = 0
for i in range(1, len(L)):
    if minLen > len(L[i]):
        minIndex = i
        minLen = len(L[minIndex])
print(L[minIndex])