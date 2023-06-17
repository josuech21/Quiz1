using Capa_Logica.Lista_Simple;

OrquestadorInt orquestadorInt = new OrquestadorInt();
/*orquestadorInt.Agregar_NodoInt(1);
orquestadorInt.Agregar_NodoInt(1);
orquestadorInt.Agregar_NodoInt(1);
orquestadorInt.Agregar_NodoInt(1);
orquestadorInt.Agregar_NodoInt(1);
orquestadorInt.Agregar_NodoInt(1);
int cantidad = orquestadorInt.Busque_Valor(1);

Console.WriteLine(cantidad);*/
/*orquestadorInt.Agregar_NodoInt(1);
orquestadorInt.Agregar_NodoInt(2);
orquestadorInt.Mostrar_Lista_Simple();
orquestadorInt.Elimine_Nodo_Cabeza();
orquestadorInt.Mostrar_Lista_Simple();
*/
orquestadorInt.Agregar_NodoInt(1);
orquestadorInt.Agregar_NodoInt(2);
orquestadorInt.Agregar_NodoInt(3);
orquestadorInt.Agregar_NodoInt(4);
orquestadorInt.Agregar_NodoInt(5);
orquestadorInt.Mostrar_Lista_Simple();
// Después del método
orquestadorInt.PosicionarYBorrar(2,2);//el primero se posiciona en el nodo y el segundo le elimina
orquestadorInt.Mostrar_Lista_Simple();
