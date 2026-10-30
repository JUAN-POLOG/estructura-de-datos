
using System;

// Clase Nodo
public class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int value)
    {
        Data = value;
        Left = null;
        Right = null;
    }
}

public class BSTDeletion
{
    public Node DeleteNode(Node root, int key)
    {
        if (root == null) return root;

        // Navegación hacia el nodo a eliminar
        if (key < root.Data)
            root.Left = DeleteNode(root.Left, key);
        else if (key > root.Data)
            root.Right = DeleteNode(root.Right, key);
        else
        {
            // Caso 1 y 2: Un solo hijo o sin hijos
            if (root.Left == null) return root.Right;
            else if (root.Right == null) return root.Left;

            // Caso 3: Dos hijos -> Obtener el Sucesor Inorden
            // (Menor del subárbol derecho)
            root.Data = MinValue(root.Right);

            // Eliminar el sucesor inorden
            root.Right = DeleteNode(root.Right, root.Data);
        }

        return root;
    }

    private int MinValue(Node root)
    {
        int minv = root.Data;

        while (root.Left != null)
        {
            minv = root.Left.Data;
            root = root.Left;
        }

        return minv;
    }
}

// Programa principal
public class Program
{
    public static void Main()
    {
        // Crear el árbol
        Node root = new Node(50);

        root.Left = new Node(30);
        root.Right = new Node(70);

        root.Left.Left = new Node(20);
        root.Left.Right = new Node(40);

        root.Right.Left = new Node(60);
        root.Right.Right = new Node(80);

        // Crear objeto para eliminar nodos
        BSTDeletion tree = new BSTDeletion();

        // Mostrar árbol antes de eliminar
        Console.WriteLine("Arbol antes de eliminar:");
        MostrarInOrder(root);

        // Eliminar el nodo 30
        root = tree.DeleteNode(root, 30);

        // Mostrar árbol despues de eliminar
        Console.WriteLine("\nArbol despues de eliminar el 30:");
        MostrarInOrder(root);

        Console.WriteLine();
    }

    // Metodo para mostrar los nodos ordenados
    public static void MostrarInOrder(Node root)
    {
        if (root == null) return;

        MostrarInOrder(root.Left);
        Console.Write(root.Data + " ");
        MostrarInOrder(root.Right);
    }
}
