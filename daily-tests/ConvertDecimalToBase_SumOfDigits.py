def conv(V, B):
    S = 0
    while V > 0:
        S += V % B
        V //= B
    return S
N1, B1 = map(int, input().split())
N2, B2 = map(int, input().split())
print(conv(N1, B1) + conv(N2, B2))