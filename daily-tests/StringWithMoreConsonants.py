S1 = input().strip()
S2 = input().strip()
s1, s2 = "", ""
for i in S1:
    if i not in "aeiouAEIOU":
        s1 += i
for i in S2:
    if i not in "aeiouAEIOU":
        s2 += i
if len(s1) == len(s2):
    print(S1 if len(S1) > len(S2) else S2)
else:
    print(S1 if len(s1) > len(s2) else S2)