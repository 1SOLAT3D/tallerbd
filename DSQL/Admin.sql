-- Vista de la ventana Administrador-Empleado
create view EmpleadoNombre
AS
select empleado.ID_Empleado,
case
when (Apellido_materno is null and Segundo_Nombre is null)
	then concat(Primer_Nombre,' ',Apellido_Paterno)
when Apellido_materno is null
	then concat(Primer_Nombre,' ',Segundo_Nombre,' ',Apellido_Paterno) 
when Segundo_Nombre is null
	then concat(Primer_Nombre,' ',Apellido_Paterno,' ',Apellido_Materno)
else
	concat(Primer_Nombre,' ',Segundo_Nombre,' ',Apellido_Paterno,' ',Apellido_Materno)
end as 'Nombre_Completo',
empleado.Tipo, empleado.Fecha_Ingreso 
from empleado,nombre_completo
where empleado.ID_NComp = nombre_completo.ID_NComp;

-- Vista de la ventana Administrador-Cliente
create view ClienteNombre
AS
select
cliente.ID_Cliente,
case
when (Apellido_materno is null and Segundo_Nombre is null)
	then concat(Primer_Nombre,' ',Apellido_Paterno)
when Apellido_materno is null
	then concat(Primer_Nombre,' ',Segundo_Nombre,' ',Apellido_Paterno) 
when Segundo_Nombre is null
	then concat(Primer_Nombre,' ',Apellido_Paterno,' ',Apellido_Materno)
else
	concat(Primer_Nombre,' ',Segundo_Nombre,' ',Apellido_Paterno,' ',Apellido_Materno)
end as 'Nombre_Completo',
cliente.Membresia, cliente.Domicilio, cliente.Telefono, cliente.Fecha_Alta, cliente.prioridad
from cliente,nombre_completo
where cliente.ID_NComp = nombre_completo.ID_NComp;

-- Vista de la ventana Administrador-Orden
create view OrdenBasico
AS
select 
case
when (nmc.Apellido_materno is null and nmc.Segundo_Nombre is null)
	then concat(nmc.Primer_Nombre,' ',nmc.Apellido_Paterno)
when nmc.Apellido_materno is null
	then concat(nmc.Primer_Nombre,' ',nmc.Segundo_Nombre,' ',nmc.Apellido_Paterno) 
when nmc.Segundo_Nombre is null
	then concat(nmc.Primer_Nombre,' ',nmc.Apellido_Paterno,' ',nmc.Apellido_Materno)
else
	concat(nmc.Primer_Nombre,' ',nmc.Segundo_Nombre,' ',nmc.Apellido_Paterno,' ',nmc.Apellido_Materno)
end as 'Nombre_Cliente',
case
when (nme.Apellido_materno is null and nme.Segundo_Nombre is null)
	then concat(nme.Primer_Nombre,' ',nme.Apellido_Paterno)
when nme.Apellido_materno is null
	then concat(nme.Primer_Nombre,' ',nme.Segundo_Nombre,' ',nme.Apellido_Paterno) 
when nme.Segundo_Nombre is null
	then concat(nme.Primer_Nombre,' ',nme.Apellido_Paterno,' ',nme.Apellido_Materno)
else
	concat(nme.Primer_Nombre,' ',nme.Segundo_Nombre,' ',nme.Apellido_Paterno,' ',nme.Apellido_Materno)
end as 'Nombre_Empleado',
case
when ccom.ID_Combo <> 0
then ccom.Nombre_Combo
else cccom.Nombre
end as Pedido,
ord.Fecha_pedido, ord.hora_estimada_entrega, c.Prioridad
from Orden ord  Join Empleado emp on ord.ID_Empleado = emp.ID_Empleado 
				Join Cliente c on c.ID_Cliente = ord.ID_Cliente
                Join Nombre_Completo nme on nme.ID_NComp = emp.ID_NComp
                Join Nombre_Completo nmc on nmc.ID_NComp = c.ID_NComp
                join Combo ccom on ccom.ID_Combo = ord.ID_Combo
				join Comida cccom on cccom.ID_Comida = ord.ID_Comida;
