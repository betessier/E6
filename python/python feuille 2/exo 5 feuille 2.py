heureDebut = int(input ("Quelle est l'heure de début ?"))
minuteDebut = int(input ("Quelles sont les minutes de début ?"))
heureFin = int(input ("quelle est l'heure de fin ? "))
minuteFin = int(input ("Quelles sont les minutes de fin ?"))
dureeHeure = 0
dureeMinute = 0
if heureDebut > heureFin :
    print (" ERREUR")
else :
    dureeHeure = heureFin - heureDebut
    dureeMinute = minuteFin - minuteDebut

if dureeMinute < 0 :
    dureeHeure = dureeHeure - 1
    dureeMinute = 60 + dureeMinute
    print ("La duree est de ", dureeHeure," h" , dureeMinute ," entre le debut et la fin")
