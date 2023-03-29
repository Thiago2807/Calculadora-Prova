using Xunit.Sdk;

namespace CalculatorService.Tests;

public class DivisaoTest
{
    private readonly CalculadoraService calc = new CalculadoraService();

    #region Esperados
    [Fact]
    public void TestarDivisaoComNaN()
    {
        // Arrange
        double a = 2.0;
        double b = double.NaN;

        // Act
        double resultado = calc.Divisao(a, b);

        // Assert
        Assert.True(double.IsNaN(resultado));
    }

    [Fact]
    public void TestarPositivoNegativo()
    {
        double num01 = 4, num02 = -2;

        Assert.True(calc.Divisao(num01, num02).Equals(-2));
    }

    [Fact]
    public void TestarNegativos()
    {
        double num01 = -10, num02 = -2;

        Assert.True(calc.Divisao(num01, num02).Equals(5));
    }


    #region O Dia!
    /* DIVIDIR POR ZERO :) SERÁ?? */
    /* O grande dia que aconteceu a divisão por zero =) */
    [Fact]
    public void TestarDividirZero()
    {
        int joaoOGrande = 0, grandeMagoOInferior = 0;

        Assert.True(double.IsNaN(calc.Divisao(joaoOGrande, grandeMagoOInferior)));
    }
    #endregion


    #endregion
}

public class MultiplicacaoTest
{
    private readonly CalculadoraService calc = new CalculadoraService();

    #region Esperados

    [Fact]
    public void TestarMultPositivo()
    {
        int num1 = 8, num2 = 9;
        int response = calc.Multiplicacao(num1, num2);

        Assert.Equal(response, 72);
    }

    [Fact]
    public void TestarMultPositivoNegativo()
    {
        int num01 = 8, num02 = -9;

        int response = calc.Multiplicacao(num02, num01);

        Assert.True(response.Equals(-72));
    }

    [Fact]
    public void TestarNegativo()
    {
        int num01 = -10, num02 = -4;

        int response = calc.Multiplicacao(num01, num02);

        Assert.True(response.Equals(40));
    }

    #endregion
}

public class SomaTests
{
    private readonly CalculadoraService calc = new CalculadoraService();

    #region Esperados
    [Fact]
    public void TestarSomaComMaiorNumero()
    {
        int a = int.MaxValue;
        int b = 1;

        Assert.Throws<OverflowException>(() => calc.Soma(a, b));
    }

    [Fact]
    public void TestarSomaDoisNumeros()
    {
        int a = 2, b = 3;

        int resultado = calc.Soma(a, b);

        Assert.Equal(resultado, 5);
        Assert.False(double.IsNaN(resultado));
    }

    [Fact]
    public void TestarSomarPositivoNegativo()
    {
        int a = 2, b = -1;

        int resultado = calc.Soma(a, b);

        Assert.Equal(resultado, 1);
        Assert.False(double.IsNaN(resultado));
    }

    [Fact]
    public void TestarValorNegativo()
    {
        int a = -10, b = -1;

        int resultado = calc.Soma(a, b);

        Assert.Equal(resultado, (a + b));
        Assert.False(double.IsNaN(resultado));
    }
    #endregion

    #region Não Esperados

    

    #endregion
}

public class SubtracaoTest
{
    private readonly CalculadoraService calc = new CalculadoraService();

    #region Esperados
    [Fact]
    public void TestarSubtracaoPositivo()
    {
        int a = 5, b = 2;

        int resultado = calc.Subtracao(a, b);

        Assert.Equal(resultado, 3);
        Assert.False(double.IsNaN(resultado));
    }

    [Fact]
    public void TestarSubtrairPositivoNegativo()
    {
        int a = 5, b = -2;

        int resultado = calc.Subtracao(a, b);

        Assert.Equal(resultado, 7);
        Assert.NotNull(resultado);
    }

    [Fact]
    public void TestarValorNegativo()
    {
        int a = -5, b = -2;

        int resultado = calc.Subtracao(a, b);

        Assert.Equal(resultado, -3);
        Assert.NotNull(resultado);
    }
    #endregion
}

public class MediaTest
{
    private readonly CalculadoraService calc = new CalculadoraService();

    #region Esperados
    [Fact]
    public void TestarMediaDois()
    {
        double nota01 = 4, nota02 = 10;

        double response = calc.Media(nota01, nota02);

        Assert.True(response.Equals(7));
    }

    [Fact]
    public void TestarMediaPositivoNegativo()
    {
        double money01 = 20, money02 = -10;

        double gastos = calc.Media(money01, money02);

        Assert.True(gastos.Equals(5));
    }

    [Fact]
    public void TestarNumerosReais()
    {
        double num01 = 2.3, num02 = 5.7, num03 = 8.0;

        double response = calc.Mediana(num01, num02, num03);

        Assert.True(response.Equals(5.7));
    }
    #endregion
}