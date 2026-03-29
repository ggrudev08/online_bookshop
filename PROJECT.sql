
CREATE DATABASE online_bookshop;
GO

-- 3. Move inside the new database
USE [online_bookshop];
GO

-- 4. Create the tables
CREATE TABLE authors(
    author_id INT PRIMARY KEY IDENTITY(1,1),
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    birth_year INT
);

CREATE TABLE books(
    book_id INT PRIMARY KEY IDENTITY(1,1),
    book_name VARCHAR(50) NOT NULL,
    genre VARCHAR(50) NOT NULL,
    price DECIMAL(10, 2) NOT NULL, 
    release_year INT
);

CREATE TABLE book_authors(
    book_id INT,
    author_id INT,
    PRIMARY KEY(book_id, author_id),
    FOREIGN KEY(book_id) REFERENCES books(book_id),
    FOREIGN KEY(author_id) REFERENCES authors(author_id)
);

CREATE TABLE customers(
    customer_id INT PRIMARY KEY IDENTITY(1,1),
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL
);

CREATE TABLE orders(
    order_id INT PRIMARY KEY IDENTITY(1,1),
    customer_id INT,
    FOREIGN KEY(customer_id) REFERENCES customers(customer_id)
);

CREATE TABLE order_books(
    order_id INT,
    book_id INT,
    PRIMARY KEY(order_id, book_id),
    FOREIGN KEY(order_id) REFERENCES orders(order_id),
    FOREIGN KEY(book_id) REFERENCES books(book_id)
);
GO