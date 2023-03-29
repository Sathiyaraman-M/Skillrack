R, C = map(int, input().split())
M = [list(map(int, input().split())) for _ in range(R)]
for i in range(R // 2):
    if M[i] != M[R - i - 1]:
        print("NO")
        exit()
print("YES")