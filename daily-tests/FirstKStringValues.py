N, K = map(int, input().split())
print(*sorted([input().strip() for _ in range(N)])[::-1][:K], sep = '\n')
