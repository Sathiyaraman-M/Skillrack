S = input().strip()
I = 0
for i in range(len(S)):
    if i == len(S) // 2:
        print(S[i])
        I -= 1
        continue
    print(S[I], '*' * (abs(len(S) - 2 * i - 1) // 2 - 1), S[len(S) - I - 1], sep = '')
    if i < len(S) // 2:
        I += 1
    else:
        I -= 1