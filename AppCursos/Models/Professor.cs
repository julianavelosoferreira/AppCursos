namespace AppCursos.Models
{
    public class Professor
    {
        //Criar uma model como o nome Professor, contendo os campos Id, Nome, Email e Salário.
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Salario { get; set; }

        //Adicionar a tabela de professor no banco de dados ( DbSet, Migration, Update-Database)


    }


}
