N = list(input().strip())[::-1]
C = 0
for i in range(len(N)):
    for j in range(i + 1):
        if C == len(N):
            print('* ' * (i + 1 - j), end = '')
            break
        print(N[C], end = ' ')
        C += 1
    if C == len(N):
        break
    print()