N = int(input())
for i in range(1, N + 1):
  if i == (N // 2) + 1:
    print(*list(range(1, N + 1)), sep = "")
  elif i <= N //2:
    print('-' * (i - 1), '*', '-' * ((N // 2) - i), i, '-' * ((N // 2) - i), '*', '-' * (i - 1), sep = "")
  else:
    print('-' * (N - i), '*', '-' * ((N // 2) - (N - i) - 1), i, '-' * ((N // 2) - (N - i) - 1), '*', '-' * (N - i), sep = "")
