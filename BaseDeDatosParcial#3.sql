CREATE DATABASE IF NOT EXISTS SistemaLoginDB;
USE SistemaLoginDB;

-- Tabla 1: Usuarios con contraseña hasheada
CREATE TABLE Usuarios (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Usuario VARCHAR(50) UNIQUE NOT NULL,
    PasswordHash VARCHAR(255) NOT NULL
);

-- Tabla 2: Historial de intentos fallidos y exitosos
CREATE TABLE IntentosLogin (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Usuario VARCHAR(50) NOT NULL,
    Exitoso BOOLEAN NOT NULL, -- 1 (TRUE) = Exitoso, 0 (FALSE) = Fallido
    Fecha DATETIME DEFAULT CURRENT_TIMESTAMP NOT NULL
);