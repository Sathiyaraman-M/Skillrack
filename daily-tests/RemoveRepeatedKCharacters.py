S, K = input().strip().split()
K = int(K)
I = 0
R = ""
while I < len(S):
    C = 1
    Temp = S[I]
    I += 1
    while I < len(S) and S[I] == Temp:
        I += 1
        C += 1
    R += Temp * (C % K)
print(R)