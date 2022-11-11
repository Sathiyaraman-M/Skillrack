S = list(input().strip().split())
print(S[0], end = ' ')
for i in range(1, len(S) - 1):
    print(S[i][::-1], end = ' ')
print(S[-1], end = ' ')