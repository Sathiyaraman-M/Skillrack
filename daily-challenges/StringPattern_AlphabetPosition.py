S = input().strip()
for i in S:
    print(i * (ord(i) - ord('a') + 1))