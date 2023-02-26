S = input().strip()
for i in range(0, len(S), 5):
    if i % 10 == 0:
        if S[i: i + 5].isalpha() == False:
            print("NO")
            exit()
    else:
        if S[i: i + 5].isdigit() == False:
            print("NO")
            exit()
print("YES")