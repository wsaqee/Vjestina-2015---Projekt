PROJEKT
PrintStats

Rije� je o programu koji dr�i statisti�ke podatke o pojedinom pisa�u. Prati podatke kao �to su broj ispisanih stranica u nekom vremenskom razdoblju (ili za vrijeme trajanje jednog tonera/tinte), koji korisnik i u koje vrijeme ispisuje koliko stranica i sli�no.

Ideju za projekt sam dobio kad sam prije nekoliko mjeseci iz �iste radoznalosti htio saznati koliki je stvarni broj stranica koje mogu isprintati s jednim novim tonerom i ima li razlike me�u zamjenskim tonerima razli�itih proizvo�a�a. Budu�i da moj ku�ni printer nema nikakvu programsku podr�ku u tom smislu, prvo sam poku�ao voditi pisanu evidenciju, ali ostali �lanovi obitelji nisu uspje�no sudjelovali u tome. Zato sam potra�io softversko rje�enje na Internetu, me�utim nisam na�ao nijedan freeware program koji bi mi omogu�io uvid u upotrebljivu statistiku o kori�tenju printera.
Program bi osim jednostavne ku�ne upotrebe sigurno mogao poslu�iti i pove�anju ekonomi�nosti manjih poduze�a.
Glavne karakteristike programa bi bile:
�	Dr�anje evidencije o svim ispisanim stranicama na pojedinom pisa�u, odnosno printing taskova zadanih s ra�unala na koje je spojen pisa�
�	Razlikovanje ispisa u boji ili crno bijelo
�	Kvaliteta ispisa (Automatic, High, Normal, Draft)
�	Prosje�na brzina ispisa pojedinog pisa�a
�	Informacije o preostaloj tinti u pisa�u
�	Prikaz potro�nje po korisniku (Windows useru) i po pisa�u
�	Statistika kori�tenja printera u proizvoljnom vremenskom intervalu
�	Export statistike u .xls
�	Prikaz tro�kova printanja po stranici u odre�enom vremenskom intervalu s obzirom na unesene cijene papira i tonera te datume izmjene tonera

Program bi se bazirao oko PrintQueue klase i podataka koji se mogu prikupiti iz print queue-a te pojedinog print job-a. Obzirom da ne postoji event na koji bi se mogli zapisati svi podaci, koristio bi se timer sa kojim bi uzorkovali print queue. Po�to je ispis stranica relativno spor, timer bi mogao uzorkovati print queue svaku sekundu. Svi podaci bi se spremali u neku .bin ili .log datoteku i tako se napravila baza podataka. Na temelju spremljenih podataka, u programu bi se moglo filtrirati sve ispise po odre�enim parametnima podataka ili napraviti grafi�ki prikaz podataka. Filtrirani podaci bi se tako�er mogli prebaciti u Excel format.



