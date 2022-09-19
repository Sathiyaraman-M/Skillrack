def check(i, j, k):
    return int(start + end[i] + end[j] + end[k]) % 8 == 0
S = input().strip()
start, end = S[:len(S) - 3], S[len(S) - 3:]
print("Yes" if check (0, 1, 2) or check(0, 2, 1) or check(1, 0, 2) or check(1, 2, 0) or check(2, 0, 1) or check(2, 1, 0) else "No")