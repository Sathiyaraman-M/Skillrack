N = input().strip()
S = ""
for i in N[::-1]:
    if int(i) % 2 == 0:
        S += i
print(str(int(S)) if S != "" else "-1")