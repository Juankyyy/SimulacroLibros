CREATE TABLE Authors (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(125) NOT NULL,
    LastName VARCHAR(45) NOT NULL,
    Email VARCHAR(125) NOT NULL UNIQUE,
    Nationality VARCHAR(125) NOT NULL
);

TRUNCATE TABLE Authors;

INSERT INTO Authors (Name, LastName, Email, Nationality)
VALUES ("Juanky", "H", "juanky@gmail.com", "Colombia"), ("Juanda", "O", "juanda@gmail.com", "Colombia")

CREATE TABLE Editorials (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(125) NOT NULL,
    Address VARCHAR(125) NOT NULL,
    Phone VARCHAR(35) NOT NULL UNIQUE,
    Email VARCHAR(125) NOT NULL UNIQUE
);

CREATE TABLE Books (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Title VARCHAR(255) NOT NULL,
    Pages INT(10) NOT NULL,
    Language VARCHAR(125) NOT NULL,
    PublicationDate DATETIME NOT NULL,
    Description TEXT NOT NULL
);

TRUNCATE TABLE Authors;