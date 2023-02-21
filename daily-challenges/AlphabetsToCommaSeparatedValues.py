N = int(input())
S = input().strip()
for i in S:
    print(i if i in "01234567890" else ',', end = '')