using System.Windows.Forms;

public class Pessoa
{
    private string nome;
    private string CPF;
    private int idade;
    private string sexo;
    private double peso;
    private double altura;

    
   public Pessoa(string nome, string CPF, int idade, string sexo, double peso, double altura)
   {
        this.nome = nome;
        this.CPF = CPF;
        this.idade = idade;
        this.sexo = sexo;
        this.peso = peso;
        this.altura = altura;
   }
    public string Nome
    {
        get { return nome; }
        set { this.nome = value; }
    }
    public string Cpf
    {
        get {return nome;}
        set { this.nome = value; }
    }
    public int Idade
    {
        get { return idade; }
        set { this.idade = value; }
    }
    public string Sexo
    {
        get {return sexo;}
        set { this.sexo = value; }
    }
    public double Peso
    {
        get { return peso; }
        set { this.peso = value; }
    }
    public double Altura
    {
        get { return altura; }
        set { this.altura = value; }
    }
    public (double,string,string) Calcular()
    {
        double imc = peso / (altura * altura);
        string classificacao = "";
        string grau = "";

        if (imc < 18.5)
        {
            classificacao = "Magreza";
            grau = "0";
        }
        else if(imc >= 18.5 && imc <= 24.9)
        {
            classificacao = "Normal";
            grau = "0";
        }
        else if(imc >= 25.0 && imc <= 29.9)
        {
            classificacao = "Sobrepeso";
            grau = "I";
        }
        else if (imc >= 30.0 && imc <= 39.9)
        {
            classificacao = "Obesidade";
            grau = "II";
        }
        else if(imc > 40)
        {
            classificacao = "Obesidade Grave";
            grau = "III";
        }       
       
        return (imc,classificacao,grau);
    }

}
