    /// <summary>
    /// Implementa operações aritméticas.
    /// </summary>
    internal static class Aritmetica
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
        /// Operação de soma.
        /// </summary>Retorma a soma de dois números.
        public static int Somar(int x, int y)
        {
            return x + y;
        }
        /// <summary>
        /// Operação de subtração.
        /// </summary>Retorna a subtração de dois números.
        public static int Subtrair(int x, int y)
        {
            return x - y;
        }

        /// <summary>
        /// Operação de multiplicação.
        /// </summary>
        /// <returns>Retorna o resultado da multiplicação de dois números.</returns>
        public static int Multiplicar(int x, int y) 
        {
            return x * y;
        }        

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