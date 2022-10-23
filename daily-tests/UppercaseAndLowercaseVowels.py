S = input().strip()
lower, upper = 0, 0
for i in S:
    if i.islower() and i in "aeiou":
        lower += 1
    if i.isupper() and i in "AEIOU":
        upper += 1
if lower != 0 or upper != 0:
    print(lower, upper)
else:
    print(-1)