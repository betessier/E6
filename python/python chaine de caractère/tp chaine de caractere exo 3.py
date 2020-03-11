b =str(input("entrez une phrase :"))
p=0
l=['A','a','E','e','I','i','O','o','U','u','Y','y']
for i in range (0,len(b),1):
    for j in range (0,len(l),1):   
        if b[i] == l[j]:
            p=p+1
print(p)

