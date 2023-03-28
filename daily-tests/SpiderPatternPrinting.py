N = int(input())
print('|' * (N - 1) + '* ' * N) # First Line
for i in range(N - 1, 1, -1): # Upper Half
    print('|' * (i - 1) + '*', end = ' ')
    print('-' * (2 * (N - i - 1) - 1) + ' *' if N - i != 1 else '*', end = ' ') 
    print('-' * (2 * (i - 2) - 1) + ' *' if 2 * (i - 2) >= 1 else '*', end = ' ')
    print('-' * (2 * (N - i - 1) - 1) + ' *' if N - i != 1 else '*')
print('* ' * (2 * N - 1)) # Mid Line
for i in range(2, N): #Lower Half
    print('|' * (i - 1) + '*', end = ' ')
    print('-' * (2 * (N - i - 1) - 1) + ' *' if N - i != 1 else '*', end = ' ')
    print('-' * (2 * (i - 2) - 1) + ' *' if 2 * (i - 2) >= 1 else '*', end = ' ')
    print('-' * (2 * (N - i - 1) - 1) + ' *' if N - i != 1 else '*')
print('|' * (N - 1) + '* ' * N) # Last Line