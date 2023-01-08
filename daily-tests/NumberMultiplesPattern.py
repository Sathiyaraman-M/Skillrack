N = int(input())
for i in range(N):
    print(*((i + 1) * (j + 1) for j in range(i + 1)))