namespace atividade_imc_xunit;
    public class IMC
    {
        public double peso;
        public double altura;
        public double imc;
        public String categoria;

        public void Calcular_IMC()
        {
            imc = peso / Math.Pow(altura, 2); //math.pow = biblioteca de matemática do c# p/calcular exponenciação
            //imc = peso / altura * altura;
            imc = Math.Round(imc,2); //math.round = bibli. para arredondar numeros
        }

        public void Classificar_IMC()
        {
            if(imc < 18.5)
                categoria = "Abaixo do peso";
            if(imc >= 18.5 && imc < 25)
                categoria = "Peso normal";
            if(imc >= 25 && imc < 30)
                categoria = "Sobrepeso";
            if(imc >= 30 && imc < 35)
                categoria = "Obesidade Grau I";
            if(imc >= 35 && imc < 40)
                categoria = "Obesidade Grau II";
            if(imc >= 40)
                categoria = "Obesidade Grau III";
        }
    }
