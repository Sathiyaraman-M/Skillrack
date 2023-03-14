S = input().strip()
C = 0
for i in S:
    if i in "AEIOU":
        C += 1
    elif i in "aeiou":
        C -= 1
    else:
        pass
print(abs(C))