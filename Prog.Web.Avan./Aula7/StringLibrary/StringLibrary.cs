//https://learn.microsoft.com/pt-br/dotnet/core/tutorials/library-with-visual-studio-code?pivots=dotnet-8-0
using StringLibrary;
namespace UtilityLibraries;

public static class StringLibrary
{
    public static bool StartsWithUpper(this string? str)
    {
        if (string.IsNullOrWhiteSpace(str))
            return false;

        Soma.Executar(10, 5);

        char ch = str[0];
        return char.IsUpper(ch);
    }
}