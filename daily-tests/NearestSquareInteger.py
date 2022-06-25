from math import sqrt, floor
def Perfect(n):
    if sqrt(n) - floor(sqrt(n)) != 0:
        return False
    return True
N = int(input())
L,M = N, N
while not Perfect(L):
    L -= 1
while not Perfect(M):
    M += 1
print(L if abs(L - N) < abs(M - N) else M)
