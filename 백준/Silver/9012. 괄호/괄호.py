def checkPair(text):
    stack = []
    for t in text:
        if t == '(':
            stack.append(t)
        elif len(stack) > 0:
            stack.pop()
        else:
            return False
    if len(stack) > 0:
        return False
    else:
        return True

test_case = input()

for i in range(int(test_case)):
    text = input()
    if checkPair(text):
        print("YES")
    else:
        print("NO")