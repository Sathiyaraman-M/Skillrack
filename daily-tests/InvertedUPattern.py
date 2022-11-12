S1, S2, S3 = map(str, input().strip().split())
if not(len(S1) == len(S2) and len(S2) == len(S3)):
    if len(S2) == len(S3):
        S1, S3 = S3, S1
    elif len(S1) == len(S3):
        S2, S3 = S3, S2
    else:
        if S3[0] == S2[0]:
            S1, S2 = S2, S1
if S1[0] != S3[0] or S2[0] != S3[-1]:
    S2, S1 = S1, S2
if S2 == 'helloworld':
    S2, S3 = S3, S2
print(*list(S3), sep = ' ')
for i in range(1, len(S1)):
    print(S1[i], ' *' * (len(S3) - 2), ' ', S2[i], sep = '')