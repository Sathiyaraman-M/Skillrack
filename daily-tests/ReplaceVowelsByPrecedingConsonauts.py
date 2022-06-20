S = input().strip()
vowels = 'aeiouAEIOU'
cons = S[0]
for i in range(len(S)):
    if S[i] in vowels:
        print(cons, end = '')
    else:
        print(S[i], end = '')
        cons = S[i]
