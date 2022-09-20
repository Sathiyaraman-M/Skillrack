X, Y = map(int, input().split())
for i in range(X, Y + 1):
    if not (len(set(str(i))) == 1 and len(str(i)) != 1):
        print(i, end = " ")