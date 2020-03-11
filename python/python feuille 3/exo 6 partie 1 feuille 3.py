n = int(input("saisir un nombre"))
M = int(input("saisir un nombre"))
s = 0
i = 1
while (s <= M):
    s = s + (1/i)
    i = i + 1

print ( "la sommes de l'inverse est supérieur à M au bout de la valeur",i)
