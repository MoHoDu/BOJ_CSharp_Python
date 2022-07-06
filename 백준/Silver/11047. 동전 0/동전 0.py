import heapq as hpq
N, K = map(int, input().split())

coins = []
for _ in range(N):
    hpq.heappush(coins, -int(input()))

count = 0
while K != 0:
    coin = -hpq.heappop(coins)
    count += K // coin
    K %= coin

print(count)