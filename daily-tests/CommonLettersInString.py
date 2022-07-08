S1, S2 = map(str, input().strip().split())
common = []
for i in S1:
    if i in S2:
        common.append(i)
for i in S2:
    if i in S1:
        common.append(i)
print(*sorted(list(set(common))), sep = " ")