N = int(input())
S = "".join([i for i in input().strip() if i not in "1234567890"])
for i in range(N - 1):
    I = "".join([i for i in input().strip() if i not in "1234567890"])
    if len(I) > len(S):
        S = I
print(S if len(S) != 0 else "-1")