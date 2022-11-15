create table Categories
(
    Id   integer
        constraint categories_pk
            primary key autoincrement,
    Name varchar
);

INSERT INTO Categories (Id, Name) VALUES (1, 'Напитки');
INSERT INTO Categories (Id, Name) VALUES (2, 'Снэки');
INSERT INTO Categories (Id, Name) VALUES (3, 'Молочка');

create table Products
(
    Id         integer not null
        constraint products_pk
            primary key autoincrement,
    Name       varchar not null,
    CategoryId integer
);

INSERT INTO Products (Id, Name, CategoryId) VALUES (1, 'Апельсиновый сок', 1);
INSERT INTO Products (Id, Name, CategoryId) VALUES (2, 'Cola', 1);
INSERT INTO Products (Id, Name, CategoryId) VALUES (3, 'Sprite', 1);
INSERT INTO Products (Id, Name, CategoryId) VALUES (4, 'Чипсы', 2);
INSERT INTO Products (Id, Name, CategoryId) VALUES (5, 'Молоко', 3);
INSERT INTO Products (Id, Name, CategoryId) VALUES (6, 'Кефир', 3);
INSERT INTO Products (Id, Name, CategoryId) VALUES (7, 'Хлеб', null);


SELECT Products.name AS ProductName, Categories.name AS CategoryName
FROM Products
         LEFT JOIN Categories ON Products.CategoryId = Categories.Id;

