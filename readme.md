-Relese.rar je zipana verzija foldera Relese


PROJEKT
PrintStats

Riječ je o programu koji drži statističke podatke o pojedinom pisaču. Prati podatke kao što su broj ispisanih stranica u nekom vremenskom razdoblju (ili za vrijeme trajanje jednog tonera/tinte), koji korisnik i u koje vrijeme ispisuje koliko stranica i slično.

Ideju za projekt sam dobio kad sam prije nekoliko mjeseci iz čiste radoznalosti htio saznati koliki je stvarni broj stranica koje mogu isprintati s jednim novim tonerom i ima li razlike među zamjenskim tonerima različitih proizvođača. Budući da moj kućni printer nema nikakvu programsku podršku u tom smislu, prvo sam pokušao voditi pisanu evidenciju, ali ostali članovi obitelji nisu uspješno sudjelovali u tome. Zato sam potražio softversko rješenje na Internetu, međutim nisam našao nijedan freeware program koji bi mi omogućio uvid u upotrebljivu statistiku o korištenju printera.
Program bi osim jednostavne kućne upotrebe sigurno mogao poslužiti i povećanju ekonomičnosti manjih poduzeća.
Glavne karakteristike programa bi bile:
•	Držanje evidencije o svim ispisanim stranicama na pojedinom pisaču, odnosno printing taskova zadanih s računala na koje je spojen pisač
•	Razlikovanje ispisa u boji ili crno bijelo
•	Kvaliteta ispisa (Automatic, High, Normal, Draft)
•	Prosječna brzina ispisa pojedinog pisača
•	Informacije o preostaloj tinti u pisaču
•	Prikaz potrošnje po korisniku (Windows useru) i po pisaču
•	Statistika korištenja printera u proizvoljnom vremenskom intervalu
•	Export statistike u .xls
•	Prikaz troškova printanja po stranici u određenom vremenskom intervalu s obzirom na unesene cijene papira i tonera te datume izmjene tonera

Program bi se bazirao oko PrintQueue klase i podataka koji se mogu prikupiti iz print queue-a te pojedinog print job-a. Obzirom da ne postoji event na koji bi se mogli zapisati svi podaci, koristio bi se timer sa kojim bi uzorkovali print queue. Pošto je ispis stranica relativno spor, timer bi mogao uzorkovati print queue svaku sekundu. Svi podaci bi se spremali u neku .bin ili .log datoteku i tako se napravila baza podataka. Na temelju spremljenih podataka, u programu bi se moglo filtrirati sve ispise po određenim parametnima podataka ili napraviti grafički prikaz podataka. Filtrirani podaci bi se također mogli prebaciti u Excel format.



