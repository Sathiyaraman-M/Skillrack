S = input().strip()
T = 0
for i in S:
    if i not in "aeiouAEIOU":
        T += 1
print(T, end = ' ')
for i in S[:-1]:
    if i not in "aeiouAEIOU":
        T -= 1
    print(T, end = ' ')