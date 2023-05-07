def rmSpecial(s):
    R = ''
    for i in s:
        if i.isalpha():
            R += i
        else:
            R += ' '
    return R.strip().lower()
L= "".join(list(map(rmSpecial, input().strip().split()))).split()
print(len([i for i in L if i[-1] == 'a' or i[-1] == 'b']))