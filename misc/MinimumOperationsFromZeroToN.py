n = int(input())
if n == 1 or n == 2:
    print(n)
    exit()
c = 2
while n!=2:
    if n%2 != 0:
        n-=1
    else:
        n/=2
    c+=1
print(c)