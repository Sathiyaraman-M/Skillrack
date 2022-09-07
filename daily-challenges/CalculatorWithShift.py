Exp = input().strip()
shift = int(input())
NewExp = ""
for i in Exp:
    if i.isnumeric() or shift == 0:
        NewExp += i
    else:
        if i == '+':
            NewExp += '-'
        elif i == '-':
            NewExp += '+'
        elif i == '/':
            NewExp += '*'
        else:
            NewExp += '//'
print(eval(NewExp))