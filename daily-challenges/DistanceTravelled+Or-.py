S = input().strip()
C = 0
for i in S:
    if i == '-':
        C -= 1
    else:
        C += 1
print(abs(C))