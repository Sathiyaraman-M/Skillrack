N = int(input())
S = input().split()
print(*S[: N][::-1], end = ' ')
print(*S[N:])