def remWhiteSpace(string):
    result = ""
    for i in string:
        if i != ' ':
            result += i
    return result

S = input().strip()
R, C = map(int, input().split())
Count = 0
for i in range(R):
    Row = remWhiteSpace(input().strip())
    Count += Row.count(S)
    if S != S[::-1]:
        Count += Row.count(S[::-1])
print(Count)