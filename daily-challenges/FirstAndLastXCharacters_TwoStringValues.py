S1 = input().strip()
S2 = input().strip()
X = int(input())
print(S1[:X] + S2[len(S2) - X:])