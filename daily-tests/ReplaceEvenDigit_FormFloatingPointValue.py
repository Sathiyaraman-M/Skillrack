S = input().strip()
N = ""
Add = False
for i in S[::-1]:
    if int(i) % 2 == 0 and not Add:
        N = "." + N
        Add = True
    else:
        N = i + N
print("{0:0.2f}".format(float(N)))