S1 = input().strip()
S2 = input().strip()
s1 = ""
s2 = ""
for i in S1:
    if i == '#':
        s1 = s1[:-1]
    else:
        s1 += i
for i in S2:
    if i == '#':
        s2 = s2[:-1]
    else:
        s2 += i
print("YES" if s1 == s2 else "NO")