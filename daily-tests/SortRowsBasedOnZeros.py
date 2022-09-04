R, C = map(int, input().split())
M = [list(map(int, input().split())) for i in range(R)]
countDict = dict()
counts = set()
for i in range(R):
    countDict[i + 1] = M[i].count(0)
    counts.add(countDict[i + 1])
for i in sorted(list(counts)):
    for j in countDict:
        if countDict[j] == i:
            print(j, end = ' ')