N = int(input())
T = list(map(str, input().strip().split()))
H, M = 0, 0
for i in T:
    t = i.split(':')
    H += int(t[0])
    M += int(t[1])
H += M // 60
M = M % 60
print(H, M)