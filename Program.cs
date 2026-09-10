Console.WriteLine("====PRODUTO FÍSICO====");
ProdutoFisico produtoFisico1 = new ProdutoFisico(
    "Notebook", 
    3500.00m,
    2.5);
    produtoFisico1.ExibirDados();
    Console.WriteLine($"Peso: {produtoFisico1.Peso} kg");

Console.WriteLine("====PRODUTO DIGITAL====");
ProdutoDigital produtoDigital1 = new ProdutoDigital(
    "Curso de C#",
    200.00m,
    "www.senai.com/cursoc-sharp");
    produtoDigital1.ExibirDados();
    Console.WriteLine($"Link: {produtoDigital1.LinkDownload}");