namespace CadastroClientes.Models.Repository
{
    public class ClientesRepository
    {
        public List<Clientes> Listar()
        {
            List<Clientes> clientesLista = new List<Clientes>(); 

            //Instanciando cliente Amanda
            Clientes cliente = new Clientes();
            cliente.UF = "SP";
            cliente.Fax = "123456789";
            cliente.Telefone = "987654321";
            cliente.Documento = "123456789";
            cliente.Email = "amanda@gmail.com";
            cliente.Nome = "Amanda";
            cliente.Sexo = "Feminino";
            cliente.idCliente = 10;
            //adicionamos Amanda na lista de clientes
            clientesLista.Add(cliente);


            //Instanciando cliente Daniel
            cliente = new Clientes();
            cliente.UF = "MG";
            cliente.Fax = "987654321";
            cliente.Telefone = "123456789";
            cliente.Documento = "11112225";
            cliente.Email = "daniel@gmail.com";
            cliente.Nome = "Daniel";
            cliente.Sexo = "Masculino";
            cliente.idCliente = 11;
            //adicionamos Daniel na lista de clientes
            clientesLista.Add(cliente);

            //Instanciando cliente Maria
            cliente = new Clientes();
            cliente.UF = "RJ";
            cliente.Fax = "145168684";
            cliente.Telefone = "156465465";
            cliente.Documento = "54654654";
            cliente.Email = "maria@gmail.com";
            cliente.Nome = "Maria";
            cliente.Sexo = "Feminino";
            cliente.idCliente = 10;
            //adicionamos Maria na lista de clientes
            clientesLista.Add(cliente);

            return clientesLista;
        }
    }
}
