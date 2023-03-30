S = input().strip()
M, N = 0, 0
for i in S:
    c = ord(i)
    if c >= ord('a') and c <= ord('m'):
        M += 1
    elif c >= ord('n') and c <= ord('z'):
        N += 1
    else:
        pass
print("-1" if M == N else ("FIRSTHALF" if M > N else "SECONDHALF"))