N = int(input())
L = [input().strip() for i in range(N)]

FirstWord = ""

for i in range(N):
    letter = L[i][0]
    count = 0
    for j in L:
        if j[-1] == letter:
            count += 1
    if count == 0:
        FirstWord = L[i]
        break

L.remove(FirstWord)

for i in range(N - 1):
    for j in L:
        if j[0] == FirstWord[-1]:
            print(j)
            FirstWord = j
            break
    L.remove(j)
