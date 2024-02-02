CREATE DATABASE Personalize_training;
USE Personalize_training;

CREATE USER user_1 IDENTIFIED BY "ABC123";
GRANT SELECT, DELETE, INSERT, UPDATE, EXECUTE
ON personalize_training.*
TO user_1;

CREATE TABLE Exercises(
Exercise_id INT PRIMARY KEY AUTO_INCREMENT,
Exercise_name VARCHAR (100)
);

INSERT INTO Exercises VALUES (DEFAULT, "Rest"),
								(DEFAULT, "Pushup"),
								(DEFAULT, "Crunches"),
								(DEFAULT, "Plank"),
								(DEFAULT, "Sideplank (Right)"),
								(DEFAULT, "Sideplank(Left)"),
								(DEFAULT, "Running"),
								(DEFAULT, "Burpees"),
								(DEFAULT, "Axelpress"),
								(DEFAULT, "Bicepscurl (dumbell)"),
								(DEFAULT, "benlyft"),
								(DEFAULT, "benpress"),
								(DEFAULT, "Bänkpress"),
								(DEFAULT, "Framåtlyft"),
								(DEFAULT, "Högaknälyft"),
								(DEFAULT, "latsDrag"),
								(DEFAULT, "marklyft"),
								(DEFAULT, "mountin Climber"),
								(DEFAULT, "pullups"),
								(DEFAULT, "rygglyft"),
								(DEFAULT, "sidolyft"),
								(DEFAULT, "Utfall (frammåt )"),
								(DEFAULT, "Utfall (bakåt)"),
								(DEFAULT, "Roddmasikin"),
								(DEFAULT, "Stegmaskin"),
								(DEFAULT, "bicepscurl (resistenceband)"),
								(DEFAULT, "Butt Kicks"),
								(DEFAULT, "Crossover Touch Squat"),
								(DEFAULT, "Burpee Walk"),
								(DEFAULT, "Step Up Knee Raise"),
								(DEFAULT, "Squats kickback"),
								(DEFAULT, "Calf raise"),
								(DEFAULT, "Singel leg Deadlift (right)"),
								(DEFAULT, "Singel leg Deadlift (Left)"),
								(DEFAULT, "TRX roddrag"),
								(DEFAULT, "TRX Chest Press"),
								(DEFAULT, "Utfall åt sidan (höger)"),
								(DEFAULT, "Utfall åt sidan (Vänster)"),
								(DEFAULT, "Bäckenlyft lår curl"),
								(DEFAULT, "BearCrawl");

CREATE TABLE Muscel_Group (
Muscel_Group_id INT PRIMARY KEY AUTO_INCREMENT,
Muscel_Group_Name VARCHAR (45),
Muscel_Group_Namn VARCHAR (45)
);


INSERT INTO Muscel_Group VALUES (DEFAULT, "Pectoralis major", "Stora bröstmuskeln"),       
								(DEFAULT, "Biceps", "Biceps"),
								(DEFAULT, "Abdominalis", "Raka bukmuskeln"),
								(DEFAULT, "Abductors", "Abducctorerna"),
								(DEFAULT, "Trapezius", "Kappmuskeln"),
								(DEFAULT, "Deltoid", "DeltaMuskeln"),
								(DEFAULT, "Lastissimus dorsi", "Breda ryggmuskeln"),
								(DEFAULT, "Serastis anterior", "Främre sågmuskeln"),
								(DEFAULT, "External oblique", "Sneda bukmuskeln"),
								(DEFAULT, "Brachioradialis", "Underarmens böjmuskler"),
								(DEFAULT, "Finger extensors", "Underarmens böjmuskler"),
								(DEFAULT, "Finger Flexors", "Underarmens böjmuskler"),
								(DEFAULT, "Quadriceps", "lårmuskeln framsidalår"),
								(DEFAULT, "Hamstrings", "Lårmuskeln baksidalår"),
								(DEFAULT, "Gastrocnemius", "Vadmuskeln"),
								(DEFAULT, "Tibialis anterior", "Främre skenbensmuskeln"),
								(DEFAULT, "Soleus", "Inre vadmuskeln"),
								(DEFAULT, "Infraspinatus", "Skulderblads muskeln"),
								(DEFAULT, "Teres major", "Stora runda muskeln"),
								(DEFAULT, "Triceps", "Trehövdade armsträckarmuskeln"),
								(DEFAULT, "Gluteus medius", "Mellersta sätesmuskeln"),
								(DEFAULT, "Gluteus maximus", "Stora sätesmuskeln"),
								(DEFAULT, "Sartorius", "Sartorius"),
                                (DEFAULT, "Lumbar spine", "Ländrygg");


  

CREATE TABLE Exercise_Muscel_Group (
Exercise_id INT,
Muscel_Group_id INT,
PRIMARY KEY (Exercise_id, Muscel_Group_id )
);

INSERT INTO Exercise_Muscel_Group VALUES 
										(2 , 1),
										(2 , 6),
										(2 , 3),
										( 2,20 ),
										( 3,3 ),
										( 3,9 ),
										( 4,3 ),
										( 4,9 ),
										( 5,3 ),
										( 5,9 ),
										( 6,3 ),
										( 6,9 ),
										( 7,3 ),
										( 7,9 ),
										( 8,13 ),
										( 8,14 ),
                                        (8,15),
                                        (8,22),
                                        (9,1),
                                        (9,6),
                                        (9,3),
                                        (9,20),
                                        (9,13),
                                        (10,6),
                                        (10,20),
                                        (11,2),
                                        (12,3),
                                        (12,9),
                                        (13,13),
                                        (13,14),
                                        (13,15),
                                        (13,22),
                                        (14,1),
                                        (14,6),
                                        (14,20),
                                        (15,6),
                                        (16,13),
                                        (16,14),
                                        (16,15),
                                        (16,22),
                                        (17,19),
                                        (17,2),
                                        (17,20),
                                        (17,10),
                                        (17,11),
                                        (17,12),
                                        (18,24),
                                        (18,15),
                                        (18,22),
                                        (18,14),
                                        (18,10),
                                        (18,11),
                                        (18,12),
                                        (18,13),
                                        (19,6),
                                        (19,3),
                                        (19,23),
                                        (19,4),
                                        (20,19),
                                        (20,20),
                                        (20,2),
                                        (20,10),
                                        (20,11),
                                        (20,12),
                                        (21,24),
                                        (22,6),
                                        (23,13),
                                        (23,22),
                                        (23,15),
                                        (24,13),
                                        (24,22),
                                        (24,15),
                                        (26,13),
                                        (26,14),
                                        (26,15),
                                        (26,22),
                                        (27,13),
                                        (27,14),
                                        (27,15),
                                        (27,22),
                                        (27,16),
                                        (27,17);
                                        
                                        
                                        
CREATE TABLE Program (
Program_id INT PRIMARY KEY AUTO_INCREMENT,
Program_name VARCHAR (45),
User_ID INT
);

INSERT INTO	Program VALUES (DEFAULT, "Basic_Workout",1);

CREATE TABLE Workout (
Program_id INT NOT NULL, 
Exercise_id INT NOT NULL,
E_Time INT,
Reps INT,
Weight INT,
Incline INT

);

INSERT INTO Workout VALUES  (1,27,20 ,0 , 0, 0),
							(1,28,20 ,0 , 0, 0),
							(1,29,20 ,0 , 0, 0),
							(1,27,20,0 , 0, 0),
							(1,28,20,0 , 0, 0),
							(1,29,20,0 , 0, 0),
							(1,01,60,0 , 0, 0),
							(1,30,20,0 , 0, 0),
							(1,31,20,0 , 0, 0),
							(1,32,20 ,0 , 0, 0),
							(1,33,20 ,0 , 0, 0),
							(1,34,20 ,0 , 0, 0),
							(1,30,20 ,0 , 0, 0),
							(1,31,20 ,0 , 0, 0),
							(1,32,20 ,0 , 0, 0),
							(1,33,20 ,0 , 0, 0),
							(1,34,20 ,0 , 0, 0),
							(1,01,60 ,0 , 0, 0),
							(1,20,20 ,0 , 0, 0),
							(1,05,20 ,0 , 0, 0),
							(1,06,20 ,0 , 0, 0),
							(1,20,20 ,0 , 0, 0),
							(1,05,20 ,0 , 0, 0),
							(1,06,20 ,0 , 0, 0);
                            
                            
CREATE TABLE Users(
User_id INT PRIMARY KEY AUTO_INCREMENT,
User_name VARCHAR (45) UNIQUE,
User_password VARCHAR (45)
);

INSERT INTO Users VALUES (DEFAULT,"Admin","a"),
(DEFAULT,"Bob", "b"),
(DEFAULT,"Sven", "s"),
(DEFAULT,"Toby", "t");


CREATE OR REPLACE VIEW See_Exercise_Muscel_Group AS
SELECT ex.Exercise_id, Exercise_Name, Muscel_Group_Name, mg.Muscel_Group_id FROM Exercises ex
JOIN Exercise_Muscel_Group em
ON em.Exercise_ID = ex.Exercise_ID
JOIN Muscel_Group mg
on mg.Muscel_group_id = EM.Muscel_group_id;



Delimiter $$
CREATE PROCEDURE Add_Muscel_Group_to_Exercise(
Exercise_id INT,
Muscel_Group_id INT
)
BEGIN
INSERT INTO Exercise_Muscel_Group VALUES (Exercise_id, Muscel_Group_id);
END$$
Delimiter ;


Delimiter $$
CREATE PROCEDURE Add_Exercise(
Exercise_Name VARCHAR (45)
)
BEGIN
INSERT INTO	Exercises VALUES (DEFAULT, Exercise_Name);
END$$
DElimiter ;


Delimiter $$
CREATE PROCEDURE Add_Workout(
Program_id INT,
Exercise_id INT,
E_Time INT,
Reps INT,
Weight INT,
Incline INT
)
BEGIN
INSERT INTO Workout VALUES (program_id, Exercise_id, E_Time, Reps, Weight, Incline);
END$$
Delimiter ;

Delimiter $$
CREATE PROCEDURE Add_program(
Program_name VARCHAR (45),
User_ID INT
)
BEGIN
INSERT INTO program VALUES (DEFAULT, program_name, User_ID);
END $$
Delimiter ;

CREATE OR REPLACE VIEW See_workout AS
SELECT Program_Id, Exercise_Name, E_Time, Reps, Weight, Incline  FROM Workout w
JOIN Exercises ex
ON ex.Exercise_id = w.Exercise_id;

CREATE INDEX Exercises on exercises(Exercise_id);
CREATE INDEX Muscels on Muscel_Group(Muscel_Group_id);
