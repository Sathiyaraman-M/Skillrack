X, Y, N = map(int, input().split())
I, J = 1, 1
for i in range(N):
    if i % 2 == 0:
        print(I * X, end = ' ')
        I += 1
    else:
        print(J * Y, end = ' ')
        J += 1