S = input().strip()
R = ord(S[0]) - ord('a') + 1
for i in range(1, len(S)):
    R = R * 26 + ord(S[i]) - ord('a') + 1
print(R)