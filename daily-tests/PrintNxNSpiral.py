N = int(input())
matrix = [[0 for col in range(N)] for row in range(N)]
num = 1
for row in range(N):
    for col in range(N):
        matrix[row][col] = num 
        num += 1 
for ctr in range(N // 2):
    for col in range(ctr, N - ctr):
        print(matrix[ctr][col], end=" ")
    for row in range(ctr + 1, N - ctr):
        print(matrix[row][N - ctr - 1], end = " ")
    for col in range(N - ctr - 2, ctr - 1, -1):
        print(matrix[N - ctr - 1][col], end = " ")
    for row in range(N - ctr - 2, ctr, - 1):
        print(matrix[row][ctr], end = " ")
if N % 2:
    print(matrix[N // 2][N // 2])
