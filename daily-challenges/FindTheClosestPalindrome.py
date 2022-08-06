N = int(input())
L, R = N - 1, N + 1
while str(L) != str(L)[::-1] and str(R) != str(R)[::-1]:
    L -= 1
    R += 1

if str(L) == str(L)[::-1]:
    print(L)
else:
    print(R)