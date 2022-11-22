M, N = map(int, input().strip().split())
S1 = sum([int(i) for i in set(str(M))])
S2 = sum([int(i) for i in set(str(N))])
print("YES" if S1 == S2 else "NO")