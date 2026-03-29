USE online_bookshop;
GO

-- 1. Insert Authors (IDENTITY handles author_id)
INSERT INTO authors (first_name, last_name, birth_year) VALUES
('Stephen', 'King', 1947), ('J.K.', 'Rowling', 1965), ('George', 'Orwell', 1903),
('Jane', 'Austen', 1775), ('Ernest', 'Hemingway', 1899), ('Toni', 'Morrison', 1931),
('Gabriel', 'Garcia Marquez', 1927), ('Virginia', 'Woolf', 1882), ('F. Scott', 'Fitzgerald', 1896),
('Leo', 'Tolstoy', 1828), ('Mark', 'Twain', 1835), ('Agatha', 'Christie', 1890),
('James', 'Baldwin', 1924), ('Haruki', 'Murakami', 1949), ('Margaret', 'Atwood', 1939),
('Neil', 'Gaiman', 1960), ('Ursula', 'K. Le Guin', 1929), ('Isaac', 'Asimov', 1920),
('Ray', 'Bradbury', 1920), ('Maya', 'Angelou', 1928);

-- 2. Insert Books (Added Price and fixed apostrophe)
INSERT INTO books (book_name, genre, price, release_year) VALUES
('The Shining', 'Horror', 15.00, 1977), ('Harry Potter', 'Fantasy', 20.00, 1997), ('1984', 'Dystopian', 12.50, 1949),
('Pride and Prejudice', 'Romance', 10.00, 1813), ('The Old Man and the Sea', 'Fiction', 11.00, 1952),
('Beloved', 'Fiction', 14.00, 1987), ('One Hundred Years of Solitude', 'Magical Realism', 18.00, 1967),
('To the Lighthouse', 'Modernism', 13.00, 1927), ('The Great Gatsby', 'Classic', 10.50, 1925),
('War and Peace', 'Historical Fiction', 25.00, 1869), ('Adventures of Huckleberry Finn', 'Adventure', 9.99, 1884),
('Murder on the Orient Express', 'Mystery', 12.00, 1934), ('Go Tell It on the Mountain', 'Fiction', 13.50, 1953),
('Norwegian Wood', 'Fiction', 14.99, 1987), ('The Handmaid''s Tale', 'Dystopian', 15.99, 1985), -- Fixed apostrophe
('American Gods', 'Fantasy', 16.00, 2001), ('A Wizard of Earthsea', 'Fantasy', 12.00, 1968),
('Foundation', 'Sci-Fi', 14.00, 1951), ('Fahrenheit 451', 'Dystopian', 11.99, 1953),
('I Know Why the Caged Bird Sings', 'Autobiography', 13.00, 1969), ('Misery', 'Horror', 12.99, 1987),
('Animal Farm', 'Satire', 9.00, 1945), ('The Hobbit', 'Fantasy', 15.00, 1937),
('Brave New World', 'Dystopian', 12.00, 1932), ('The Catcher in the Rye', 'Fiction', 11.00, 1951),
('The Alchemist', 'Adventure', 13.00, 1988), ('Dune', 'Sci-Fi', 17.00, 1965),
('The Road', 'Post-Apocalyptic', 14.00, 2006), ('The Book Thief', 'Historical Fiction', 13.00, 2005),
('Life of Pi', 'Adventure', 12.00, 2001);

-- 3. Insert Junction Data
INSERT INTO book_authors (book_id, author_id) VALUES
(1, 1), (21, 1), (2, 2), (3, 3), (22, 3), (4, 4), (5, 5), (6, 6), (7, 7), (8, 8),
(9, 9), (10, 10), (11, 11), (12, 12), (13, 13), (14, 14), (15, 15), (16, 16),
(17, 17), (18, 18), (19, 19), (20, 20);

-- 4. Insert Customers
INSERT INTO customers (first_name, last_name) VALUES
('John', 'Doe'), ('Jane', 'Smith'), ('Alice', 'Johnson'), ('Bob', 'Brown'),
('Charlie', 'Davis'), ('Emily', 'Wilson'), ('Frank', 'Miller'), ('Grace', 'Taylor'),
('Henry', 'Anderson'), ('Ivy', 'Thomas'), ('Jack', 'Jackson'), ('Kelly', 'White'),
('Liam', 'Harris'), ('Mia', 'Martin'), ('Noah', 'Thompson'), ('Olivia', 'Garcia'),
('Peter', 'Martinez'), ('Quinn', 'Robinson'), ('Ryan', 'Clark'), ('Sophia', 'Lewis');

-- 5. Insert Orders
INSERT INTO orders (customer_id) VALUES
(1), (2), (3), (4), (5), (1), (6), (7), (8), (9), (10), (11), (2), (12), (13);

-- 6. Insert Order-Book links
INSERT INTO order_books (order_id, book_id) VALUES
(1, 1), (1, 2), (2, 3), (3, 4), (3, 5), (4, 10), (5, 15), (6, 20), (7, 25), 
(8, 2), (9, 7), (10, 11), (11, 14), (12, 19), (13, 22), (14, 28), (15, 30);
GO