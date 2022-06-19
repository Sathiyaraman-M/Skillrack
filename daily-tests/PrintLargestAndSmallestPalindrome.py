palindromes = list(filter(lambda ele : ele == ele[::-1],input().split()))
if palindromes:
    print(max(palindromes,key = len),min(palindromes,key=len),sep="\n")
else:
    print(-1)
