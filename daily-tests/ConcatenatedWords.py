S = input().strip().split()
L = ["" for i in range(26)]
for i in S:
    L[ord(i[0].lower()) - ord('a')] += i

for i in L:
    if i != "":
        print(i)
