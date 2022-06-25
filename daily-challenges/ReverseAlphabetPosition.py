S = input().strip()
for i in S:
  O = ord('Z') if i.isupper() else ord('z')
  A = ord('A') if i.isupper() else ord('a')
  print(chr(O - ord(i) + A), end = "")
