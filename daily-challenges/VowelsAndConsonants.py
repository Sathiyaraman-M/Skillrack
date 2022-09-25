S = input().strip()
V, C = "", ""
for i in S:
    if i in "aeiouAEIOU":
        V += i
    else:
        C += i
print(V + C)