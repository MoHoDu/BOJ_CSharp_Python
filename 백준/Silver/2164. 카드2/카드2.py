from collections import deque

N = int(input())

dq = deque()
for n in range(N):
    dq.append(n + 1)

while len(dq) > 1:
    dq.popleft()
    v = dq[0]
    dq.popleft()
    dq.append(v)

print(dq[0])