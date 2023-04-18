// See https://aka.ms/new-console-template for more information
using System.Threading.Channels;
using Controllers;
using Models;

Console.WriteLine("Projeto loja"); // class librabry o mvc

var data = new Store()
{
    Description = "Teste",
    Address = "Rua do alem"
};

//string returnInformation = (new StoreController().Insert(data) ? "Inserido" : "Erro");
//Console.WriteLine(returnInformation);

//var stores = new StoreController().GetAll(); // para imprimir o toString
//stores.ForEach(s => Console.WriteLine(s));

new StoreController().GetAll().ForEach(x => Console.WriteLine(x));
