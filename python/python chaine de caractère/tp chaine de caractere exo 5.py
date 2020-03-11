b =str(input("entrez une phrase :"))
b = list(b)
minuscule = ["a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"]
majuscule = ["A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"]
for i in range(0,len(b)):
    if b[i] ==' ':
        b[i] = ''
    else:
        for j in range (0,len(majuscule)):
            if  b[i] == majuscule[j]:
                b[i] = minuscule[j]
b = "".join(b)

