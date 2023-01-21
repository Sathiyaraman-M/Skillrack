Odd, Even = [], []
S = input().strip()
for i in S:
    N = int(i)
    if N % 2 == 0:
        Even.append(N)
    else:
        Odd.append(N)
Io, Ie = 0, 0
for i in S:
    if int(i) % 2 == 0:
        print(Odd[Io], end = '')
        Io += 1
    else:
        print(Even[Ie], end = '')
        Ie += 1