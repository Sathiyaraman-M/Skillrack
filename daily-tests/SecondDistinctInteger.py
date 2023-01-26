N = int(input())
L = list(map(int, input().split()))
A = []
for i in L:
    if i not in A:
        A.append(i)
print(A[1])