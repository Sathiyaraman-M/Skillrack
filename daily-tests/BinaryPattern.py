N = int(input())
for i in range(N, 0, -1):
    print('1'* i if i % 2 != 0 else '0' * i)