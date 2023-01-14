N = int(input())
L = list(map(int, input().split()))
print("yes" if L == sorted(L)[::-1] else "no")