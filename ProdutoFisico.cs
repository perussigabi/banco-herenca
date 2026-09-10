public class ProdutoFisico : Produto{
    private double _peso = 0;
    
    public ProdutoFisico(string nome, decimal preco, double peso) : base (nome, preco){
        Peso = peso;

    }

    public double Peso{
        get {return _peso;}
        set {_peso = value;}
    }

    public decimal CalcularFrete(double peso){
        decimal ValorFrete = (decimal) peso * 10.00m;
        return ValorFrete;
    }
}