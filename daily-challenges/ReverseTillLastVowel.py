S = input().strip()
I = 0
for i in range(len(S)):
    if S[i] in "aeiouAEIOU":
        I = i
print(S[:I][::-1], S[I:], sep = '')