N, K = map(int, input().split())
L = list(map(int, input().split()))
R = [i for i in L if i % 10 == K]
print("yes" if R == sorted(R) else "no")