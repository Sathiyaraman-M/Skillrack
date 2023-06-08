N = int(input())
for i in range(N):
    L = [0] * (N - i - 1) + list(range(1, i + 2)[::-1])
    print(" ".join(list(map(str, L))))