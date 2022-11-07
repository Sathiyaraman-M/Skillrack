def hasVowel(s):
    for i in s:
        if i in "aeiouAEIOU":
            return True
    return False
S = input().strip()
L = []
curr = ""
for i in S:
    if i in "aeiouAEIOU":
        L.append(curr)
        curr = ""
    curr += i
L.append(curr)
for i in L:
    if not hasVowel(i):
        print(i, end = '')
    else:
        print(i)