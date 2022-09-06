N = input().strip()
L = ['zero', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine']
i = 0
while i < len(N):
    print(L[int(N[i])], end = " ")
    i += 1