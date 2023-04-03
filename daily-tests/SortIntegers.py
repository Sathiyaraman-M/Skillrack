N = int(input())
L = list(map(int, input().split()))
E = sorted([i for i in L if i % 2 == 0])
I = 0
for i in L:
    if i % 2 == 0:
        print(E[I], end = ' ')
        I += 1
    else:
        print(i, end = ' ')