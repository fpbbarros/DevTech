
CREATE TABLE Usuario (

  [Id] varchar(36) primary key,
  [Name] varchar(50),
  [Surname] varchar(80),
  [Login] varchar(30),
  [Password] varchar(30),
  [Salt] varchar(18)  

);

CREATE TABLE PerfilUsuario (

  UserId varchar(36),
  ProfilesId varchar(36)    

);

CREATE TABLE Perfil (

  [Id] varchar(36) primary key,
  ProfileNome varchar(36)    

);

CREATE TABLE RegraPerfil (

  
  RoleId varchar(36),
  ProfileId varchar(36)

);

CREATE TABLE Regra (

  
  [Id] varchar(36) primary key,
  RoleName varchar(80)

);










