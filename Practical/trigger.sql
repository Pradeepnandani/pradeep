create table employee(
Employee_id int identity not null primary key ,
first_name varchar(50),
last_name varchar(50),
email varchar(50),
phone_number bigint ,
 hire_date varchar(50),
 job_id int,
 salary numeric(18,2),
 manager_id int,
 department_id int
)
drop table employee
alter column Employee_id int


CREATE TABLE employee_audit(
changed_id int identity(1,1),
    Employee_id int ,
first_name varchar(50),
last_name varchar(50),
email varchar(50),
phone_number bigint ,
 hire_date varchar(50),
 job_id int,
 salary numeric(18,2),
 manager_id int,
 department_id int,
 Updated_date date,
 operation char(3),
CHECK(operation = 'INS' or operation='DEL'or operation='UPD')
);

create trigger trigger1 on employee
after insert, delete, update
as
begin
insert into employee_audit
(Employee_id,first_name,last_name,email,phone_number,hire_date,job_id,salary,manager_id,department_id,Updated_date,operation)
select i.Employee_id,first_name,last_name,email,phone_number,hire_date,job_id,salary,manager_id,department_id,GETDATE(),'INS'

from inserted as i 
UNION ALL
SELECT
d.Employee_id,first_name,last_name,email,phone_number,hire_date,job_id,salary,manager_id,department_id,GETDATE(),'DEL'

from deleted d




end

insert into employee(first_name,last_name,email,phone_number,hire_date,job_id,salary,manager_id,department_id)
values('Pradeep','Nandani','Pradeepnandani95@gmail.com',9657397,'11/04/1998',101,45000,102,111)

select * from employee
select * from employee_audit
delete from employee where employee_id=1

