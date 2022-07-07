N = int(input())
L = 0
increase = True
for i in range(N):
    if increase:
        if L <= N // 2:
            L += 1
            if L == N // 2 + 1:
                increase = False
    else:
        L -= 1
    for j in range(L):
        if i % 2 != 0:
            print('-' if j % 2 == 0 else '*', end = "")
        else:
            print('*' if j % 2 == 0 else '-', end = "")
    print()