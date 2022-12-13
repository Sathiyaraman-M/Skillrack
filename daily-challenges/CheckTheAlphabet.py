S = input().strip()
X = int(input())
C = chr(ord('a') + X - 1)
print("yes" if C in S else "no")