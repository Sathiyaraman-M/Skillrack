S = input().strip()
D = S[0]
for i in S[1:]:
    if D[-1].islower() != i.islower():
        D += i
print(D)