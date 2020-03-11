n = int(input("saisir un nombre"))
s = float(0)
i = float(1)
while (i < n+1):
    if i % 2 == 0: 
        s = s + (1/i)
        i = i + 1
    else: 
        s = s - (1/i)
        i = i + 1
print ( "la sommes de l'inverse est ",s)
