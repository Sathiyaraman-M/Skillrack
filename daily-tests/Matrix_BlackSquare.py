N = None
for i in range(R):
    for j in range(C):
        if M[i][j] == 'B':
            for k in range(1, min(R-i, C-j)+1, 2):
                if all(M[i+x][j:j+k] == ['B']*k for x in range(k)):
                    N = k
                    break
            if N is not None:
                center_row = i + N//2
                center_col = j + N//2
                print(center_row, center_col)
                exit()
