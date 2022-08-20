def rotate(l, n):
    for i in range(n):
        l = l[1:] + [l[0]]
    return l

M = int(input())
L = list(map(int, input().split()))
N, K = map(int, input().split())
index = 0
while index < M:
    if M - index < N:
        last = L[index:]
        print(*rotate(last, K), end = " ")
        break
    else:
        print(*rotate(L[index: index + N], K), end = " ")
    index += N