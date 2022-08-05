// Exercício do corso do Nélio Alves Lucro Pro dutos Vetor"
// Um comerciante deseja fazer o levantamento do lucro das mercadorias que ele comercializa. Para isto, mandou digitar
// um conjunto de N mercadorias, cada uma contendo nome, preço de compra e preço de venda das mesmas. Fazer um
// programa que leia tais dados e determine e escreva quantas mercadorias proporcionaram:
// lucro< 10%
// 10% ≤ lucro ≤ 20%
// lucro> 20%
// Determine e escreva também o valor total de compra e de venda de todas as mercadorias, assim como o lucro total.


int N = int.Parse(Console.ReadLine());

string [] Produto = new string[N];
double [] PrecoCompra = new double[N];
double [] PrecoVenda = new double[N];

// Comando de entrada de dados;
for (int i = 0; i < N; i ++)
{
    string [] X = Console.ReadLine().Split(' ');
    Produto[i] = X[0];
    PrecoCompra[i] = double.Parse(X[1]);
    PrecoVenda[i] = double.Parse(X[2]);
}

// Comando para calcular a porcentagem de lucros;
int LucroBaixo = 0;
int LucroMedio = 0;
int LucroAcima = 0;
double Lucro = 0;
for (int i = 0; i < N; i ++)
{
    Lucro = PrecoVenda[i] - PrecoCompra[i];
    double Porcentagem = (Lucro / PrecoCompra[i]) * 100.0;
    if (Porcentagem < 10.0)
    {
        LucroBaixo ++;
    }
    else if (Porcentagem <= 20.0)
    {
        LucroMedio ++;
    }
    else {
        LucroAcima ++;
    }
}

// Comando para calcular o total de vendas;
double TotalCompra = 0;
double TotalVendas = 0;
double LucroTotal = 0;

for (int i = 0; i < N; i ++)
{
    TotalCompra = TotalCompra + PrecoCompra[i];
    TotalVendas = TotalVendas + PrecoVenda[i];
}
LucroTotal = TotalVendas - TotalCompra;

// Comando de saída de dados;
Console.WriteLine("Lucro abaixo de 10%: " + LucroBaixo);
Console.WriteLine("Lucro entre 10% e 20%: " + LucroMedio);
Console.WriteLine("Lucro acima de 20%: " + LucroAcima);
Console.WriteLine("Valor total de compras: " + TotalCompra.ToString("F2"));
Console.WriteLine("Valor total de ventas: " + TotalVendas.ToString("F2"));
Console.WriteLine("Lucro total: " + LucroTotal.ToString("F2"));
