N = int(input()) 
L = input().split()
for i in L:
    if int(i[0]) % 2 and int(i[len(i) - 1]) % 2:
      print(i, end = " ")
