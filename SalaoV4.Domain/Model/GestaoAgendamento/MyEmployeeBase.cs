using SalaoV4.Domain.Model.GestaoAgendamento;
using System;
using System.Collections.Generic;
using System.Linq;
using static SalaoV4.Domain.Model.Employee;

namespace SalaoV4.Domain.Model
{
    public class MyEmployeeBase
    {
        public List<Employee> Funcionarios { get; set; }

        public MyEmployeeBase()
        {
            Funcionarios = new List<Employee>();
        }


        public void Add(Employee func)
        {
            int id = 0;
            if (Funcionarios.Any())
                id = Funcionarios.Last().Id + 1;
            else
                id++;
            func.Id = id;
            Funcionarios.Add(func);
        }

        public void ChangeEmployee(int id, string nomeNovo, string telefoneNovo, Address enderecoNovo, PositionEmployer cargoNovo)
        {
            Funcionarios.Find(func => func.Id == id)
                .Change(nomeNovo, telefoneNovo, enderecoNovo, cargoNovo);
        }

        public void IncludeEmployerService(int id, Services servico)
        {
            Funcionarios.Find(func => func.Id == id)
                .ServicesInclude(servico);
        }

        public void DeleteEmployer(int matricula)
        {
            Funcionarios.RemoveAll(func => func.Id.Equals(matricula));
        }

        public void DeleteEmployerService(int id, int idServ)
        {
            Employee func = Funcionarios.Find(func => func.Id == id);
            if (func != null)
            {
                func.Services.RemoveAll(serv => serv.Id == idServ);
            }

            //Funcionarios.Find(func => func.Matricula == matricula)
            //.Servicos.RemoveAll(serv => serv.Id == idServ);
        }

        private void DadosIniciais(MyServicesBase baseDeServico)
        {
            Employee f1 = new Employee();
            Address e1 = new Address();
            e1.Add(1, "Rua dos bobos", "12345-010", "Vila dos Devs", "São Paulo", "SP", "0", string.Empty);

            f1.Add("Maria", "999999999", e1, Employee.PositionEmployer.Cabelereira);

            Employee f2 = new Employee();
            f2.Add("Rosana", "999999998", e1, Employee.PositionEmployer.Manicure);

            Employee f3 = new Employee();
            f3.Add("Joana", "999999997", e1, Employee.PositionEmployer.Esteticista);

            MyEmployeeBase bf = new MyEmployeeBase();
            bf.Add(f1);
            bf.Add(f2);
            bf.Add(f3);


            bf.IncludeEmployerService(1, baseDeServico.Services.FirstOrDefault(x => x.Id == 1));
            bf.IncludeEmployerService(2, baseDeServico.Services.FirstOrDefault(x => x.Id == 2));
            bf.IncludeEmployerService(2, baseDeServico.Services.FirstOrDefault(x => x.Id == 3));
            bf.IncludeEmployerService(3, baseDeServico.Services.FirstOrDefault(x => x.Id == 4));

            //return bf;
        }



    }
}
