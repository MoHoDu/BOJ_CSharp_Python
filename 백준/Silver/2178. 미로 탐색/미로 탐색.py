import sys
from collections import deque
input = sys.stdin.readline

n, m = map(int, input().split())
adj = [list(map(int, ' '.join(input().split()))) for _ in range(n)]

# 상, 하, 좌, 우 순서
dx = [1, -1, 0, 0]
dy = [0, 0, 1, -1]


def is_correct_path(x, y):
    return 0 <= x < n and 0 <= y < m


dq = deque()
dq.append((0, 0))
while len(dq) > 0:
    x, y = dq.popleft()
    # print(f"x: {x + 1} y: {y + 1} count : {adj[x][y]}")
    for i in range(4):
        nx, ny = x + dx[i], y + dy[i]
        if is_correct_path(nx, ny):
            if adj[nx][ny] == 1:
                adj[nx][ny] = adj[x][y] + 1
                dq.append((nx, ny))


print(adj[n - 1][m - 1])