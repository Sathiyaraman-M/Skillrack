N = str(oct(int(input().strip())))[2:]
print("YES" if N[::-1] == N else "NO")