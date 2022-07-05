import sys

input = sys.stdin.readline
N = int(input())

num = N
result = 0

while True:
    firstN = num // 10 if num >= 10 else 0
    secondN = num % 10

    num = secondN * 10 + (firstN + secondN) % 10
    result += 1

    if num == N:
        break

print(result)