liste = [0,5,9,1,65,4,78,45,56]
def swap(liste,i,j):
    svg = liste[i]
    liste[i]=liste[j]
    liste[j]=svg

for j in range (0,len(liste)):
    ind = j
    for i in range (j+1, len(liste)):
        if liste[ind] > liste[i]:
             ind = i
    swap(liste,ind,j)
print(liste)
