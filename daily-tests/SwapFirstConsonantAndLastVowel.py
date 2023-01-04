S = input().strip()
A, B = 0, len(S) - 1
for i in range(len(S)):
    if S[i] not in "aeiouAEIOU":
        A = i
        break
for i in range(len(S) - 1, -1, -1):
    if S[i] in "aeiouAEIOU":
        B = i
        break
for i in range(len(S)):
    if i == A:
        print(S[B], end = '')
    elif i == B:
        print(S[A], end = '')
    else:
        print(S[i], end = '')