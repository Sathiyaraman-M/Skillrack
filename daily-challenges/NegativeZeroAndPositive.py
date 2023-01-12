N = int(input())
L = list(map(int, input().split()))
for i in L[::-1]:
    if i < 0:
        print(i, end = ' ')
print('0 ' * L.count(0), end = '')
for i in L[::-1]:
    if i > 0:
        print(i, end = ' ')