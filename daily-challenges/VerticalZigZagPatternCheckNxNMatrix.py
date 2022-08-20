N = int(input())
M = [list(map(int, input().split())) for i in range(N)]
val = 1
success = True
for i in range(N):
    for j in range(N):
        if i % 2 == 0:
            if M[j][i] != val:
               success = False
               break
        else:
            if M[N - j - 1][i] != val:
                success = False
                break
        val += 1
print("Yes" if success else "No")
            