S = input().strip()
O, N = map(str, input().split())
for i in S:
    print(N if i == O else i, end = '')