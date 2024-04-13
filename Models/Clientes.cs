namespace LHPet.Models;

public class Cliente
{
    /*No trecho de código a seguir são criados os atributos de Clientes e seus getters e setters
    correspondente.*/
    public int Id {get; set;}
    public string nome {get; set;}
    public string cpf {get; set;}
    public string Email {get; set;}
    public string paciente {get; set;}

    /* Nesse trecho do código, é criado o Construtor do model Cliente e determinado quais parâmetros são 
    necessários na criação das instâncias. */
    
    public Cliente(int id,string nome,string cpf,string Email,string paciente)
    {
        this.Id = id;
        this.nome = nome;
        this.cpf = cpf;
        this.Email = Email;
        this.paciente = paciente;
    }

}