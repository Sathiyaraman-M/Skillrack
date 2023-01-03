C = input().strip()
while C != 'z':
    print(C, end = '')
    C = chr(ord(C) + 1)
    if C in "aeiou" or C == 'z':
        print(C)
        break