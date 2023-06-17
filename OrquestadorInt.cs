using Capa_Modelo.Nodo;

namespace Capa_Logica.Lista_Simple
{
    public class OrquestadorInt
    {
        private NodoInt cabeza;

        public void Agregar_NodoInt(int valor) {

            NodoInt nodoNuevo = new NodoInt(valor);

            if (cabeza == null)
            {
                cabeza = nodoNuevo;
            }
            else {

                NodoInt nodoActual = cabeza;

                while (nodoActual.Siguiente != null) {
                    nodoActual = nodoActual.Siguiente;
                }

                nodoActual.Siguiente = nodoNuevo;
            }
        }

        public void Mostrar_Lista_Simple() {

            NodoInt nodoActual = cabeza;

            if (Cabeza_No_Nula())
            {
                Console.WriteLine("*-*-*-*Empieza Lista*-*-*-*");
                while (nodoActual != null)
                {
                    int valorActual = nodoActual.Valor;
                    Console.WriteLine(valorActual.ToString());
                    nodoActual = nodoActual.Siguiente;
                }
                Console.WriteLine("*-*-*-*Termina Lista*-*-*-*");
            }
        }

        public bool Cabeza_No_Nula() {

            if (cabeza != null)
            {
                return true;
            }
            else {
                return false;
            }
        }
        public int Busque_Valor(int _valor_A_Buscar) {

            int cantidad = 0;

            if (Cabeza_No_Nula()) {

                NodoInt nodoActual = cabeza;

                while (nodoActual!=null)
                {
                    if (nodoActual.Valor == _valor_A_Buscar)
                    { 
                        //cantidad = cantidad + 1;
                        cantidad++;
                       
                    }
                    nodoActual = nodoActual.Siguiente;
                }
            }
            return cantidad;  
        }
        public void Elimine_Nodo_Cabeza() {

            if (Cabeza_No_Nula())
            {
                NodoInt nodoActual = cabeza;
                NodoInt aux = cabeza;
                nodoActual = nodoActual.Siguiente;
                aux = null;
                cabeza = nodoActual;
            } 
        
        }
        // Tarea Moral
        public void Elimine_Ultimo_Nodo() {

            if (Cabeza_No_Nula()) {

                NodoInt nodoActual = cabeza;
                if (nodoActual.Siguiente == null)
                {
                    Elimine_Nodo_Cabeza();
                }
                else
                {
                    while (nodoActual.Siguiente.Siguiente!=null)
                    {
                        nodoActual = nodoActual.Siguiente;
                    }                
                    nodoActual.Siguiente = null;
                   
                }     
                
            }
        
        }


        public void Posicionar_Y_Borrar(int valor, int cantidad)
        {
            if (cabeza == null)
            {
                return;
            }

            NodoInt nodoActual = cabeza;
            NodoInt previo = null;

            // Buscar el nodo con el valor indicado
            while (nodoActual != null && nodoActual.Valor != valor)
            {
                previo = nodoActual;
                nodoActual = nodoActual.Siguiente;
            }

            if (nodoActual == null)
            {
                return; // No se encontró el nodo con el valor indicado
            }

            // Posicionarse en el siguiente nodo disponible
            NodoInt nodoBorrar = nodoActual.Siguiente;

            // Borrar los nodos a partir del siguiente nodo disponible
            for (int i = 0; i < cantidad && nodoBorrar != null; i++)
            {
                NodoInt siguiente = nodoBorrar.Siguiente;
                nodoBorrar = null;
                nodoBorrar = siguiente;
            }

            // Actualizar los enlaces
            nodoActual.Siguiente = nodoBorrar;

            if (previo == null)
            {
                cabeza = nodoBorrar;
            }
        }



    }
}

