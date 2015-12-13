PROJEKT
PrintStats

Rijeè je o programu koji drži statistièke podatke o pojedinom pisaèu. Prati podatke kao što su broj ispisanih stranica u nekom vremenskom razdoblju (ili za vrijeme trajanje jednog tonera/tinte), koji korisnik i u koje vrijeme ispisuje koliko stranica i slièno.

Ideju za projekt sam dobio kad sam prije nekoliko mjeseci iz èiste radoznalosti htio saznati koliki je stvarni broj stranica koje mogu isprintati s jednim novim tonerom i ima li razlike meðu zamjenskim tonerima razlièitih proizvoðaèa. Buduæi da moj kuæni printer nema nikakvu programsku podršku u tom smislu, prvo sam pokušao voditi pisanu evidenciju, ali ostali èlanovi obitelji nisu uspješno sudjelovali u tome. Zato sam potražio softversko rješenje na Internetu, meðutim nisam našao nijedan freeware program koji bi mi omoguæio uvid u upotrebljivu statistiku o korištenju printera.
Program bi osim jednostavne kuæne upotrebe sigurno mogao poslužiti i poveæanju ekonomiènosti manjih poduzeæa.
Glavne karakteristike programa bi bile:
•	Držanje evidencije o svim ispisanim stranicama na pojedinom pisaèu, odnosno printing taskova zadanih s raèunala na koje je spojen pisaè
•	Razlikovanje ispisa u boji ili crno bijelo
•	Kvaliteta ispisa (Automatic, High, Normal, Draft)
•	Prosjeèna brzina ispisa pojedinog pisaèa
•	Informacije o preostaloj tinti u pisaèu
•	Prikaz potrošnje po korisniku (Windows useru) i po pisaèu
•	Statistika korištenja printera u proizvoljnom vremenskom intervalu
•	Export statistike u .xls
•	Prikaz troškova printanja po stranici u odreðenom vremenskom intervalu s obzirom na unesene cijene papira i tonera te datume izmjene tonera

Program bi se bazirao oko PrintQueue klase i podataka koji se mogu prikupiti iz print queue-a te pojedinog print job-a. Obzirom da ne postoji event na koji bi se mogli zapisati svi podaci, koristio bi se timer sa kojim bi uzorkovali print queue. Pošto je ispis stranica relativno spor, timer bi mogao uzorkovati print queue svaku sekundu. Svi podaci bi se spremali u neku .bin ili .log datoteku i tako se napravila baza podataka. Na temelju spremljenih podataka, u programu bi se moglo filtrirati sve ispise po odreðenim parametnima podataka ili napraviti grafièki prikaz podataka. Filtrirani podaci bi se takoðer mogli prebaciti u Excel format.



