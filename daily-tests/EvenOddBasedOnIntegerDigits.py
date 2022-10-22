N = input().strip()
odd, even= 0, 0
for i in N:
    if int(i) % 2 == 0:
        even += 1
    else:
        odd += 1
if even > odd:
    print('even')
elif even < odd:
    print('odd')
else:
    print('-1')