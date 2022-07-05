import sys
import heapq as hpq

N = int(input())

pq = []
for _ in range(N):
    x = int(sys.stdin.readline())
    if x == 0:
        if pq:
            print(hpq.heappop(pq)[1])
        else:
            print(0)
    else:
        hpq.heappush(pq, (abs(x), x))