public class Vendedor{
    public string nome {get;set;}
    private decimal totalVendido = 0;
    public void SomaValor (int valor){
        totalVendido += valor;
    }
    public decimal pegaTotalVendido (){
        return totalVendido;
    }
    
}
public class CompraCliente{
    public decimal ValorTotal {get;set;}
}
