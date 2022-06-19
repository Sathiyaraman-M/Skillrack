N = int(input())
L = list(map(int, input().split()))
G = ['*'*i + '-'*(max(L) - i) for i in L]
for i in range(max(L) - 1, - 1, -1):
  for j in range(N):
    print(G[j][i], end = "")
  print()
