n = int(input("saisir un nombre"))
m = int(input("saisir un nombre"))
while n % m != 0:
    n, m = m, n%m
print(m)
