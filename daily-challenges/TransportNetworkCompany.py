Brand, N = map(str, input().split())
Brand, N = Brand.strip(), N.strip()
if Brand == 'O':
    if N == '1':
        print('Ola Auto')
    elif N == '2':
        print('Ola Mini')
    elif N == '3':
        print('Ola Micro')
    elif N == '4':
        print('Ola Prime')
    else:
        print('Invalid')
elif Brand == 'U':
    if N == '1':
        print('Uber Auto')
    elif N == '2':
        print('Uber Cab')
    else:
        print('Invalid')
else:
    print('Invalid')