import sys
from itertools import combinations

input = sys.stdin.readline

values = []
for _ in range(9):
    values.append(int(input()))

for i in combinations(values, 7):
    if sum(i) == 100:
        for j in sorted(i):
            print(j)

        break
