def getNumer(s):
    return int(s.split('/')[0])
def getDenom(s):
    return int(s.split('/')[1])
N = int(input())
I = input().strip().split()
print(min(list(map(getNumer, I))), max(list(map(getDenom, I))))