N = int(input())
L1 = list(map(int, input().split()))
L2 = list(map(int, input().split()))
for i in range(N):
    print(min(L1[i], L2[i]), end = ' ')
