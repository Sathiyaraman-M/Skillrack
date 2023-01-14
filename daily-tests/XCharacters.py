S = input().strip()
X = int(input())
I = 0
while I < len(S):
    print(S[I: I + X])
    I += X