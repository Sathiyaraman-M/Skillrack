S = input().strip()
C, V = [], []
for i in S:
    if i in "aeiouAEIOU":
        V.append(i)
    else:
        C.append(i)
Iv, Ic = 0, 0
R = ""
for i in S:
    if i in "aeiouAEIOU":
        if Iv == 0:
            R += V[Iv]
        else:
            R += V[Iv - 1]
        Iv += 1
    else:
        if Ic == 0:
            R += C[Ic]
        else:
            R += C[Ic - 1]
        Ic += 1
print(R)