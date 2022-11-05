N = int(input())
L = list(map(int, input().strip().split()))
D = []
for i in set(L):
    if L.count(i) > 1:
        D.append(i)
print(sum(D) if len(D) != 0 else -1)