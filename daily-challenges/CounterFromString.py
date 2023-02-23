S = input().strip()
C = 0
for i in S:
    if i == 'I':
        C += 1
    elif i == 'D':
        C -= 1
    elif i == 'R':
        C = 0
    else:
        pass
print(C)