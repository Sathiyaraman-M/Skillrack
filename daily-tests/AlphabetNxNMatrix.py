a, b = map(str, input().split())
N = int(b)
for i in range(N):
    for j in range(N):
        print(a, end = " ")
        if ord(a) + 1 > ord('z'):
            a = 'a'
        else:
            a = chr(ord(a) + 1)
    print()