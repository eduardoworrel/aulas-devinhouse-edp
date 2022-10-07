var dict = new Dictionary<Vendedor,List<CompraCliente>>{};

var vendedores = new Vendedor[]{
    new Vendedor(){
        nome = "Eduardo Worrel",
    },
    new Vendedor(){
        nome = "Nicolas Ferreira",
    },
    new Vendedor(){
        nome = "Tatyana de Alencar",
    }
};

foreach(var vendedor in vendedores){
    for(var i = 0; i < 5; i++){
            Console.WriteLine($"Insira os valores das compras efetuadas pelo vendedor [{vendedor.nome}]:");
            var valorDaCompra = Console.ReadLine();
            bool isNumeric = decimal.TryParse(valorDaCompra, out decimal decimalValue);
            

            var compra =  new CompraCliente{};
            if(isNumeric){
                compra.ValorTotal = decimalValue;
                Console.WriteLine($"Valor [{decimalValue}] foi adicionado.");

            }else{
                compra.ValorTotal = 0;
                Console.WriteLine($"Valor não pode ser convertido, então ficou 0.");
            }
            
            bool existeEsteVendedor = dict.Any((item=>item.Key.nome == vendedor.nome));
            
            if(!existeEsteVendedor){
                dict.Add(vendedor,new List<CompraCliente>{ compra });
            }else{
                dict[vendedor].Add(compra);
            }
    }
}
string nome = "";
decimal quantoFoi = 0;

foreach(var item in dict){
    Vendedor v = item.Key;
    List<CompraCliente> c = item.Value;

    decimal somaDasCompras = c.Sum((i)=>i.ValorTotal);

    if(somaDasCompras > quantoFoi){
        quantoFoi = somaDasCompras;
        nome = v.nome;
    }   
}

Console.WriteLine($"Vendedor [{nome}] vendeu mais que todos, foram R$ {quantoFoi}");


