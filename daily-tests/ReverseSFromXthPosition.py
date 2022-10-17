S = input().strip()
N = int(input()) - 1
print(S[:N] + S[N:][::-1])