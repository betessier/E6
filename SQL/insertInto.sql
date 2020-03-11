delete from suit;
delete from etu;
delete from cours;
	
INSERT INTO etu (nom, adr, num) VALUES
('Dupont', 'Paris', 2140);
INSERT INTO etu (nom, adr, num) VALUES
('Durand', 'Orsay', 1128);
INSERT INTO etu (nom, adr, num) VALUES
('Dubois', 'Orsay', 3213);

INSERT INTO cours (code, nom_ens, salle) VALUES
('ALGO', 'Ullman', 345);
INSERT INTO cours (code, nom_ens, salle) VALUES
('BD', 'Korth', 231);
INSERT INTO cours (code, nom_ens, salle) VALUES
('MATHS', 'Korth', 125);


INSERT INTO suit (num, code) VALUES
(2140, 'ALGO');
INSERT INTO suit (num, code) VALUES
(3213, 'BD');
INSERT INTO suit (num, code) VALUES
(2140, 'BD');
INSERT INTO suit (num, code) VALUES
(2140, 'MATHS');



select * from etu;
select * from suit;
select * from cours;