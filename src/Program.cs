using ProblemOne.Models;
using ProblemOne.Repository;
using ProblemOne.Service;
using ProblemTwo.Models;
using ProblemTwo.Repository;
using ProblemTwo.Service;
using System;

namespace FEEmployee
{
    class Program
    {
        Repository<EmployeeWithAddress> _employeeWithAddressRepository;
        EmployeeWithAddressService _employeeWithAddressService;
        public Program()
        {
            _employeeWithAddressRepository = new Repository<EmployeeWithAddress>(new EmployeeWithAddressContext());
            _employeeWithAddressService = new EmployeeWithAddressService(_employeeWithAddressRepository);
        }
        static void Main(string[] args)
        {
            var program = new Program();
            while (program.FEService() != 0)
            {
            }
        }

        private void ShowEmployeeList()
        {
            _employeeWithAddressService.Show();
        }

        private void DeleteEmployeeRecord()
        {
            Console.WriteLine("Enter the guid to delete the record");
            _employeeWithAddressService.Delete(new Guid(Console.ReadLine()));
        }

        private void SaveEmployeeTo()
        {
            Console.WriteLine("Enter 1 to save the list in JSON format");
            Console.WriteLine("Enter 2 to save the list in XML format");
            Console.WriteLine("Enter 3 to save the list in CSV format");
            var choice = int.Parse(Console.ReadLine());
            var filePath = "";
            switch (choice)
            {
                case 1:
                    filePath = _employeeWithAddressService.SaveTo(Format.json);
                    break;
                case 2:
                    filePath = _employeeWithAddressService.SaveTo(Format.xml);
                    break;
                case 3:
                    filePath = _employeeWithAddressService.SaveTo(Format.csv);
                    break;
                default:
                    break;
            }
            Console.WriteLine($"File saved to the path {filePath}");
            Console.WriteLine();
        }

        private int FEService()
        {
            Console.WriteLine(@"Enter 1 to view employee list");
            Console.WriteLine(@"Enter 2 to delete employee record");
            Console.WriteLine(@"Enter 3 to save the list");
            Console.WriteLine(@"Enter 0 to quit");
            var choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ShowEmployeeList();
                    break;
                case 2:
                    DeleteEmployeeRecord();
                    break;
                case 3:
                    SaveEmployeeTo();
                    break;
                default:
                    choice = 0;
                    break;
            }
            return choice;
        }
    }
}
