S = input().strip()
for i in range(len(S)):
    if i % 2 != 0:
        print(S[i], end = "")
    else:
        if S[i].isupper() and S[i] in "AEIOU":
            print(S[i].lower(), end = "")
        elif S[i].islower() and S[i] in "aeiou":
            print(S[i].upper(), end = "")
        else:
            print(S[i], end = "")
        