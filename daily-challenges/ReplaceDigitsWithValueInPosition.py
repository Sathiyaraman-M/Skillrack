S = input().strip()
for i in S:
    print(S[int(i) - 1] if int(i) - 1 < len(S) else '0', end = "")
