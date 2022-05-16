-- Buscar en Ventana cliente
select c.ID_Cliente,c.ID_NComp, nm.Primer_Nombre, nm.Segundo_Nombre, nm.Apellido_Paterno, nm.Apellido_Materno, c.Membresia,c.domicilio,c.Telefono,c.Prioridad,c.Fecha_Alta 
from cliente c join nombre_completo nm on (nm.ID_NComp = c.ID_NComp)
where nm.Primer_Nombre = 'Alan' and nm.Apellido_Paterno = 'Bartolome' and nm.Apellido_Materno = 'Ortuño';


-- Insercion en la ventana cliente; 
 delimiter //
insert into nombre_completo(Primer_Nombre,Segundo_Nombre,Apellido_Paterno,Apellido_Materno) values ('aa','bb','cc','d');
	
insert into cliente (ID_NComp,Membresia,Domicilio,Telefono,Fecha_Alta,Prioridad) values
    ((select ID_NComp from Nombre_Completo ORDER BY ID_NComp DESC LIMIT 1),'Basica','a','777-777-7777',now(),'Baja');
//
 delimiter ;