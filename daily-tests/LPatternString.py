S = input().strip()
print(*list(S[:len(S) // 2]), sep = '\n')
print(*list(S[len(S) // 2:]), sep = ' ')