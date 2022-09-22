S = input().strip()
N = S[0] if int(S[1]) % 2 == 0 else ""
for i in range(1, len(S) - 1):
    N += S[i] if int(S[i - 1]) % 2 == 0 and int(S[i + 1]) % 2 == 0 else ""
N += S[-1] if int(S[-2]) % 2 == 0 else ""
print(N if len(N) > 0 else "-1")
