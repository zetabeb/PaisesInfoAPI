CREATE database paises_es;
CREATE TABLE paisesdata(id INT unsigned auto_increment PRIMARY KEY,
nombre VARCHAR(50),
continente VARCHAR(50),
capital VARCHAR(50),
moneda VARCHAR(50),
indicativoTelefonia VARCHAR(20),
zonahoraria VARCHAR(20),
codigoPostal VARCHAR(20),
idioma VARCHAR(50)
);
INSERT INTO `paises_es`.`paisesdata` 
( `nombre`, `continente`, `capital`, 
`moneda`, `indicativoTelefonia`, `zonahoraria`, 
`codigoPostal`, `idioma`) 
VALUES ( 'Colombia', 'América del Sur', 
'Bogotá DC', 'Peso Colombiano (COP)', 
'+57', 'GMT-5', '', 'Español')
