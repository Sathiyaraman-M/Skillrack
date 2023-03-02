N, M = map(int, input().split())
A, B = 0, 1
R = [A, B]
while M not in R:
    A, B = B, A + B
    R.append(B)
print(*R[::-1])