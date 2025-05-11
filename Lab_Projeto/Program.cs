<<<<<<< Updated upstream
﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
=======
﻿using System;
using LabProjeto;

class Program
{
    static void Main()
    {
        var fabricaCliente = new RepositorioComInstancia<Cliente>();
        Cliente novoCliente = fabricaCliente.CriarItem();
        novoCliente.Id = 1;

        Console.Write("Digite o nome do cliente: ");
        novoCliente.Nome = Console.ReadLine();

        var repositorio = new Repositorio<Cliente>();
        repositorio.Adicionar(novoCliente);
        repositorio.Adicionar(new Cliente { Id = 2, Nome = "Ana" });

        Console.Write("Digite o ID do cliente a buscar: ");
        int idBusca = int.Parse(Console.ReadLine() ?? "0");

        Cliente? clienteEncontrado = repositorio.BuscarPorId(idBusca);

        if (clienteEncontrado != null)
        {
            Console.WriteLine($"Cliente encontrado: {clienteEncontrado.Nome}");
        }
        else
        {
            Console.WriteLine("Cliente não encontrado.");
        }
    }
}
>>>>>>> Stashed changes
