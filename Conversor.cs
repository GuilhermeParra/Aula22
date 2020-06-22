namespace Aula22
{
    public static class Conversor
    {
        public static float CotacaoDolar = 5.23f;
        public static float CotacaoDolarCanadense = 3.89f;
        

        public static float RealParaDolar(float valorRS){
            return valorRS/CotacaoDolar;
        }
        public static float DolarParaReal(float valorUSS){
            return  CotacaoDolar*valorUSS;
        }
        /*public static float DolarCanadenseParaReal(float valorCS){
            return CotacaoDolarCanadense*valorCS;*/
        }
    }
