namespace CadastroClientes.Models.Repository
{
    public class ClientesRepository
    {
        public List<Clientes> Listar()
        {
            List<Clientes> clientesLista = new List<Clientes>(); 

            Clientes cliente = new Clientes();
            cliente.UF = "SP";
            cliente.Fax = "123456789";
            cliente.Telefone = "987654321";
            cliente.Documento = "123456789";
            cliente.Email = "amanda@gmail.com";
            cliente.Nome = "Amanda";
            cliente.Sexo = "Feminino";

            return null;
        }
    }
}
