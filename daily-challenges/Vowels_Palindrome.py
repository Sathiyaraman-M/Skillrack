S = input().strip()
V = ""
for i in S:
    if i in "aeiouAEIOU":
        V += i
print("-1" if len(V) == 0 else ("YES" if V == V[::-1] else "NO"))
