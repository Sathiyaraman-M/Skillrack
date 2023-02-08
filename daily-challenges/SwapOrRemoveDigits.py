N = input().strip()
if int(N) % 2 != 0:
    print(N[:-2], N[-1], N[-2], sep = '')
else:
    print(N[:-2])