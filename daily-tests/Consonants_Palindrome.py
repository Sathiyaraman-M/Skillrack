S = [i for i in input().strip() if i not in "aeiou"]
print("-1" if S == [] else ("YES" if S == S[::-1] else "NO"))