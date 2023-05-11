def check(val):
    for i in str(val):
        if i in "24680":
            return False
    return True
N = int(input())
R = []
for i in range(1, N + 1):
    if check(i):
        R.append(i)
print(*R)