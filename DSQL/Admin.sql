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
