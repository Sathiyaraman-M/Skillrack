S = input().strip()
for i in range(0, len(S), 2):
  if S[i] not in "aeiouAEIOU":
    print(S[i], ord(S[i]), S[i].upper(), ord(S[i].upper()))
