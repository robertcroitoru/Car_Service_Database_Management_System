-- interogare complexa 1
-- Nr de lucrari ale fiecarui angajat

SELECT A.AngajatID, A.Nume, A.Prenume as Nume, (
 SELECT COUNT(*) FROM Lucrari L
 WHERE L.AngajatID = A.AngajatID)
 AS Numar_Lucrari
FROM Angajati A 


-- interogare complexa 2 cu parametru variabil
-- numele si prenumele angajatilor care au lucreaza la lucrarea cu starea X

	SELECT Distinct A.Nume, A.Prenume 
	from Angajati A,(
	select L.Stare, L.AngajatID 
	from Lucrari L
	where L.Stare='final')
	as St
	where A.AngajatID=St.AngajatID




-- interogare complexa 3
-- nr de masini ale fiecarui client
SELECT C.ClientID, C.Nume, C.Prenume as Nume, (
 SELECT COUNT(*) FROM Masini M
 WHERE M.ClientID = C.ClientID)
 AS Numar_Masini
FROM Clienti C


-- interogare complexa 4
-- in ce an s-au fabricat cele mai multe masini
select M.An_fabricatie, COUNT(M.MasinaID) as nr_masini
from Masini M
group by M.An_fabricatie
having COUNT( M.MasinaID)>=(
select top 1 COUNT(M1.MasinaID) 
from Masini M1
group by M1.An_fabricatie
order by COUNT(M1.MasinaID) DESC
)


-- interogare simpla 1
-- numele si prenumele clientilor care au masini de marca X
select C.Nume, C.Prenume, M.Marca
from Clienti C inner join Masini M on C.ClientID=M.ClientID
where M.Marca='Audi'
group by C.Nume, C.Prenume, M.Marca


-- interogara simpla 2
-- numele si prenumele clientilor care au lucrari nefinalizate
select C.Nume, C.Prenume, L.Stare
from Clienti C inner join Lucrari L on C.ClientID=L.ClientID
where L.Stare='nefinal'
group by C.Nume, C.Prenume, L.Stare


-- interogare complexa 3
-- numele si prenumele angajatilor care nu si-au terminat lucrarile
select A.Nume, A.Prenume, L.Stare
from Angajati A inner join Lucrari L on A.AngajatID=L.AngajatID
where L.Stare='nefinal'
group by A.Nume, A.Prenume, L.Stare


-- interogare simpla 4
-- lucrarile care sunt desfasurate doar de mecanici

select L.LucrareID, L.Nume_Lucrare, A.Functie
from Lucrari L inner join Angajati A on A.AngajatID=L.AngajatID
where A.Functie='mecanic'
group by L.LucrareID, L.Nume_lucrare, A.Functie



INSERT INTO Lucrari_Piese(LucrareID, PiesaID)
SELECT L.LucrareID, P.PiesaID
FROM Lucrari L, Piese P
WHERE L.Piese_Necesare=P.Nume_piesa

