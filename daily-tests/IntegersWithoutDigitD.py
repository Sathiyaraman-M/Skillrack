N, D = map(int, input().split())
L = list(map(int, input().split()))
R = []
for i in L:
    if str(D) not in str(i):
        R.append(str(i))
print(" ".join(R) if len(R) != 0 else "-1")