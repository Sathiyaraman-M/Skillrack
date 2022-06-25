S = abs(int(input()))
S = str(S)
for i in S:
    a = int(i)
    if a % 2 != 0:
        print(-1 * a**2, end = "")
    else:
        print(a**2, end = "")
