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
verif=[0]*26
ok=1

if len(b)<26:
    print ("Ce n'est pas un pangramme.")

else:
    for i in range (0,len(b)):
        for j in range (0,len(minuscule)):
            if b[i] == minuscule[j]:
                verif[j]=1
    p=0
    while p< len(verif) and ok ==1:
        if verif[p] == 0:
            ok = 0
        p=p+1
    if ok == 0:
        print ("Ce n'est pas un pangramme")
    else :
        print ("c'est un pangramme")
