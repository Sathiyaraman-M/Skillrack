N = input().strip()
N = N.replace(N[-1], '')
print(-1 if N == '' else int(N))