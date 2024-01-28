CREATE TABLE stuffTab
(
 [employ_id]                   int not null identity (1,1) primary key ,
 [FIO]                         varchar(50) NOT NULL ,
 [pasport_series_and_nomber]   int NOT NULL ,
 [post]                        varchar(50) NOT NULL ,
 [compliance_with_regulations] int NULL 

);
CREATE TABLE norma
(
 [standart_id]   int NOT NULL identity (1,1) primary key,
 [standart_name] varchar(255) NOT NULL 
);
CREATE TABLE complateNorm
(
 [standart_id] int NOT NULL foreign key references norma ([standart_id]),
 [employ_id]   int NOT NULL foreign key references stuffTab ([employ_id])

);
CREATE TABLE dateOF
(
 [production_operation] varchar(255) NOT NULL ,
 [employ_id]            int NULL foreign key references stuffTab ([employ_id])
);



CREATE TABLE product
(
 [product_id]             int NOT NULL identity (1,1) primary key,
 [product_name]           varchar(50) NOT NULL ,
 [complince_with_regular] int NOT NULL 
);
CREATE TABLE moneyTo
(
 [product_id]      int NOT NULL foreign key references product ([product_id]),
 [expenses_amount] float NOT NULL ,
 [employ_id]       int NOT NULL foreign key references stuffTab ([employ_id])
);
CREATE TABLE requir
(
 [requirement_id]   int NOT NULL identity (1,1) primary key,
 [requirement_name] varchar(255) NOT NULL 
);
CREATE TABLE complateTreb
(
 [requirement_id] int NOT NULL foreign key references  requir ([requirement_id]),
 [product_id]     int NOT NULL foreign key references  product ([product_id]),
 [accomplishment] int NULL 
);

