S = [i for i in input().strip()]
I = ["0" for i in range(len(S))]
i = 0
print(*I, sep = '')
while i < len(S):
    if I[i] == S[i]:
        i += 1
        continue
    I[i] = str(int(I[i]) + 1)
    print(*I, sep = '')