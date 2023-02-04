N = int(input())
L = list(map(int, input().split()))
for i in L:
    print(chr(i + 96), end = '')