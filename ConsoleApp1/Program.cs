// See https://aka.ms/new-console-template for more information
using ProjectManagement.BLL;

StatusRepository statusRepository = new StatusRepository();

var allstatus = statusRepository.GetAll();
Console.WriteLine("Status possíveis para um projeto");
foreach (var status in allstatus)
{
    Console.WriteLine(status.Status1);
}

Console.WriteLine("\n\n");
ProjectRepository projectRepository = new ProjectRepository();
var allproject = projectRepository.GetAll();

foreach (var project in allproject)
{
    Console.WriteLine("ID do projeto: " + project.Id);
    Console.WriteLine("Nome do projeto: " + project.ProjectName);
    Console.WriteLine("Nome do administrador: " + project.ManagerName);
    Console.WriteLine("Data de ínicio do projeto: " + project.StartDate);
    Console.WriteLine("Data de finalização do projeto: " + project.FinishDate);
    Console.WriteLine("Resumo do projeto: " + project.Summary);
    Console.WriteLine("Status do projeto: " + statusRepository.GetById(project.IdStatus).Status1);
    Console.WriteLine("\n");
}