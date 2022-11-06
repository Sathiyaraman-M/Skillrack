def prime(n):
    if n == 1:
        return False
    for i in range(2, (n // 2) + 1):
        if n % i == 0:
            return False
    return True
S = input().strip()
for i in set(S):
    if not prime(S.count(i)):
        print("NO")
        exit()
print("YES")