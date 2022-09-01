s1 = input().strip()
s2 = input().strip()
for i in set(s1):
    if s2.count(i) != s1.count(i):
        print("NO")
        exit()
print("YES")