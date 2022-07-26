N = int(input())
I = 1
for i in range(N):
    if i == 0 or i == N - 1:
        print(N * '* ')
    else:
        print('*', end = " ")
        for j in range(N - 2):
            if i == N // 2 and j + 1 == N // 2:
                print('*', end = " ")
            else:
                print(I, end = " ")
            I += 1
        print('*')
print("Working")