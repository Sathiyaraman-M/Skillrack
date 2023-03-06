S = input().strip()
I = 0
V = "aeiou"
for i in S:
    if i not in V:
        print(i, end = '')
    else:
        print(V[I], end = '')
        I = (I + 1) % 5