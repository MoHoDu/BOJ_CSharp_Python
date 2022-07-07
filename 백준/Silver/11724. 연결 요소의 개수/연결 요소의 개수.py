import sys
sys.setrecursionlimit(10000)

N, M = map(int, input().split())
adj = [[] for _ in range(N + 1)]
visited = [False] * (N + 1)
count = 0


def dfs(now):
    visited[now] = True
    for nxt in adj[now]:
        if not visited[nxt]:
            dfs(nxt)


for _ in range(M):
    x, y = map(int, input().split())
    adj[x].append(y)
    adj[y].append(x)


for j in range(1, N + 1):
    if not visited[j]:
        dfs(j)
        count += 1

print(count)