S = input().strip()
result = S[0]
flag = False
for index in range(1, len(S)):
    if S[index] == 'a' and S[index - 1] == 'z':
        result += S[index]
    elif ord(S[index]) - ord(S[index-1]) == 1:
        result += S[index]
    else:
        if len(result) > 1:
            print(result, end = "")
            flag = True
        result = S[index]
if len(result) > 1:
    print(result)
    flag = True
if not flag:
    print(-1)
