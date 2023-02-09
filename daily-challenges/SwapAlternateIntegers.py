N = int(input())
L = list(map(int, input().split()))
for i in range(0, N, 3):
    print(*L[i: i + 3][::-1], end = ' ')