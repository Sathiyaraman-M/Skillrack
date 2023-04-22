def factors(N):
    R = [1]
    for i in range(2, (N // 2) + 1):
        if N % i == 0:
            R.append(i)
    if N not in R:
        R.append(N)
    return R
X, Y = map(int, input().split())
A, B = factors(X), factors(Y)
I, J = 0, 0
for i in range(len(A) + len(B) + 1):
    if I == len(A) or J == len(B):
        break
    if i % 2 == 0:
        print(A[I], end = ' ')
        I += 1
    else:
        print(B[J], end = ' ')
        J += 1
if I == len(A):
    print(*B[J:])
elif J == len(B):
    print(*A[I:])
else:
    pass