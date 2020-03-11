a = input ("saisit un nombre")
b = input ("saisit un deuxieme nombre")
c = input ("saisit un dernier nombre")

if a == b :
    print (a,"est un doublon de ",b )

if a ==c :
    print (a,"est un doublon de ",c )

if b == c :
    print (b,"est un doublon de ",c )

if a > b and a > c:
    print ( a,"est la plus petite valeur")

if b > a and b > c:
    print ( a,"est la plus petite valeur")

if c > a and c > b:
    print ( a,"est la plus petite valeur")
