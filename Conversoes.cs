    /// <summary>
    /// Conversão de temperaturas.
    /// </summary>
    /// <param name="conversao">A conversão a efetuar.</param>
    /// <param name="temperatura">A temperatua a converter.</param>
    /// <returns>Retorna o resultado da conversão da temperatura.</returns>
namespace Calculos
{
    /// <summary>
    /// Implementa operações de conversão
    /// </summary>
    internal static class Conversoes
    {
        /// <summary>
        /// Tipo de conversão de temperatura a executar.
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }
        /// <summary>
        /// Converte a temperatura.
        /// </summary>
        /// <param name="conversao">A conversão a efetuar.</param>
        /// <param name="temperatura">A temperatua a converter.</param>
        /// <returns>Retorna o resultado da conversão da temperatura.</returns>
        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.8000 + 32);
            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
            {
                return ((temperatura - 32) / 1.8000);
            }

            return -1;
        }
    }