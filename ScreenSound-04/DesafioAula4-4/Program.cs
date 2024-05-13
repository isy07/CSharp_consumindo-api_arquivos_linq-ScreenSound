﻿using DesafioAula4_4.Modelos;
using System.Text.Json;

string fileName = "pessoas1.json";

if (File.Exists(fileName))
{

    string jsonString = File.ReadAllText(fileName);


    var pessoas = JsonSerializer.Deserialize<List<Pessoa>>(jsonString);

    pessoas[0].ExibirDetalhesPessoa();
    Console.WriteLine();
    pessoas[1].ExibirDetalhesPessoa();
    Console.WriteLine($"\nNumero de pessoas na lista: {pessoas.Count}");

    //Console.WriteLine($"Nome: {pessoas.Nome}");
    //Console.WriteLine($"Idade: {pessoas.Idade}");
    //Console.WriteLine($"Email: {pessoas.Email}");

    //pessoas.ExibirDetalhesPessoa();
}
else
{
    Console.WriteLine("Arquivo inexistente.");
}