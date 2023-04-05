N = input().strip()
for i in range(len(N)):
    C = int(N[len(N) - i - 1])
    print(N[i] * C if C != 0 else '-')