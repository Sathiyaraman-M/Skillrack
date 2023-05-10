S = input().strip()
I, J = 0, len(S) - 1
S1, S2 = "", ""
while I < J:
    S1 += S[I]
    S2 = S[J] + S2
    V = len(S) // len(S1)
    if S1 == S2 and V * S1 == S:
        print("YES")
        exit()
    I += 1
    J -= 1
print("NO")