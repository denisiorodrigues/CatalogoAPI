using System.Collections.ObjectModel;

namespace Namespace;
public class Categoria : BaseEntity
{
    public Categoria()
    {
        Produtos = new Collection<Produto>();
    }

    public string? Nome { get; set; }
    public string? ImagemUrl { get; set; }
    public ICollection<Produto>? Produtos {get; set;}
}