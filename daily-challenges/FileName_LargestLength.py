N = int(input())
F = [input().strip() for _ in range(N)]
E = input().strip()
L = []
for i in F:
    if i[-len(E):] == E:
        L.append(i)
if len(L) > 0:
    print(max(L))
else:
    print("FILE NOT FOUND")