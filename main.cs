using System;

class MainClass {

  public static void Main (string[] args) {
    Exercicio01();
    Exercicio02();
    Exercicio03();
  }

  // Exercicio 1
  public static void Exercicio01(){
    Console.Write("Primeiro numero: ");
    float numero1 = float.Parse( Console.ReadLine() );
    Console.Write("Informe segundo numero: ");
    float numero2 = float.Parse( Console.ReadLine() );
    Console.WriteLine(" + Soma");
    Console.WriteLine(" - Subtração");
    Console.WriteLine(" * Multiplicação");
    Console.WriteLine(" / Divisão");
    Console.Write("Operação: ");
    char operacao = char.Parse( Console.ReadLine() );
  
    switch( operacao ){
      case '+':
        Console.WriteLine( "Soma: {0}", numero1 + numero2 );
      break;
      case '-':
        Console.WriteLine( "Subtração: {0}", numero1 - numero2 );
      break;
      case '*':
        Console.WriteLine( "Multiplicação: {0}", numero1 * numero2 );
      break;
      case '/':
        Console.WriteLine( "Divisão: {0}", numero1 / numero2 );
      break;
      default:
        Console.WriteLine( "Caracter invalido !" );
      break; 
    }
  }

  //Exercicio 2
  public static void Exercicio02(){
    Console.WriteLine("---------------------------------");
    Console.WriteLine("100   Cachorro quente   R$ 1,70 ");
    Console.WriteLine("101   Bauru Simples     R$ 2,30 ");
    Console.WriteLine("102   Bauru com ovo     R$ 2,60 ");
    Console.WriteLine("103   Hamburguer        R$ 2,40 ");
    Console.WriteLine("104   Cheeseburguer     R$ 2,50 ");
    Console.WriteLine("105   Refrigerante      R$ 1,00 ");
    Console.WriteLine("----------------------------------");
    Console.Write("Informe o Codigo do Produto: ");
    int codigo_item = int.Parse( Console.ReadLine() );
    Console.Write("Informe a quantidade: ");
    int qtd = int.Parse( Console.ReadLine() );
    if( codigo_item == 100 ){
      Console.WriteLine( "Total do Item: {0}", 1.70 * qtd );
    }
    if( codigo_item == 101){
      Console.WriteLine( "Total do Item: {0}", 2.30 * qtd );
    }
    if( codigo_item == 102){
      Console.WriteLine( "Total do Item: {0}", 2.60 * qtd );
    }
    if( codigo_item == 103){
      Console.WriteLine( "Total do Item: {0}", 2.40 * qtd );
    }
    if( codigo_item == 104){
      Console.WriteLine( "Total do Item: {0}", 2.50 * qtd );
    }
    if( codigo_item == 105){
      Console.WriteLine( "Total do Item: {0}", 1.00 * qtd );
    }
  }


  //Exercicio 3
  public static void Exercicio03(){
    int votar;
    int vt33 = 0;
    int vt25 = 0;
    int vt10 = 0;
    int branco  = 0;
    int nulo = 0;
    do{
      Console.WriteLine("##### VOTAÇÂO #####");
      Console.WriteLine("33 - José Couve");
      Console.WriteLine("25 - Joana Bravo");
      Console.WriteLine("10 - Roberto Nove");
      Console.WriteLine("0  - Voto Branco");
      Console.WriteLine("4  - Voto Nulo");
      Console.WriteLine("-1 = Acaba Votação");
      Console.Write("Qual seu voto: ");
      votar = int.Parse( Console.ReadLine() );
      if( votar == 33 ){
        vt33 += 1;
      }else if( votar == 25 ){
        vt25 += 1;
      }else if( votar == 10 ){
        vt10 += 1;
      }else if( votar == 0 ){
        branco += 1;
      }else if( votar == 4 ){
        nulo += 1;
      }else if( votar == -1 ){
        Console.WriteLine("\nVotação Encerrada!");
        Console.WriteLine("Computando os Votos!\n");
      }
    }while(votar != -1); 
    if( (vt33 > vt25) && ( vt33 > vt10 ) ){
      Console.WriteLine("Jose Couve Ganhou com {0} votos!", vt33);
    }else if( vt25 > vt10 ){
      Console.WriteLine("Joana Bravo Ganhou com {0} votos!", vt25);
    }else{
      Console.WriteLine("Roberto Nove Ganhou com {0} votos!", vt10);
    }
    Console.WriteLine("Votos em Branco: {0}", branco);
    Console.WriteLine("Votos em Nulos: {0}", nulo);

  }

}