S1, S2 = input().strip(), input().strip()
print(len([i for i in range(len(S1)) if S1[i] != S2[i]]))