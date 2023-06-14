W = input().strip()
C = sum([1 for i in W if i in "aeioAEIOU"])
if C == 0:
    print("-1")
    exit()
print(W[::2] if C % 2 != 0 else W[1::2])