def printUpper(N):
    for i in range(N // 2):
        print('-' * ((N // 2) - i - 1), '*', '-' * (i * 2), '*', sep = "")
    
def printLower(N):
    for i in range((N // 2) - 2, 0, -1):
        print('-' * ((N // 2) - i - 1), '*', '-' * (i * 2), '*', sep = "")
    
N = int(input())

for i in range(N // 2):
    printUpper(N)
    printLower(N)
print('-' * ((N // 2) - 1), '**', sep = "")