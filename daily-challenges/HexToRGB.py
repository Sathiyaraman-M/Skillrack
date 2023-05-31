def getDigit(dig, mul):
    if dig.isnumeric():
        return int(dig) * pow(16, mul)
    return (ord(dig) - ord('A') + 10) * pow(16, mul)
S = input().strip()
R = getDigit(S[1], 1) + getDigit(S[2], 0)
G = getDigit(S[3], 1) + getDigit(S[4], 0)
B = getDigit(S[5], 1) + getDigit(S[6], 0)
print('(', R, ',', G, ',', B, ')', sep = '')