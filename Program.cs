string textReaderText = "StreamReader o padrão é a codificação UTF-8, a menos que especificado de outra forma, em vez de padronizar para a página de código ANSI para o sistema atual." +
    "O UTF-8 manipula caracteres Unicode corretamente e fornece resultados consistentes em versões localizadas do sistema operacional." +
    "Se você obtiver a codificação de caracteres atual usando a CurrentEncoding propriedade, o valor não será confiável até o primeiro Read método," +
    "pois a detecção automática de codificação não é feita até a primeira chamada para um Read método.\n\n" +

    "Por padrão, um StreamReader não é thread-safe. Consulte TextReader.Synchronized para obter um wrapper thread-safe.\n\n" +

    "O Read(Char[], Int32, Int32) Write(Char[], Int32, Int32) método e sobrecarrega a leitura e gravação do número de caracteres especificado pelo count parâmetro." +
    "Eles devem ser diferenciados de BufferedStream.Read e BufferedStream.Write , que lêem e gravam o número de bytes especificado pelo count parâmetro." +
    "Use os BufferedStream métodos somente para ler e gravar um número integral de elementos de matriz de bytes.\n\n";

Console.WriteLine($"Texto Orginial: { textReaderText}");

string linha, paragrafo = null;
var sr = new StringReader(textReaderText);

while (true)
{
    linha = sr.ReadLine();
    if (linha != null)
    {
        paragrafo += linha + " ";
    }else
    {
        paragrafo += "\n";
        break;
    }
}
Console.WriteLine($"Texto modificado: {paragrafo}");
int caractereLido;
char caractereConvertido;

var sw  = new StringWriter();
sr = new StringReader(paragrafo);

while (true)
{
    caractereLido = sr.Read();
    if (caractereLido == -1)
        break;

    caractereConvertido = Convert.ToChar(caractereLido);

    if (caractereConvertido == '.')
    {
        sw.Write("\n\n");
        sr.Read();
        sr.Read();

    }else
    {
        sw.Write(caractereConvertido);
    }
}
Console.Write($"O Texto Armazenado no StringREader {sw.ToString()}");