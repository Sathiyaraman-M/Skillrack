L = list(map(str, input().strip().split()))
Dict = dict()
for i in L:
    S = "".join(sorted(list(set([k for k in i]))))
    if S not in Dict:
        Dict[S] = [i]
    else:
        Dict[S].append(i)
R = []
for i in L:
    S = "".join(sorted(list(set([k for k in i]))))
    M = Dict[S][0]
    for j in Dict[S][1:]:
        if len(j) < len(M):
            M = j
    R.append(M)
print(" ".join(R))