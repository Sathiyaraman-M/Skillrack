S = input().strip()
L = len(S)
if L % 4 != 0:
    print('no')
    exit()
Sub = S[:(L // 4)]
if Sub * 4 != S:
    print('no')
    exit()
print('yes')