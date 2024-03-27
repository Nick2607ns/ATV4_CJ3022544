// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");


float n1, n2, operador, resul;

Console.WriteLine(" digite 1 para +, digite 2 para -, digite 3 para *, digite 4 para / ");
operador = float.Parse(Console.ReadLine());

switch (operador) {
    case 1:
        Console.WriteLine("de o primeiro numero");
        n1 = float.Parse(Console.ReadLine());
        Console.WriteLine(" de o segundo numero");
        n2 = float.Parse(Console.ReadLine());
        resul = (n1 + n2);
        Console.WriteLine(resul);
        break;

    case 2:
        Console.WriteLine("de o primeiro numero");
        n1 = float.Parse(Console.ReadLine());
        Console.WriteLine(" de o segundo numero");
        n2 = float.Parse(Console.ReadLine());
        resul = (n1 - n2);
        Console.WriteLine("o resultado é", resul);
        break;

    case 3:
        Console.WriteLine("de o primeiro numero");
        n1 = float.Parse(Console.ReadLine());
        Console.WriteLine(" de o segundo numero");
        n2 = float.Parse(Console.ReadLine());
        resul = (n1 * n2);
        Console.WriteLine("o resultado é", resul);
        break;

    case 4:
        Console.WriteLine("de o primeiro numero");
        n1 = float.Parse(Console.ReadLine());
        Console.WriteLine(" de o segundo numero");
        n2 = float.Parse(Console.ReadLine());
        resul = (n1 / n2);
        Console.WriteLine("o resultado é", resul);
        break;




}

// Atividade 1

int dia;

Console.WriteLine(" digite o dia da semana em numero (1 a 7");
dia = int.Parse(Console.ReadLine());

switch (dia)
{
    case 1:

        Console.WriteLine("o dia da semana é domingo");
        break;

    case 2:
        Console.WriteLine(" o dia da semana é segunda");
        break;

    case 3:
        Console.WriteLine(" o dia da semana é terça");
        break;
    case 4:
        Console.WriteLine(" o dia da semana é quarta");
        break;
    case 5:
        Console.WriteLine(" o dia da semana é quinta");
        break;
    case 6:
        Console.WriteLine(" o dia da semana é sexta");
        break;
    case 7:
        Console.WriteLine(" o dia da semana é sabado");
        break;
}

//Atividade 2

float pag, vlr, desc, acres;

Console.WriteLine("digite o valor da compra");
vlr = float.Parse(Console.ReadLine());

Console.WriteLine(" digite 1 para pagamento no dinheiro, 2 no pix, 3 no debito, 4 no credito");
pag = float.Parse(Console.ReadLine());

switch (pag)
{
    case 1:
        desc =((vlr * 0.15f) - vlr);
        Console.WriteLine("o valor da compra com o desconto é,", desc);
        break;

    case 2:
        desc = ((vlr * 0.10f) - vlr);
        Console.WriteLine("o valor da compra com o desconto é,", desc);
        break;

    case 3:
        acres = ((vlr * 0.10f) + vlr);
        Console.WriteLine("o valor da compra com o desconto é,", desc);
        break;

    case 4:

        acres = ((vlr * 0.5f) + vlr);
        Console.WriteLine("o valor da compra com o desconto é,", desc);
        break;
}

// Atividade 3

int mes, ano;

Console.WriteLine("digite o mes em numero (1 a 12)");
mes = int.Parse(Console.ReadLine());

switch (mes)
{
    case 1:
        Console.WriteLine(" o mes é janeiro e tem 31 dias");
        break;
    case 2:
        Console.WriteLine(" o ano é bissexto? 1= sim, 2= não");

        ano = int.Parse(Console.ReadLine());
        if (ano== 1)
        {
            Console.WriteLine("O mes é fevereiro e tem 29 dias");
        }
        else
        {
            Console.WriteLine("O mes é fevereiro e tem 28 dias");
        }
        break;

    case 3:
        Console.WriteLine(" o mes é março e tem 30 dias");
        break;

    case 4:
        Console.WriteLine(" o mes é abril e tem 30 dias");
        break;

    case 5:
        Console.WriteLine(" o mes é maio e tem 31 dias");
        break;

    case 6:
        Console.WriteLine(" o mes é junho e tem 30 dias");
        break;

    case 7:
        Console.WriteLine(" o mes é julho e tem 31 dias");
        break;

    case 8:
        Console.WriteLine(" o mes é agosto e tem 30 dias");
        break;

    case 9:
        Console.WriteLine(" o mes é setembro e tem 31 dias");
        break;

    case 10:
        Console.WriteLine(" o mes é outubro e tem 30 dias");
        break;

    case 11:
        Console.WriteLine(" o mes é novembro e tem 31 dias");
        break;
    case 12:
        Console.WriteLine(" o mes é dezembro e tem 30 dias");
        break;
}



// Exercicio 4

float m1, m2, oper, res;

Console.WriteLine(" digite 1 para +, digite 2 para -, digite 3 para *, digite 4 para /, digite 5 para ^ ");
oper= float.Parse(Console.ReadLine());

switch (oper)
{
    case 1:
        Console.WriteLine("de o primeiro numero");
        m1 = float.Parse(Console.ReadLine());
        Console.WriteLine(" de o segundo numero");
        m2 = float.Parse(Console.ReadLine());
        res = (m1 + m2);
        Console.WriteLine(resul);
        break;

    case 2:
        Console.WriteLine("de o primeiro numero");
        m1 = float.Parse(Console.ReadLine());
        Console.WriteLine(" de o segundo numero");
        m2 = float.Parse(Console.ReadLine());
        res = (m1 - m2);
        Console.WriteLine("o resultado é", res);
        break;

    case 3:
        Console.WriteLine("de o primeiro numero");
        m1= float.Parse(Console.ReadLine());
        Console.WriteLine(" de o segundo numero");
        m2 = float.Parse(Console.ReadLine());
        res = (m1 * m2);
        Console.WriteLine("o resultado é", res);
        break;

    case 4:
        Console.WriteLine("de o primeiro numero");
        m1 = float.Parse(Console.ReadLine());
        Console.WriteLine(" de o segundo numero");
        m2 = float.Parse(Console.ReadLine());
        res= (m1 / m2);
        Console.WriteLine("o resultado é", res);
        break;

    case 5:
        Console.WriteLine("de o primeiro numero");
        m1 = float.Parse(Console.ReadLine());
        Console.WriteLine(" de o segundo numero");
        m2 = float.Parse(Console.ReadLine());
        res = (m1 ^ m2);
        Console.WriteLine("o resultado é", res);
        break;





}

// Atividade 5

float sal, carg, totals;

Console.WriteLine("digite o seu salario atual");
sal = float.Parse(Console.ReadLine());

Console.WriteLine(" para cargo digite 101 para professor, 102 para secretario, 103 para publicitario, 204 para jornalista, 206 mecanico, 301 estagiario, 302 Tecnico de TI");
carg = float.Parse(Console.ReadLine());

switch (carg)
{
    case 101:
       totals = (( sal*0.075f) + sal);
        Console.WriteLine("seu novo salario é {0}", totals);
        Console.WriteLine(" seu antigo salario é {0}", sal);
        break;

    case 102:
        totals = ((sal * 0.097f) + sal);
        Console.WriteLine("seu novo salario é {0}", totals);
        Console.WriteLine(" seu antigo salario é{0}", sal);
        break;

    case 103:
        totals = ((sal * 0.117f) + sal);
        Console.WriteLine("seu novo salario é {0}", totals);
        Console.WriteLine(" seu antigo salario é{0}", sal);
        break;

    case 204:
        totals = ((sal * 0.089f) + sal);
        Console.WriteLine("seu novo salario é {0}", totals);
        Console.WriteLine(" seu antigo salario é{0}", sal);
        break;

    case 206:
        totals = ((sal * 0.1324f) + sal);
        Console.WriteLine("seu novo salario é {0}", totals);
        Console.WriteLine(" seu antigo salario é{0}", sal);
        break;

    case 301:
        totals = ((sal * 0.104f) + sal);
        Console.WriteLine("seu novo salario é {0}", totals);
        Console.WriteLine(" seu antigo salario é{0}", sal);
        break;

    case 302:
        totals = ((sal * 0.146f) + sal);
        Console.WriteLine("seu novo salario é {0}", totals);
        Console.WriteLine(" seu antigo salario é{0}", sal);
        break;

    default:
        totals = ((sal * 0.435f) + sal);
        Console.WriteLine(" seu novo salario é {0}", totals);
        Console.WriteLine("seu antigo salrio é{0}", sal);
        break;
}

// atividade 6

float imp, sm, sl;

Console.WriteLine("Escolha a faixa de renda para efetuarmos o calculo do imposto de renda");
Console.WriteLine("1- até 1903,98 2- R$ 1903,99 á R$ 2826,65 3- R$2826,66 á R$3751,05 4- R$3751,06 á 4664,68 5- Acima de R$ 4664,69");
imp = int.Parse(Console.ReadLine());

switch (imp)
{
    case 1:
        Console.WriteLine("Digite quantos você recebe mensalmente");
        sm = float.Parse(Console.ReadLine());
        if (sm > 1903.98f)
        {
            Console.WriteLine("Seu valor ultrapassa o valor total dessa faixa");
        }
        else
        {
            Console.WriteLine("Isento á imposto de renda");
            Console.WriteLine("Seu salário liquído é de {0}", sm);
        }
        break;

    case 2:
        Console.WriteLine("Digite quantos você recebe mensalmente");
        sm = float.Parse(Console.ReadLine());
        if (sm < 1903.99f || sm > 2826.65f)
        {
            Console.WriteLine("Você não se encaixa nesta faixa ou ultrapassa o valor dessa faixa");
        }
        else
        {
            sl = (sm - (sm * 0.075f));
            Console.WriteLine("Seu salário liquído é de {0} ", sl);

        }
        break;

    case 3:
        Console.WriteLine("Digite quantos você recebe mensalmente ");
        sm = float.Parse(Console.ReadLine());
        if (sm < 2826.66f || sm > 3751.05f)
        {
            Console.WriteLine("Você não se encaixa nesta faixa ou ultrapassa o valor dessa faixa");
        }
        else
        {
            sl = (sm - (sm * 0.15f));
            Console.WriteLine("Seu salário liquído é de {0} ", sl);
        }
        break;

    case 4:
        Console.WriteLine("Digite quantos você recebe mensalmente ");
        sm = float.Parse(Console.ReadLine());
        if (sm < 3751.06f || sm > 4664.68f)
        {
            Console.WriteLine("Você não se encaixa nesta faixa ou ultrapassa o valor dessa faixa");
        }
        else
        {
            sl = (sm - (sm * 0.225f));
            Console.WriteLine("Seu salário liquído é de {0} ", sl);
        }
        break;

    case 5:
        Console.WriteLine("Digite quantos você recebe mensalmente ");
        sm = float.Parse(Console.ReadLine());
        if (sm < 4664.69f)
        {
            Console.WriteLine("Você não se encaixa nesta faixa");
        }
        else
        {
            sl = (sm - (sm * 0.227f));
            Console.WriteLine("Seu salário liquído é de {0} ", sl);

        }
        break;
}