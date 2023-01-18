def func(s):
    t = ''
    for i in s:
        if i not in '2357':
            t += i
    return int(t) if t != '' else 0
        
print(sum(map(func, input().strip().split())))