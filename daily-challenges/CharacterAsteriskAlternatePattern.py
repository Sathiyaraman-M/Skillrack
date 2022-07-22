def inc(c):
    if c == 'z':
        return 'a'
    return chr(ord(c) + 1)

N = int(input())
c = 'a'
for i in range(N):
    if i % 2 == 0:
        for j in range(N):
            print(c, end = "")
            c = inc(c)
            if j != N - 1:
                print('*', end = "")
    else:
        print('*', end = "")
        for j in range(N - 1):
            print(c, '*', sep = "", end = "")
            c = inc(c)
    print()