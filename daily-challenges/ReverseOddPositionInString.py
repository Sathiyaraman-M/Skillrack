S = input().strip()
Odd = []
for i in range(len(S)):
    if i % 2 == 0:
        Odd.append(S[i])
Odd = Odd[::-1]
for i in range(len(S)):
    if i % 2 == 0:
        print(Odd.pop(0), end = "")
    else:
        print(S[i], end = "")
