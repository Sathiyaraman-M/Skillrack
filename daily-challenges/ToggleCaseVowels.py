S = input().strip()
for i in S:
    if i in "aeiouAEIOU":
        print(i.upper() if i.islower() else i.lower(), end = '')
    else:
        print(i, end = '')