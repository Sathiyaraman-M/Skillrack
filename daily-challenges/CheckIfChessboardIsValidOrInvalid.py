def isValid(Board, x, y):
    if Board[x][y] == 'W':
        return True if Board[x][y + 1] == 'B' and Board[x + 1][y] == 'B' else False
    else:
        return True if Board[x][y + 1] == 'W' and Board[x + 1][y] == 'W' else False

def checkValidBoard(Board, N):
    for i in range(N - 1):
        for j in range(N - 1):
            if not isValid(Board, i, j):
                return False
    return Board[N - 1][N - 2] != Board[N - 1][N - 1]

N = int(input())
Board = [input().strip() for i in range(N)]
print("Valid" if checkValidBoard(Board, N) else "Invalid")