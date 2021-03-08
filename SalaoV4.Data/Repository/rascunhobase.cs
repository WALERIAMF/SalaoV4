/* private readonly Context context;

public ClientRepository()
{
    context = new Context();
}

public void Incluir(Client client)
{
    context.Client.Add(client);
    context.SaveChanges();
}

public Client Selecionar(int id)
{
    return context.Client.FirstOrDefault(x => x.Id == id);
}

public List<Client> SelecionarTudo()
{
    return context.Client.ToList();
}

public void Alterar(Client client)
{
    context.Client.Update(client);
    context.SaveChanges();
}
public void Excluir(int id)
{
    var client = Selecionar(id);
    context.Client.Remove(client);
}
*/