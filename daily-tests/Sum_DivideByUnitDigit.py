N = int(input())
L = list(map(int, input().split()))
S = 0.0
for i in L:
    if i % 10 == 0:
        S += i / 10
    else:
        S += i / (i % 10)
print("{0:0.3f}".format(S))