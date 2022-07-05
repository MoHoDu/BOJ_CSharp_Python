import sys

input = sys.stdin.readline

dic = {}
for _ in range(int(input())):
    book = input().strip()
    dic[book] = dic[book] + 1 if book in dic.keys() else 1

max_selled = max(dic.values())

best_seller = []

for book, count in dic.items():
    if count == max_selled:
        best_seller.append(book)

print(sorted(best_seller)[0])