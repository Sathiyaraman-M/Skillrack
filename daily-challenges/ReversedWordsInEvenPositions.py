S = input().strip().split()
print(*[S[i] if (len(S) - i) % 2 != 0 else S[i][::-1] for i in range(len(S) - 1, -1, -1)])