S = input().strip()
for i in range(1, len(S) - 1):
    isalp = S[i].isalpha()
    if S[i - 1].isalpha() != S[i + 1].isalpha():
        continue
    isalp = S[i + 1].isalpha()
    result = ""
    for j in range(i - 1, -1, -1):
        if S[j].isalpha() == isalp:
            result = S[j] + result
        else:
            break
    for j in range(i + 1, len(S)):
        if S[j].isalpha() == isalp:
            result += S[j]
        else:
            break
    print(result, end = " ")