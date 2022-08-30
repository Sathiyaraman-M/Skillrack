N = int(input())
Max = 0
MaxIndices = []
for i in range(N):
    inp = input().strip()
    if inp.count('-') > Max:
        Max = inp.count('-')
        MaxIndices = [i + 1]
    elif inp.count('-') == Max:
        MaxIndices.append(i + 1)
    else:
        pass
print(*MaxIndices)