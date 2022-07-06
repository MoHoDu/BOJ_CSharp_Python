import sys

input = sys.stdin.readline

for i in range(int(input())):
    A, B = map(int,input().split(","))
    print(A+B)