-- 1) test veritabanınızda employee isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.
-- CREATE TABLE employee (id SERIAL PRIMARY KEY, name VARCHAR(50) NOT NULL, birthday DATE, email VARCHAR(100));

-- 2) Oluşturduğumuz employee tablosuna 'Mockaroo' servisini kullanarak 50 adet veri ekleyelim.
--insert into employee (name, birthday, email) values ('Jefferson Hassen', '1991-11-26', 'jhassen0@bloglovin.com');
--insert into employee (name, birthday, email) values ('Abbie Reynard', '1970-11-29', 'areynard1@seattletimes.com');
--insert into employee (name, birthday, email) values ('Oran Elwel', '1963-05-26', 'oelwel2@yandex.ru');
--insert into employee (name, birthday, email) values ('Dante Loakes', '1981-08-17', 'dloakes3@nih.gov');
--insert into employee (name, birthday, email) values ('Mattie Olivia', '1990-08-28', 'molivia4@webmd.com');
--insert into employee (name, birthday, email) values ('Jobyna Ebenezer', '1988-08-03', 'jebenezer5@gravatar.com');
--insert into employee (name, birthday, email) values ('Daile Keepin', '1990-11-23', 'dkeepin6@mozilla.com');
--insert into employee (name, birthday, email) values ('Lalo Sprade', '2002-07-23', 'lsprade7@barnesandnoble.com');
--insert into employee (name, birthday, email) values ('Celeste Skitteral', '1996-02-23', 'cskitteral8@virginia.edu');
--insert into employee (name, birthday, email) values ('Grover Woodwin', '1965-12-14', 'gwoodwin9@wiley.com');
--insert into employee (name, birthday, email) values ('Marielle Goodlife', '1962-10-18', 'mgoodlifea@admin.ch');
--insert into employee (name, birthday, email) values ('Hadleigh Wondraschek', '1980-01-02', 'hwondraschekb@hp.com');
--insert into employee (name, birthday, email) values ('Gerri Dacre', '1951-11-03', 'gdacrec@amazon.com');
--insert into employee (name, birthday, email) values ('Gabi Van Brug', '1992-03-30', 'gvand@blog.com');
--insert into employee (name, birthday, email) values ('Carolyn Mayoh', '1998-08-17', 'cmayohe@barnesandnoble.com');
--insert into employee (name, birthday, email) values ('Bobinette Balsellie', '1966-02-19', 'bbalsellief@hud.gov');
--insert into employee (name, birthday, email) values ('Barret Cowlin', '1976-08-19', 'bcowling@plala.or.jp');
--insert into employee (name, birthday, email) values ('Cyndia Nassey', '1952-03-15', 'cnasseyh@bbc.co.uk');
--insert into employee (name, birthday, email) values ('Luz Traylen', '1968-04-11', 'ltrayleni@loc.gov');
--insert into employee (name, birthday, email) values ('Jobina Bockmann', '1977-06-22', 'jbockmannj@slideshare.net');
--insert into employee (name, birthday, email) values ('Malissa Bohea', '1974-05-27', 'mboheak@live.com');
--insert into employee (name, birthday, email) values ('Shem Dougher', '1979-09-30', 'sdougherl@scientificamerican.com');
--insert into employee (name, birthday, email) values ('Moore Albarez', '1973-03-29', 'malbarezm@bloglovin.com');
--insert into employee (name, birthday, email) values ('Kylen Andrzej', '1954-03-15', 'kandrzejn@symantec.com');
--insert into employee (name, birthday, email) values ('Jorie Gillatt', '1957-03-28', 'jgillatto@lulu.com');
--insert into employee (name, birthday, email) values ('Jerri Babonau', '1967-10-24', 'jbabonaup@businesswire.com');
--insert into employee (name, birthday, email) values ('Nichol Traves', '1999-05-10', 'ntravesq@microsoft.com');
--insert into employee (name, birthday, email) values ('Vanya Edwicker', '1977-04-03', 'vedwickerr@barnesandnoble.com');
--insert into employee (name, birthday, email) values ('Lambert Dionisetto', '1979-04-18', 'ldionisettos@shutterfly.com');
-- insert into employee (name, birthday, email) values ('Josselyn Floweth', '1953-01-13', 'jflowetht@comsenz.com');
-- insert into employee (name, birthday, email) values ('Iorgos Neame', '1997-07-03', 'ineameu@rambler.ru');
--insert into employee (name, birthday, email) values ('Pierrette Spaldin', '1982-06-11', 'pspaldinv@umn.edu');
--insert into employee (name, birthday, email) values ('Kissie Robel', '1997-03-20', 'krobelw@alexa.com');
--insert into employee (name, birthday, email) values ('Maryanna Tomaskov', '1969-07-20', 'mtomaskovx@i2i.jp');
--insert into employee (name, birthday, email) values ('Budd Wiper', '2002-08-18', 'bwipery@sbwire.com');
--insert into employee (name, birthday, email) values ('Lewes Laimable', '1960-03-25', 'llaimablez@unc.edu');
--insert into employee (name, birthday, email) values ('Zachary Ennever', '1952-07-20', 'zennever10@gravatar.com');
--insert into employee (name, birthday, email) values ('Deena Rosenbloom', '1964-03-19', 'drosenbloom11@sina.com.cn');
--insert into employee (name, birthday, email) values ('Stewart Petrak', '1995-09-13', 'spetrak12@yahoo.com');
--insert into employee (name, birthday, email) values ('Darrell Jannasch', '1968-09-29', 'djannasch13@bing.com');
--insert into employee (name, birthday, email) values ('Joshua Ernke', '1966-04-13', 'jernke14@umn.edu');
--insert into employee (name, birthday, email) values ('Ddene Laidlow', '2004-05-11', 'dlaidlow15@shop-pro.jp');
--insert into employee (name, birthday, email) values ('Yule Vogelein', '1990-06-07', 'yvogelein16@marriott.com');
--insert into employee (name, birthday, email) values ('Nils Cockshot', '1967-01-30', 'ncockshot17@posterous.com');
--insert into employee (name, birthday, email) values ('Paolina Sketcher', '2000-04-07', 'psketcher18@state.tx.us');
--insert into employee (name, birthday, email) values ('Zitella Studeart', '1981-11-05', 'zstudeart19@globo.com');
--insert into employee (name, birthday, email) values ('Cora Kinman', '1996-04-11', 'ckinman1a@cbsnews.com');
--insert into employee (name, birthday, email) values ('Levin Claessens', '1956-05-12', 'lclaessens1b@xrea.com');
--insert into employee (name, birthday, email) values ('Agneta Anthonies', '2000-09-11', 'aanthonies1c@fotki.com');
--insert into employee (name, birthday, email) values ('Lillis Sinnie', '1976-06-09', 'lsinnie1d@angelfire.com');

--3)Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım.

--UPDATE employee 
--SET name = 'Oscar Wild',
--	birthday = '2000-05-01',
--	email = 'oscarwild@gmail.com'
--WHERE id = 1;

--UPDATE employee 
--SET name = 'Charles Aznavour',
--	birthday = '1950-04-12',
--	email = 'charles@gmail.com'
--WHERE id = 2;

--UPDATE employee 
--SET name = 'Jeremy Hopkins',
--	birthday = '2000-09-22',
--	email = 'jhopkins@gmail.com'
--WHERE id = 3;

--UPDATE employee 
--SET name = 'Joaquin Phoenix',
--	birthday = '1972-11-23',
--	email = 'joaquinphoenix@gmail.com'
--WHERE id = 4;

--UPDATE employee 
--SET name = 'Frances Conroy',
--	birthday = '1964-06-01',
--	email = 'fconroy@gmail.com'
--WHERE id = 5;


--4)Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.
--DELETE FROM employee
--WHERE id IN (1,2,3,4,5)
--RETURNING *;







