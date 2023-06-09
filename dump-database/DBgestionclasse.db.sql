BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS "Professeurs" (
	"P_ID"	INTEGER NOT NULL,
	"P_Nom"	TEXT NOT NULL,
	"P_Prenom"	TEXT NOT NULL,
	"P_Sexe"	TEXT NOT NULL,
	PRIMARY KEY("P_ID" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Eleves" (
	"E_ID"	INTEGER NOT NULL,
	"E_Nom"	TEXT NOT NULL,
	"E_Prenom"	TEXT NOT NULL,
	"E_Sexe"	TEXT NOT NULL,
	"E_FK_C_ID"	INTEGER,
	PRIMARY KEY("E_ID" AUTOINCREMENT),
	FOREIGN KEY("E_FK_C_ID") REFERENCES "Classes"("C_ID")
);
CREATE TABLE IF NOT EXISTS "Matieres" (
	"M_Id"	INTEGER NOT NULL,
	"M_Nom"	TEXT NOT NULL,
	"M_FK_P_ID"	INTEGER NOT NULL,
	PRIMARY KEY("M_Id" AUTOINCREMENT),
	FOREIGN KEY("M_FK_P_ID") REFERENCES "Professeurs"("P_ID")
);
CREATE TABLE IF NOT EXISTS "Notes" (
	"N_ID"	INTEGER NOT NULL,
	"N_Valeur"	INTEGER NOT NULL,
	"N_FK_E_ID"	INTEGER NOT NULL,
	"N_FK_M_ID"	INTEGER NOT NULL,
	PRIMARY KEY("N_ID" AUTOINCREMENT),
	FOREIGN KEY("N_FK_M_ID") REFERENCES "Matieres"("M_Id"),
	FOREIGN KEY("N_FK_E_ID") REFERENCES "Eleves"("E_ID")
);
CREATE TABLE IF NOT EXISTS "Classes" (
	"C_ID"	INTEGER NOT NULL,
	"C_Label"	TEXT NOT NULL,
	"C_FK_P_ID"	INTEGER NOT NULL,
	PRIMARY KEY("C_ID" AUTOINCREMENT),
	FOREIGN KEY("C_FK_P_ID") REFERENCES "Professeurs"("P_ID")
);
INSERT INTO "Professeurs" ("P_ID","P_Nom","P_Prenom","P_Sexe") VALUES (1,'Marc','Jean','H'),
 (2,'Clapier','Evelyne','F');
INSERT INTO "Eleves" ("E_ID","E_Nom","E_Prenom","E_Sexe","E_FK_C_ID") VALUES (1,'Clapier','Titouan','H',2),
 (2,'Lechat','Arnaud','H',2),
 (3,'Clapier','Romeo','H',1),
 (4,'Dejong','Marine','F',1);
INSERT INTO "Matieres" ("M_Id","M_Nom","M_FK_P_ID") VALUES (1,'Mathematique',1),
 (2,'Histoire',2);
INSERT INTO "Notes" ("N_ID","N_Valeur","N_FK_E_ID","N_FK_M_ID") VALUES (1,18,1,1),
 (2,12,2,2),
 (3,13,1,2),
 (4,15,2,1),
 (5,20,3,2),
 (6,1,3,1),
 (8,2,3,1),
 (9,13,4,1),
 (10,13,4,2),
 (11,3,4,2),
 (12,3,1,1);
INSERT INTO "Classes" ("C_ID","C_Label","C_FK_P_ID") VALUES (1,'SIO1',1),
 (2,'SIO2',2);
COMMIT;
