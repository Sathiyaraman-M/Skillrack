N = int(input())
hyphens = 1
value = N
for i in range(N):
    print(value * str(value), hyphens * '-', value * str(value), sep = "")
    value -= 1
    hyphens += 2