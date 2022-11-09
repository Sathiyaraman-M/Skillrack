def Convert(word):
    newWord = word[0].upper()
    for i in range(1, len(word) - 1):
        newWord += word[i]
    if len(word) > 1:
        newWord += word[-1].upper()
    return newWord
        
print(*list(map(Convert, input().strip().split())))