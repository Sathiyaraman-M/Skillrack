S, a, b = map(str, input().strip())
M, N = int(a), int(b)
print(S[M: N + 1] if M <= N else S[M:] + S[:N + 1])
