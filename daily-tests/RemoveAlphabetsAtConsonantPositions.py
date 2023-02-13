S = input().strip()
Rev = S[::-1]
R = ""
for i in range(len(S)):
    if S[i] in "aeiouAEIOU":
        R += Rev[i]
print(R)