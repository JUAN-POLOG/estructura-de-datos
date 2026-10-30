
using System;
using System.Collections.Generic;

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

public class TreeTraversals
{
    // 1. Recorrido Preorden (Root, Left, Right)
    public void PreOrder(Node node)
    {
        if (node == null) return;

        Console.Write(node.Data + " ");
        PreOrder(node.Left);
        PreOrder(node.Right);
    }

    // 2. Recorrido Inorden (Left, Root, Right) - Imprime BST Ordenado
    public void InOrder(Node node)
    {
        if (node == null) return;

        InOrder(node.Left);
        Console.Write(node.Data + " ");
        InOrder(node.Right);
    }

    // 3. Recorrido Posorden (Left, Right, Root)
    public void PostOrder(Node node)
    {
        if (node == null) return;

        PostOrder(node.Left);
        PostOrder(node.Right);
        Console.Write(node.Data + " ");
    }

    // 4. Recorrido BFS Por Niveles (Uso de Queue FIFO)
    public void LevelOrder(Node root)
    {
        if (root == null) return;

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            Node current = queue.Dequeue();

            Console.Write(current.Data + " ");

            if (current.Left != null)
                queue.Enqueue(current.Left);

            if (current.Right != null)
                queue.Enqueue(current.Right);
        }
    }
}

// Programa principal
public class Program
{
    public static void Main()
    {
        // Crear los nodos
        Node root = new Node(50);

        root.Left = new Node(30);
        root.Right = new Node(70);

        root.Left.Left = new Node(20);
        root.Left.Right = new Node(40);

        root.Right.Left = new Node(60);
        root.Right.Right = new Node(80);

        // Crear objeto de recorridos
        TreeTraversals tree = new TreeTraversals();

        // Ejecutar recorridos
        Console.WriteLine("Recorrido Preorden:");
        tree.PreOrder(root);

        Console.WriteLine("\nRecorrido Inorden:");
        tree.InOrder(root);

        Console.WriteLine("\nRecorrido Posorden:");
        tree.PostOrder(root);

        Console.WriteLine("\nRecorrido Por Niveles (BFS):");
        tree.LevelOrder(root);

        Console.WriteLine();
    }
}
