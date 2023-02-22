N = int(input())
W = []
D = []
for i in range(N):
    I = input().split()
    W.append(I[0])
    D.append(int(I[1]))
for i in W:
    print(i, D.index(len(i)) + 1)