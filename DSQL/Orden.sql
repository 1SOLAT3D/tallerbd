-- Insert comida y combo
insert into orden values (1,1,0,'2022-04-25 08:00:00','2022-04-25 08:15:00',1);

-- View de la ventana ordenes
create view OrdenDetalle
as select ord.ID_Cliente,case
when combo.ID_Combo>0
then combo.Nombre_combo
else comida.Nombre
end as Nombre, case
when combo.ID_Combo>0
then (select sum(precio) from comida where ID_Comida =coco.ID_Comida)
else comida.precio
end as Precio,
case
when combo.ID_Combo>0
then (select count(*) from combo_comida where id_combo = ord.ID_Combo)
else '1'
end as Cantidad,
ord.Fecha_Pedido, ord.Hora_Estimada_Entrega
from orden ord  join cliente c on c.ID_Cliente = ord.ID_Cliente
				join combo on combo.ID_Combo = ord.ID_Combo
                join comida on comida.ID_Comida = ord.ID_Comida
                join combo_comida coco on coco.ID_Combo = combo.ID_Combo;