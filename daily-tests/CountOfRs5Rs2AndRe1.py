N = int(input())
Five = N // 5
Two = (N % 5) // 2
One = (N % 5) % 2
if Five > 0:
    print("Count of Rs 5:", Five, sep = '')
if Two > 0:
    print("Count of Rs 2:", Two, sep = '')
if One > 0:
    print("Count of Rs 1:", One, sep = '')