S = [i for i in input().strip()]
Odd = []
Even = []
for i in set(S):
    if S.count(i) % 2 != 0:
        Odd += [i]
    else:
        Even += [i]
print(*sorted(Odd), sep = '', end = '')
print(*sorted(Even)[::-1], sep = '')