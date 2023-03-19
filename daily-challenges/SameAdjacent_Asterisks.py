S = input().strip().strip('*').split('*')
for i in range(1, len(S)):
    if S[i - 1][-1] != S[i][0]:
        print("NO")
        exit()
print("YES")