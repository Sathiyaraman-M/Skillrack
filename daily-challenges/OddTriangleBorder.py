N = int(input())
M = [list(map(int, input().split())) for i in range(N)]
for i in range(N):
  for j in range(N):
    if i == 0 or i == N - 1 or j == 0 or j == N - 1:
      if M[i][j] % 2 != 0:
        print(M[i][j], end = " ")
