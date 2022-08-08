letters = list("abcdefghijklmnopqrstuvwxyz")
S = input()
ans = []

for i in letters :
    if i in list(S) :
        ans.append(list(S).index(i))
    else :
        ans.append(-1)

for j in ans :
    print(j, end=" ")