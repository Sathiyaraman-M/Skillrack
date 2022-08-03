N = int(input())
print("*" * (2 * N + 1))
print("", *list(range(1, N + 1)), "", sep = "*")
print("*" * (2 * N + 1))