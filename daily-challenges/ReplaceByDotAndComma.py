S = input().strip()
R = ""
DotMode = True
for i in S:
    if not i.isalnum():
        R += ("." if DotMode else ",")
        DotMode = not DotMode
    else:
        R += i
print(R)