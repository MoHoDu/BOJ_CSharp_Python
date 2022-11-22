import sys
hashTable = {}
M = int(sys.stdin.readline())
m = sys.stdin.readline().split()
for i in m[:M] :
	hashTable[i] = hashTable.get(i, 1)
N = int(sys.stdin.readline())
n = sys.stdin.readline().split()
for i in n[:N] :
	print(hashTable.get(i, 0))