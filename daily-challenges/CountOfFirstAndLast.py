N = int(input())
L = list(map(int, input().strip().split()))
print(L.count(L[0] + L[-1]))