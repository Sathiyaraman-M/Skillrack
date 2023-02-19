S = input().strip()
R = []
for i in range(26):
    if chr(ord('a') + i) not in S:
        R.append(chr(ord('a') + i))
print(*R, sep = '')