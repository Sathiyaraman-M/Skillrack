N = int(input())
L = list(map(int, input().split()))
for i in range(1, N):
    if L[i] != L[i - 1] + L[i + 1]:
        print(L[i] + L[i + 1])
        exit()
print(L[i - 1] + L[i - 2])