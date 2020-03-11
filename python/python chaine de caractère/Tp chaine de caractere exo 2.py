b =str(input("entrez une phrase :"))
c =str(input("entrez une lettre :"))
p=0
for i in range (0,len(b),1):
    if b[i] == c:
        p=p+1
print(p)
