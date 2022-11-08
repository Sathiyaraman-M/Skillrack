N = int(input().strip())
R = int(str(abs(N))[::-1])
print(R if N >= 0 else 0 - R)