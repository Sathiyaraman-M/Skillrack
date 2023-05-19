N = list(map(int, list(input().strip())))
for i in range(len(N)):
    N[i] += -1 if N[i] % 2 != 0 else 1
print(int("".join(list(map(str, N)))))