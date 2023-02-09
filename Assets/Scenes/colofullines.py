import sys
input = sys.stdin.readline

H, W, C, Q = map(int, input().split())
t = [0] * Q
n = [0] * Q
c = [0] * Q
for i in range(Q):
  t[i], n[i], c[i] = map(int, input().split())

N = []
M = []
ans = [0] * C
for i in range(Q)[::-1]:
  if t[i] == 1 and n[i] not in N:
    ans[c[i]-1] += W - len(M)
    N.append(n[i])  
  elif t[i] == 2 and n[i] not in M:
    ans[c[i]-1] += H - len(N)
    M.append(n[i])
  elif len(N) == H and len(M) == W:
    break

print(*ans)