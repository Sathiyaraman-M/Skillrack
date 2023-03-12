L = "bcdfghjklmnpqrstvwxyz"
C = input().strip()
while ord(L[0]) < ord(C):
    L = L[1:] + L[0:1]
print(L)