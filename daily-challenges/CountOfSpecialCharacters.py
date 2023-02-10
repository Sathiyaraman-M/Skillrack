S = input().strip()
R = ""
for i in S:
    if not i.isalnum():
        R += i
print(len(R))