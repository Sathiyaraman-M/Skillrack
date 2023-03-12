def checkHor(m1, m2, n):
    for i in range(n):
        for j in range(n):
            if m1[i][j] != m2[i][n - j - 1]:
                return False
    return True

def checkVert(m1, m2, n):
    for i in range(n):
        for j in range(n):
            if m1[i][j] != m2[n - i - 1][j]:
                return False
    return True
    
N = int(input())
M1 = [list(map(int, input().split())) for _ in range(N)]
M2 = [list(map(int, input().split())) for _ in range(N)]
print("YES" if checkHor(M1, M2, N) or checkVert(M1, M2, N) else "NO")