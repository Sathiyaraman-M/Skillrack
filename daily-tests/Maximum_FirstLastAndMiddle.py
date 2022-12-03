N = int(input())
L = list(map(int, input().strip().split()))
print(max(L[0], L[-1], L[N // 2]))