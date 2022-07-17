L = []
maxLen = 0
while True:
    try:
        text = input().rstrip()
        if maxLen < len(text):
            maxLen = len(text)
        L.append(text)
    except:
        break
if len(L) != 0:
    print((2 + maxLen) * '*')
    for i in L:
        out = '*'
        if len(i) != 0:
            hyphenCount = maxLen - len(i)
            if hyphenCount % 2 != 0:
                out += '-'
            out += (hyphenCount // 2) * '-'
            out += i
            out += (hyphenCount // 2) * '-'
        else:
            out += maxLen * '-'
        out += '*'
        print(out)
    print((2 + maxLen) * '*')
