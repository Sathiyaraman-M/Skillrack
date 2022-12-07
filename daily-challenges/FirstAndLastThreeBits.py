N = int(input())
B = bin(N)[2:]
print(int(B[:3], 2), int(B[-3:], 2))