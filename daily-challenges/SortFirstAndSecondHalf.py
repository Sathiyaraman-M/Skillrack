N = int(input())
L = list(map(int, input().split()))
print(*sorted(L[:N // 2]), *sorted(L[N // 2::])[::-1])