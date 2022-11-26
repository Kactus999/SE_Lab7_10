CREATE TABLE Items(
	ItemID iNT PRIMARY KEY,
	ItemName VARCHAR(255),
	Size INT
)

CREATE TABLE Agents(
	AgentID INT PRIMARY KEY,
	AgentName VARCHAR(255),
	Address VARCHAR(255)
)

CREATE TABLE Orders(
	OrderID INT PRIMARY KEY, 
	OrderDate DATE,
	AgentID INT FOREIGN KEY REFERENCES Agents(AgentID)
)

CREATE TABLE OrderDetails(
	ID INT PRIMARY KEY,
	OrderID INT FOREIGN KEY REFERENCES Orders(OrderID),
	ItemID INT,
	Quantity INT,
)

INSERT INTO Items(ItemID,ItemName,Size) VALUES (1,'Jordan 1',42)
INSERT INTO Items(ItemID,ItemName,Size) VALUES (2,'Jordan 2',38)
INSERT INTO Items(ItemID,ItemName,Size) VALUES (3,'Yezzy',40)
INSERT INTO Items(ItemID,ItemName,Size) VALUES (4,'Vans',43)
INSERT INTO Items(ItemID,ItemName,Size) VALUES (5,'Adidas Ultra Boost',41)
INSERT INTO Items(ItemID,ItemName,Size) VALUES (6,'Adidas Alpha Bounce',43)
INSERT INTO Items(ItemID,ItemName,Size) VALUES (7,'Nike Off-White',44)

INSERT INTO Agents(AgentID,AgentName,Address) VALUES (1,'Kien Outlet','123 ABC street')







