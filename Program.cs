using System;
namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {float val_pag;
            Console.WriteLine("Qual é o seu nome ?");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Qual é o seu endereço ?");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Pessoa Física (f) ou Pessoa Jurídica (j) ?");
            string var_tipo = Console.ReadLine();
            if(var_tipo == "f")
            {
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.cliente = var_nome;
                pf.endereço = var_endereco;
                Console.WriteLine("Informe seu CPF,por favor :");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Informe seu RG, por favor :");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informe o valor de compra, por favor: ");
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_pag);
                Console.WriteLine("----- Pessoa_Física -----");
                Console.WriteLine("Nome...........:" + pf.cliente);
                Console.WriteLine("Endereço.......:" + pf.endereço);
                Console.WriteLine("RG.............:" + pf.rg);
                Console.WriteLine("CPF............:" + pf.cpf);
                Console.WriteLine("Valor de Compra:" + pf.valor.ToString("C"));
                Console.WriteLine("Imposto........:" + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Total..........:" + pf.total.ToString("C"));
            }
            if(var_tipo =="j")
            {   
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.cliente = var_nome;
                pj.endereço = var_endereco;
                Console.WriteLine("Informe seu CNPJ,por favor :");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Informe seu Imposto Estadual, por favor :");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informe o valor de compra, por favor: ");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);
                Console.WriteLine("----- Pessoa_Física -----");
                Console.WriteLine("Nome............:" + pj.cliente);
                Console.WriteLine("Endereço........:" + pj.endereço);
                Console.WriteLine("Imposto Estaudal:" + pj.ie);
                Console.WriteLine("CNPJ............:" + pj.cnpj);
                Console.WriteLine("Valor de Compra.:" + pj.valor.ToString("C"));
                Console.WriteLine("Imposto.........:" + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total...........:" + pj.total.ToString("C"));
            }



        }
    }
}
