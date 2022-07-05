#This code uses brute-force approach. For more faster approach, look OptimizedSlidingWindowConsonants.cs
K = int(input())
S = input().strip()
for i in range(len(S) - K + 1):
    count = 0
    for j in S[i: i + K]:
        if j not in "aeiouAEIOU":
            count += 1
    print(count, end = " ")