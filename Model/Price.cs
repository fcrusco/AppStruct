namespace AppStruct.Model;
public struct Price 
{
    public decimal Valor { get; }
    public string Moeda { get; }

    public Price(decimal valor, string moeda)
    {
        Valor = valor;
        Moeda = moeda;
    }

    public string Display()
    {
        return $"Preço: {Valor.ToString("N")} {Moeda}";
    }
}
