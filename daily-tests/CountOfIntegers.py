M, N = map(int, input().split())
L1 = list(map(int, input().strip().split()))
L2 = list(map(int, input().strip().split()))
Min = M if M < N else N
Count = 0
for i in range(Min):
    if L1[i] == L2[i]:
        Count += 1
print(Count)