-- Create Database GestioneScuola


create table Classe (
IdClasse int Identity(800,1),
Codice char not null,
Livello int not null,
constraint PK_Classe primary key(IdClasse),
constraint U_K unique (Codice,Livello)
);

create table Studente (
IdStudente int Identity(1,1),
Nome nvarchar(30) not null,
Cognome nvarchar(30) not null,
DataNascita datetime not null,
IdClasse int not null,
constraint FK_StudenteClasse Foreign key (IdClasse) references Classe(IdClasse),
constraint PK_Studente primary key(IdStudente),

);

create table Insegnante (
IdInsegnante int Identity(700,1),
Nome nvarchar(30) not null,
Cognome nvarchar(30) not null,
DataNascita datetime not null,
constraint PK_Insegnante primary key(IdInsegnante)
);



Create Table Materia(

Materia nvarchar(30) not null,
IdClasse int not null, 
IdInsegnante int not null, 
constraint P_K primary key (Materia),
constraint FK_MateriaClasse Foreign key (IdClasse) references Classe(IdClasse),
constraint FK_MateriaInsegnante Foreign key (IdInsegnante) references Insegnante(IdInsegnante)

); 

Create Table Votazione(
IdStudente int not null, 
Materia nvarchar(30) not null,
DataInterrogazione datetime not null, 
Voto int not null, 
constraint PK_Votazione primary key (IdStudente, Materia, DataInterrogazione),
);


