N, K = map(int, input().split())
L = list(map(int, input().split()))
R = []
if K == 1:
    print(1)
    exit()
for i in L:
    C = i
    if C % K == 0:
        while C % K == 0 and C > 1:
            C //= K
        if C == 1:
            R.append(i)
print(max(R) if len(R) != 0 else -1)