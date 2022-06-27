S = input().strip()
for i in S:
    print(chr(ord('a') + ord('z') - ord(i)) if i.isalpha() else i, end = "")
