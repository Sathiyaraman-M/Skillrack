A, B = map(str, input().strip().split())
R = ''
for i in range(len(A)):
    R += str((int(A[i]) + int(B[i])) % 10)
print(int(R))