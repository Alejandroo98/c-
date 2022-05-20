-- Opcion 1
-- insert into Cursos( Nombre, NumeroEnteros ) values('POO',80);
-- insert into Cursos( Nombre, NumeroEnteros) values('ASP.NET',110);
-- insert into Cursos( Nombre, NumeroEnteros ) values('ANGULAR',90);

-- Opcion 2
set identity_insert Cursos ON  --Esto es para poder insertar nosotros la primary key, de lo contrario no nos dejara, o como en el ejemplo de arriba simplemente no lo ponemos y ya lo generara automaticamente
insert into Cursos( CursoId, Nombre, NumeroEnteros ) values(4, 'POO',80);
insert into Cursos( CursoId, Nombre, NumeroEnteros) values(5, 'ASP.NET',110);
insert into Cursos( CursoId, Nombre, NumeroEnteros ) values(6, 'ANGULAR',90);
set identity_insert Cursos OFF;


-- TABLA EMPLEADOS
set identity_insert Empleados ON  --Esto es para poder insertar nosotros la primary key, de lo contrario no nos dejara, o como en el ejemplo de arriba simplemente no lo ponemos y ya lo generara automaticamente
insert into Empleados( Empleadoid, Nombre, Apellido, Salario, Nacimiento ) values(10, 'Alejandro', 10 , 1000, '1998-01-01' );
set identity_insert Empleados OFF;


insert into CursoEmpleado ( CursosCursoId, ParticipantesEmpleadoid ) values ( 1, 10 );
insert into CursoEmpleado ( CursosCursoId, ParticipantesEmpleadoid ) values ( 2, 10 );
insert into CursoEmpleado ( CursosCursoId, ParticipantesEmpleadoid ) values ( 3, 10 );




