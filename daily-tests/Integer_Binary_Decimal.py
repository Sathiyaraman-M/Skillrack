N = input()
B = ''
for i in N:
    B += '1' if int(i) % 2 != 0 else '0'
print(int(B, 2))