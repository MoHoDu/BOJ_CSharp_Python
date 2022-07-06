N, L = map(int,input().split())

coord = list(map(int, input().split()))

point = 0
count = 0
while point < max(coord) + 1:
    if point in coord:
        count += 1
        point += L
    else:
        point += 1

print(count)