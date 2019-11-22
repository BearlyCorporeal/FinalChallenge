/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
delete from Sale0136;
delete from Customer0136;
delete from Record0136;
delete from Interest0136;


insert into Interest0136(InterestCode,InterestDesc)Values('RR','Rock and Roll');
insert into Interest0136(InterestCode,InterestDesc)Values('JA','Jazz');
insert into Interest0136(InterestCode,InterestDesc)Values('RB','Rhythm and Blues');

insert into Record0136(RecordID,Title,Preformer)Values('PF003','The Wall','Pink Floyd');
insert into Record0136(RecordID,Title,Preformer)Values('IX002','Kick','INXS');
insert into Record0136(RecordID,Title,Preformer)Values('SP069','Never Mind the Bollocks','Sex Pistols');
insert into Record0136(RecordID,Title,Preformer)Values('PF007','The Division Bell','Pink Floyd');
insert into Record0136(RecordID,Title,Preformer)Values('PF002','The Dark Side of the Moon','Pink Floyd');
insert into Record0136(RecordID,Title,Preformer)Values('IX005','Shabooh Shoobah','INXS');
insert into Record0136(RecordID,Title,Preformer)Values('SP072','Floggin a Dead Horse','INXS');
insert into Record0136(RecordID,Title,Preformer)Values('PF004','The Endless River','Pink Floyd');
insert into Record0136(RecordID,Title,Preformer)Values('PF006','Wish You Were Here','Pink Floyd');
insert into Record0136(RecordID,Title,Preformer)Values('SP075','Agents of Anarchy','Sex Pistols');

insert into Customer0136(CustNo,CustName,CustAddress,CustPCode,InterestCode)values(123,'Jimmy Barnes','1 Sesame Street',3000,'RR');
insert into Customer0136(CustNo,CustName,CustAddress,CustPCode,InterestCode)values(456,'Ian Moss','10 Downing Street',4000,'JA');
insert into Customer0136(CustNo,CustName,CustAddress,CustPCode,InterestCode)values(789,'Don Walker','221B Baker Street',5000,'RB');
insert into Customer0136(CustNo,CustName,CustAddress,CustPCode,InterestCode)values(234,'Steve Prestwich','LG1 College Cres, Parkville',6000,'RR');
insert into Customer0136(CustNo,CustName,CustAddress,CustPCode,InterestCode)values(567,'Phil Small','1 Adelaide Avenue',7000,'RB');

insert into Sale0136(CustNo,RecordID,DateOrdered,Price)values(123,'PF003','01-Dec-15','$30.00');
insert into Sale0136(CustNo,RecordID,DateOrdered,Price)values(123,'IX002','01-Dec-15','$29.95');
insert into Sale0136(CustNo,RecordID,DateOrdered,Price)values(123,'SP069','02-Dec-15','$12.45');
insert into Sale0136(CustNo,RecordID,DateOrdered,Price)values(123,'IX002','05-Dec-18','$30.03');
insert into Sale0136(CustNo,RecordID,DateOrdered,Price)values(456,'PF007','03-Dec-15','$9.95');
insert into Sale0136(CustNo,RecordID,DateOrdered,Price)values(456,'PF002','01-Dec-15','$31.00');
insert into Sale0136(CustNo,RecordID,DateOrdered,Price)values(456,'IX005','03-Dec-15','$28.95');
insert into Sale0136(CustNo,RecordID,DateOrdered,Price)values(456,'SP072','03-Dec-15','$28.95');
insert into Sale0136(CustNo,RecordID,DateOrdered,Price)values(789,'PF004','02-Dec-15','$29.00');
insert into Sale0136(CustNo,RecordID,DateOrdered,Price)values(789,'IX002','05-Dec-16','$29.96');
insert into Sale0136(CustNo,RecordID,DateOrdered,Price)values(234,'PF006','01-Dec-15','$45.00');
insert into Sale0136(CustNo,RecordID,DateOrdered,Price)values(234,'SP075','04-Dec-16','$5.68');
insert into Sale0136(CustNo,RecordID,DateOrdered,Price)values(567,'PF007','03-Dec-15','$9.95');

