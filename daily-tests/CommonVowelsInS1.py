S1 = input().strip()
S2 = input().strip()
for i in S1:
    if i in "aeiou" and i in S2:
        print(i, end = "")