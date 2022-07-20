N = int(input())
B = list[bin(N)[2:]]

for i in range(len(B) - 2, -1, -2):
    B[i] = '1'

print(int("".join(B), 2))