def getStr(arr):
    word = ""
    for i in arr:
        word += str(i)
    return word

N = int(input())
B = list(bin(N)[2:])

if N == 1:
    print('1')
    exit()

L = []
for i in range(len(B) - 1):
    for j in range(i, len(B)):
        if int(getStr(B[i:j + 1])) not in L:
            L.append(int(getStr(B[i:j + 1]), 2))

print(*L)