namespace SimuladorDeUniverso2D;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Corpo
{
    // Atributos classe Corpo
    private bool eValido; // Indica se o corpo é válido ou não
    private string nome; // Nome do corpo
    private double massa; // Massa do corpo (em kg)
    private double densidade; // Densidade do corpo (em kg/m³)
    private double posX; // Posição X (em metros)
    private double posY; // Posição Y (em metros)
    private double velX; // Velocidade em X (em m/s)
    private double velY; // Velocidade em Y (em m/s)
    private double forcaX; // Força atuando no eixo X (em N)
    private double forcaY; // Força atuando no eixo Y (em N)


    // Construtor padrão
    public Corpo()
    {
        this.eValido = true;
        this.nome = "";
        this.massa = 0;
        this.densidade = 1;
        this.posX = 0;
        this.posY = 0;
        this.velX = 0;
        this.velY = 0;
        this.forcaX = 0;
        this.forcaY = 0;
    }

    // Construtor sobrecarregado
    public Corpo(string nome, double massa, double posX, double posY, double posZ,
                 double velX, double velY, double velZ, double densidade)
    {
        this.eValido = true;
        this.nome = nome;
        this.massa = massa;
        this.posX = posX;
        this.posY = posY;
        this.velX = velX;
        this.velY = velY;
        this.forcaX = 0;
        this.forcaY = 0;
        this.densidade = densidade;
    }

    // Métodos get e set
    public bool GetValido() => eValido; // Retorna se o corpo é válido
    public void SetValido(bool valor) => eValido = valor; // Define se o corpo é válido

    public string GetNome() => nome; // Retorna o nome do corpo
    public void SetNome(string valor) => nome = valor; // Define o nome do corpo

    public double GetMassa() => massa; // Retorna a massa do corpo
    public void SetMassa(double valor) => massa = valor; // Define a massa do corpo

    public double GetDensidade() => densidade; // Retorna a densidade do corpo
    public void SetDensidade(double valor) => densidade = valor; // Define a densidade do corpo

    public double GetPosX() => posX; // Retorna a posição X do corpo
    public void SetPosX(double valor) => posX = valor; // Define a posição X do corpo

    public double GetPosY() => posY; // Retorna a posição Y do corpo
    public void SetPosY(double valor) => posY = valor; // Define a posição Y do corpo

    public double GetVelX() => velX; // Retorna a velocidade em X
    public void SetVelX(double valor) => velX = valor; // Define a velocidade em X

    public double GetVelY() => velY; // Retorna a velocidade em Y
    public void SetVelY(double valor) => velY = valor; // Define a velocidade em Y

    public double GetForcaX() => forcaX; // Retorna a força no eixo X
    public void SetForcaX(double valor) => forcaX = valor; // Define a força no eixo X

    public double GetForcaY() => forcaY; // Retorna a força no eixo Y
    public void SetForcaY(double valor) => forcaY = valor; // Define a força no eixo Y

    // Método que calcula e retorna o raio com base na densidade e massa
    public double GetRaio()
    {
        double raio = Math.Pow((3 * Math.PI * this.massa) / (4 * this.densidade), 1.0 / 3);
        return raio / 5; // Retorna o raio ajustado conforme a lógica fornecida
    }

    // Método que copia os valores de outro objeto Corpo para o objeto atual
    public void CopiarCorpo(Corpo outro)
    {
        this.nome = outro.GetNome();
        this.massa = outro.GetMassa();
        this.posX = outro.GetPosX();
        this.posY = outro.GetPosY();
        this.velX = outro.GetVelX();
        this.velY = outro.GetVelY();
        this.forcaX = outro.GetForcaX();
        this.forcaY = outro.GetForcaY();
        this.densidade = outro.GetDensidade();
        this.eValido = outro.GetValido();
    }
}

