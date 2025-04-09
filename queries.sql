-- Customer Table
CREATE TABLE Customer (
    CustomerID INT PRIMARY KEY IDENTITY(10000, 1),
    Username VARCHAR(255) NOT NULL,
    FullName VARCHAR(255) NULL,
    Email VARCHAR(255) UNIQUE NOT NULL,
    Password VARCHAR(255) NOT NULL,
    RegistrationDate DATE NOT NULL
);

-- Employee Table
CREATE TABLE Employee (
    EmployeeID INT PRIMARY KEY IDENTITY(90000, 1),
    Username VARCHAR(255) NOT NULL,
    FullName VARCHAR(255) NULL,
    Email VARCHAR(255) UNIQUE NOT NULL,
    Password VARCHAR(255) NOT NULL,
    RegistrationDate DATE NOT NULL,
    Role VARCHAR(50) NOT NULL  -- e.g., 'Chef', 'Reservation Coordinator'
);

-- FoodMenu Table
CREATE TABLE FoodMenu (
    FoodID INT PRIMARY KEY IDENTITY,
    Name VARCHAR(255) NOT NULL,
    CuisineType VARCHAR(255),
    Price DECIMAL(10, 2)
);

-- Order Table
CREATE TABLE OrderTable (
    OrderID INT PRIMARY KEY IDENTITY,
    CustomerID INT NOT NULL,
    TotalAmount DECIMAL(10, 2) NOT NULL,
    OrderStatus VARCHAR(50),
    DateOrdered DateTime,
    EmployeeID int NULL,
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID) ON DELETE CASCADE,
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID) ON DELETE CASCADE
);

-- OrderDetail Table
CREATE TABLE OrderDetail (
    OrderDetailID INT PRIMARY KEY IDENTITY,
    OrderID INT NOT NULL,
    FoodID INT NOT NULL,
    Quantity INT NOT NULL,
    Remarks VARCHAR(255),
    FOREIGN KEY (OrderID) REFERENCES OrderTable(OrderID) ON DELETE CASCADE,
    FOREIGN KEY (FoodID) REFERENCES FoodMenu(FoodID)
);

-- Inventory Table
CREATE TABLE Inventory (
    IngredientID INT PRIMARY KEY IDENTITY,
    Name VARCHAR(255) NOT NULL,
    Quantity INT NOT NULL
);

-- Hall Table
CREATE TABLE Hall (
    HallID INT PRIMARY KEY IDENTITY,
    Pax INT NOT NULL,
    PartyType VARCHAR(50) NOT NULL
);

-- Reservations Table
CREATE TABLE Reservations (
    ReservationID INT PRIMARY KEY IDENTITY,
    CustomerID INT NOT NULL,
    DateTime DATETIME NOT NULL,
    Pax INT NOT NULL,
    HallID INT NULL,
    ReservationStatus VARCHAR(50) NOT NULL, -- e.g., 'Pending', 'Confirmed', 'Cancelled', 'REMOVED'
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID) ON DELETE CASCADE,
    FOREIGN KEY (HallID) REFERENCES Hall(HallID) ON DELETE NO ACTION -- Prevent direct deletion
);

-- Invoice Table
CREATE TABLE Invoice (
    InvoiceID INT PRIMARY KEY IDENTITY,
    OrderID INT,
    CustomerID INT NOT NULL,
    Total DECIMAL(10, 2) NOT NULL,
    PaymentMethod VARCHAR(50) NOT NULL,
    FOREIGN KEY (OrderID) REFERENCES OrderTable(OrderID) ON DELETE CASCADE,
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID) ON DELETE CASCADE
);

-- Feedback Table
CREATE TABLE Feedback (
    FeedbackID INT PRIMARY KEY IDENTITY,
    Rating INT NOT NULL,
    Content text,
    ReadStatus VARCHAR(255),
    CustomerID INT NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID) ON DELETE CASCADE
);

-- Reservation Messages Table
CREATE TABLE ReservationMessage(
    MessageID INT PRIMARY KEY IDENTITY NOT NULL,
    ReservationID INT NOT NULL,
    CustomerMsg VARCHAR(255),
    RCReply VARCHAR(255)
    FOREIGN KEY (ReservationID) REFERENCES Reservations(ReservationID) ON DELETE CASCADE
);


-- Sample Data tables
INSERT INTO Employee (Username, Fullname, Email, Password, RegistrationDate, Role)
VALUES
('lum', 'Sarah Joe', 'sarah@mail.com', 'lum123', '2023-03-10', 'Chef'),
('sleep', 'Emmitt Gray', 'emmitt@mail.com', 'sleep123', '2023-01-18', 'Chef'),
('smog', 'Silicia Booker', 'smog@mail.com', 'smog123', '2023-06-16', 'Chef'),
('guava', 'Guomin Wei', 'guava@mail.com', 'guava123', '2023-03-27', 'Chef'),
('bean', 'Rowan Takinson', 'rowan@mail.com', 'bean987', '2023-07-23', 'Reservation Coordinator'),
('icecream', 'Yumi Ng', 'yumi@mail.com', 'bean987', '2024-01-30', 'Reservation Coordinator'),
('bobochacha', 'Siow Wan Qi', 'bobochacha@mail.com', 'bobochacha123', '2023-07-23', 'Reservation Coordinator'),
('rafi', 'Rafidah bin Abdul Kadir', 'rafi@mail.com', 'rafi', '2024-01-30', 'Reservation Coordinator'),
('Last', 'Hugo Vlad', 'hugo@mail.com', 'last123', '2023-05-06', 'Manager'),
('owen', 'Ho Wen Min', 'owen@mail.com', 'owen123', '2024-10-20', 'Manager'),
('cube', 'Alexandre Baptista', 'cube@mail.com', 'cube123', '2023-12-04', 'Admin'),
('wine', 'Miranda Parente', 'wine@mail.com', 'wine123', '2025-02-11', 'Admin');

INSERT INTO Customer (Username, FullName, Email, Password, RegistrationDate)
VALUES
('Ast Rickley', 'John Doe', 'johndoe@mail.com', 'ast123', '2023-06-17'),
('lml', 'Lim Mao Long', 'lml@mail.com', 'lml123', '2025-02-27'),
('Nick', 'Nick Collins', 'nick@mail.com', 'nicknick', '2023-04-08'),
('lantern', 'Muhammad Abu', 'lantern@mail.com', 'abu123', '2024-02-10'),
('beifang', 'Zhou Yong Fang', 'beifang@mail.com', 'beifang987', '2024-11-05'),
('Iris', 'Samantha Brown', 'iris@mail.com', 'iris987', '2024-09-13'),
('kody', 'Fernandes Shah', 'kody@mail.com', 'kody123', '2024-05-21'),

('scion', 'Somal Muhaidi', 'scion@mail.com', 'scion123', '2023-06-17'),
('hungry', 'Lim Hong Chai', 'hungry@mail.com', 'hungry123', '2025-02-27'),
('sun', 'Okubo Hikaru', 'sun@mail.com', 'sun123', '2023-04-08'),
('rain', 'Shawn Mentes', 'rain@mail.com', 'rain123', '2024-02-10'),
('poly', 'Mona Werner', 'poly@mail.com', 'poly123', '2024-11-05'),
('lily', 'Lilya Belykh', 'lily@mail.com', 'lily123', '2024-09-13'),
('choco', 'Siri Chamnan', 'choco@mail.com', 'choco123', '2024-05-21');
;

INSERT INTO FoodMenu (Name, CuisineType, Price)
VALUES
('Yangzhou Fried Rice', 'Chinese', 11.90),
('Nasi Lemak', 'Malay', 9.90),
('Wan Tan Mee', 'Chinese', 10.90),
('Ayam Rendang', 'Malay', 18.90),
('Biryani', 'Indian', 19.90),
('Cantonese-style Steamed Fish', 'Chinese', 25.60),
('Ayam Percik', 'Malay', 18.70),
('Roti Telur', 'Indian', 5.40),
('Bak Kut Teh', 'Chinese', 16.60),
('Satay (8 sticks)', 'Malay', 13.20),
('Gulai Ayam', 'Indian', 17.40),
('Satti Sorru', 'Indian', 15.90),
('Stir Fry Vegetables', 'Chinese', 11.20),

('Teh Ais Limau', 'Beverages', 4.00),
('Iced Milo', 'Beverages', 5.00),
('Eau du bain', 'Beverages', 12.90),
('Bottomless Soft Drink', 'Beverages', 10.90),
('Milo Dinosaur', 'Beverages', 7.80),
('Teh Tarik', 'Beverages', 6.40)
;

INSERT INTO Inventory (Name, Quantity)
VALUES
('Chicken', 32),
('Rice', 54),
('Basmati Rice', 32),
('Yellow Noodle', 27),
('Pork', 15),
('Fish', 18),
('Onions', 44),
('Bok Choy', 26),
('Cucumbers', 18),
('Egg', 73),
('Shrimp', 29),
('Garlic', 31),
('Chinese Herb Mix', 40),
('Flour', 16),
('Coconut Milk', 30),
('Mushroom', 38),
('Cinnamon', 23),
('Tumeric', 25),
('Star Anise', 21),
('Beef', 29)
;

INSERT INTO Hall (Pax, PartyType)
VALUES 
(2, 'Small Table'),
(4, 'Medium Table'),
(8, 'Large Table'),
(16, 'Joined Tables'),
(20, 'Entire Hall')
;

INSERT INTO OrderTable (CustomerID, TotalAmount, OrderStatus, DateOrdered ,EmployeeID)
VALUES
(10000, 27.80, 'Completed', '2023-06-28 19:17:43', 90000),	/* yz fried rice + satti sorru */
(10002, 38.50, 'In Queue', '2025-02-27 15:37:18', Null),	/* nasi lemak x2 + ayam percik */
(10001, 52.80, 'In Progress', '2024-05-21 11:28:46', 90003),	/* satay x4 */
(10005, 33.60, 'Completed', '2024-11-14 19:09:50', 90002),	/* gulai ayam + roti telur x3 */
(10006, 42.20, 'Completed', '2024-09-13 15:39:05', 90000),	/* bak kut teh + canto-style steamed fish */
(10003, 21.80, Null, '2024-05-11 10:36:08', Null),	/* wan tan mee x2 */
(10000, 101.10, 'In Queue', '2025-03-21 15:43:46', Null),	/* yz fried rice x2 + wan tan mee x2 + steam fish + ayam percik + stir fry veggie */
(10004, 27.80, 'In Progress', '2024-05-17 12:59:03', 90001),	/* bak kut teh + stir fry veggie */
(10002, 62.20, 'Completed', '2025-03-03 09:32:10', 90000),	/* biryani + satti sorru + satay x3 */
(10004, 39.70, 'Completed', '2024-08-09 13:02:10', 90002),	/* bak kut teh + stir fry veggie + yz fried rice */
(10006, 195.50, 'Completed', '2024-12-02 16:20:30', 90003), /* one of everything */
(10005, 56.10, Null, '2025-01-30 11:05:15', Null); /* ayam percik x3 */


INSERT INTO OrderDetail (OrderID, FoodID, Quantity, Remarks)
VALUES
(1, 1, 1, ''),
(1, 12, 1, ''),
(2, 2, 2, ''),
(2, 7, 1, ''),
(3, 10, 4, 'Extra Sauce'),
(4, 11, 1, ''),
(4, 8, 3, ''),
(5, 9, 1, ''),
(5, 6, 1, ''),
(6, 3, 2, ''),
(7, 1, 2, 'no shrimp'),
(7, 3, 2, ''),
(7, 6, 1, ''),
(7, 7, 1, ''),
(7, 13, 1, ''),
(8, 9, 1, ''),
(8, 13, 1, ''),
(9, 5, 1, ''),
(9, 12, 1, ''),
(9, 10, 3, ''),
(10, 9, 1, ''),
(10, 13, 1, 'extra plates'),
(10, 1, 1, ''),
(11, 1, 1, ''),
(11, 2, 1, ''),
(11, 3, 1, ''),
(11, 4, 1, 'no coconut milk'),
(11, 5, 1, ''),
(11, 6, 1, 'please separate into 12 portions'),
(11, 7, 1, ''),
(11, 8, 1, ''),
(11, 9, 1, ''),
(11, 10, 1, ''),
(11, 11, 1, ''),
(11, 12, 1, ''),
(11, 13, 1, ''),
(12, 7, 3, '')
;


INSERT INTO Reservations (CustomerID, DateTime, Pax, HallID, ReservationStatus)
VALUES
(10013, '2025-03-30', 3, 2, 'Pending'),
(10006, '2025-04-14', 18, 5, 'Confirmed'),
(10010, '2025-04-02', 6, 3, 'Pending'),
(10008, '2025-04-29', 2, 1, 'Cancelled'),

(10009, '2025-05-06', 8, 3, 'Confirmed'),
(10001, '2025-05-06', 10, 4, 'Confirmed'),
(10011, '2025-05-15', 12, 4, 'Confirmed'),
(10007, '2025-06-19', 5, 3, 'Pending'),

(10012, '2025-06-24', 4, 2, 'Cancelled') 
;


INSERT INTO Feedback (Rating, Content, CustomerID)
VALUES 
(5, 'Superb service and amazing food, especially the steamed fish!', 10006),
(4, 'The gulai ayam was great but the roti canai was a little stale', 10005),
(5, 'The fried rice was properly seasoned and satti sorru was savoury', 10000),
(1, 'Everything was bland and the satays were beyond charred!', 10002),
(4, 'Liked the stir fry vegetables, was not oily at all', 10004),
(3, 'Had a wonderful feast with the whole family, this restaurant is a haven for decadence.', 10006)
;

INSERT INTO Invoice (OrderID, CustomerID, Total, PaymentMethod)
VALUES
(1, 10000, 27.80, 'Credit Card'),
(4, 10005, 33.60, 'Cash'),
(5, 10006, 42.20, 'Cash'),
(9, 10002, 62.20, 'Cash'),
(10, 10004, 39.70, 'Credit Card'),
(11, 10006, 195.50, 'Cash')
;

INSERT INTO ReservationMessage (ReservationID, CustomerMsg, RCReply)
VALUES
(10013, 'Please tune down the air conditioner', ''),
(10010, '', ''),
(10007, 'Please prepare a babychair', '');
