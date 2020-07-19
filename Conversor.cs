namespace Aula22
{
    public static class Conversor
    {
        public static float CotacaoDolar = 5.23f;
        
        
        /// <summary>
        /// Converte o valor de real para dolar
        /// </summary>
        /// <param name="valorRS">Determina o valor em reais</param>
        /// <returns>O valor convertido para dólar</returns>
        public static float RealParaDolar(float valorRS){
            return valorRS/CotacaoDolar;
        }
        /// <summary>
        /// Converte o valor de dolar para real
        /// </summary>
        /// <param name="valorUSS">Determina o valor em dolar</param>
        /// <returns>O valor convertido em reais</returns>
        public static float DolarParaReal(float valorUSS){
            return  CotacaoDolar*valorUSS;
        }
        
        
    }
}
