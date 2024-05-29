CREATE TABLE Authors (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(125) NOT NULL,
    LastName VARCHAR(45) NOT NULL,
    Email VARCHAR(125) NOT NULL UNIQUE,
    Nationality VARCHAR(125) NOT NULL,
    Status VARCHAR(50) NOT NULL
);

TRUNCATE TABLE Authors;
DROP TABLE Authors;

INSERT INTO Authors (Name, LastName, Email, Nationality, Status)
VALUES ("Juanky", "H", "juanky@gmail.com", "Colombia", "Activo");

CREATE TABLE Editorials (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(125) NOT NULL,
    Address VARCHAR(125) NOT NULL,
    Phone VARCHAR(35) NOT NULL UNIQUE,
    Email VARCHAR(125) NOT NULL UNIQUE,
    Status VARCHAR(50) NOT NULL
);

INSERT INTO Editorials (Name, Address, Phone, Email, Status)
VALUES ("Ivrea", "Calle 1 #11-A", "311010101", "Ivrea@gmail.com", "Activo");

CREATE TABLE Books (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Title VARCHAR(255) NOT NULL,
    Pages INT(10) NOT NULL,
    Language VARCHAR(125) NOT NULL,
    PublicationDate DATETIME NOT NULL,
    Description TEXT NOT NULL,
    Status VARCHAR(50) NOT NULL
);

INSERT INTO Books (Title, Pages, Language, PublicationDate, Description, Status)
VALUES ("Haikyu", 45, "Japones", "2012-02-20", "Shoyo Hinata es un estudiante que se fanatiza con el vóley después de ver un partido en el que la rompía un jugador petiso como él. Esto lo inspira a seguir sus pasos y convertirse en un as aunque tenga que arrancar bien de abajo.", "Activo");