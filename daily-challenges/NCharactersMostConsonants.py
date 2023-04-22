def count(s):
    C = 0
    for i in s:
        if i not in "aeiouAEIOU":
            C += 1
    return C
S, A = map(str, input().split())
N = int(A)
F, L = count(S[:N]), count(S[len(S) - N:])
if F == L:
    print(S)
elif F > L:
    print(S[:N])
else:
    print(S[len(S) - N:])