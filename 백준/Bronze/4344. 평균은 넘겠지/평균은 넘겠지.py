c = int(input())

for i in range(0, c):
    n = list(map(int, input().split()))
    num = n[0]
    average = sum(n[1:]) / num
    result = 0
    for j in n[1:]:
        if j > average:
            result += 1
    result = (result / num) * 100

    print("{:.3f}%".format(result))
