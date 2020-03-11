jour = int(input ("Quel jour sommes nous  ?"))
mois = int(input ("Quel mois sommes nous ?"))
annee = int(input ("Quelle annee sommes nous ?"))


# On vérifie que le jour et le mois existe 
if mois < 1 or mois > 12 :
    print (" Ce mois n'existe pas ")
else :
    print("ce mois existe je peux continuer")
if jour < 1 or jour > 31 :
    print (" Un jour est compris entre 1 et 31 ")
else :
    print("ce jour existe je peux continuer")


# On fais le changement de jour en fonction du dernier jour du mois
if mois = 12 and jour = 31:
    annee = annee + 1
     mois = 1
     jour = 1

if mois = 1 and jour = 31 :
    mois = mois + 1
    jour = 1
if mois = 3 and jour = 31 :
    mois = mois + 1
    jour = 1
if mois = 4 and jour = 30 :
    mois = mois + 1
    jour = 1
if mois = 5 and jour = 31 :
    mois = mois + 1
    jour = 1
if mois = 6 and jour = 30 :
    mois = mois + 1
    jour = 1
if mois = 7 and jour = 31 :
    mois = mois + 1
    jour = 1
if mois = 8 and jour = 30 :
    mois = mois + 1
    jour = 1
if mois = 9 and jour = 31 :
    mois = mois + 1
    jour = 1
if mois = 10 and jour = 30 :
    mois = mois + 1
    jour = 1
if mois = 11 and jour = 31 :
    mois = mois + 1
    jour = 1


if mois = 2 and jour = 28 :
    mois = mois + 1
    jour = 1

#On regarde si l'année est bissextile ou non
def bissextile (annee) :
    test = annee // 
