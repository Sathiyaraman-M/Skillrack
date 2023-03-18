T = int(input())
S = 0
for i in range(T):
    I = input().split()
    Shp = I[0]
    if Shp == "square":
        S += int(I[1]) * int(I[1])
    else:
        S += int(I[1]) * int(I[2])
print(S)