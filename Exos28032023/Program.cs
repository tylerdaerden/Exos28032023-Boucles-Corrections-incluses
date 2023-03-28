#region Exos Boucles

#region Exercice 1.1  Fibonacci OK ! 
//Calculer les 25 premiers nombres de la suite de Fibonacci
//int nb1 = 0;
//int nb2 = 1;

//Console.WriteLine(nb1);
//Console.WriteLine(nb2);
//for (int i = 0; i < 23; i++) //on s'arrête plus tôt car nous avons les 2 premières valeurs
//{
//    int nbfibo = (nb1 + nb2);
//    Console.WriteLine(nbfibo);
//    nb1 = nb2;
//    nb2 = nbfibo;

//}

#endregion

#region Exercice 1.2 Factoriel OK ! 
//Calculer le factoriel d’un nombre entré au clavier.

//Console.WriteLine("De quel nombre voulez vous calculer la factorielle ?  ");
//int UserChoix = int.Parse(Console.ReadLine());
//int factorielle = 1;

//for (int i = 1 ; i <= UserChoix ; i++)
//{
//    factorielle*= i;
//}

//Console.WriteLine($"la Factorielle de {UserChoix} est {factorielle}");

#endregion

#region Exercice 1.3 Nombres Premiers  A FINIR !
//Grâce à une boucle « for », calculez les x premiers nombre premier

#endregion

#region Exercice 1.4 Tables multiplication OK !
//A l’aide de boucles « for » afficher les 5 premières tables de multiplication en allant jusque « x20 ».
//1x1 = 1 ; 2x1 = 2; ……
//2x1 = 2; 2x2 = 4; ……

//int tablede = 1;

//for (int i = 1; i <= 5; i++)
//{
//    for (int multiplicateur = 1; multiplicateur <= 20; multiplicateur++)
//    {
//        Console.WriteLine($"{tablede} * {multiplicateur} = " + (tablede * multiplicateur));

//    }
//    tablede++;
//}

#endregion

#region Exercice 1.5 boucle Doubles OK !
//À l’aide d’une boucle « for » comptez de 0, à 20,0 en augmentant de 0,1, en utilisant des doubles, et afficher la valeur à chaque itération.
//Remarquez-vous quelque chose de particulier ?

//for (double i = 00; i <=20.0; i=i+0.1)
//{
//    Console.WriteLine(i);
//}
// on arrive pas à 20 et régulièrement on passe de une à 10 décimale

#endregion

#region Exercice 1.6 racine carrée  A FINIR
//Bonus: Calculer la racine carré d’un nombre avec maximum 10 décimales (Math.Sqrt(x) ne peut être utilisée que pour vérifier la réponse),


//Méthode : créer une boucle qui va tester le carré d'un nombre jusqu'à ce que ça matche avec le nombre choisi 

{ Console.WriteLine("Entrez le nombre dont vous souhaitez la racine carrée");
    double SquareUser = double.Parse(Console.ReadLine()!);
    double racinechek = Math.Sqrt(SquareUser);
    //préshot de l'affichage final 
    //string racinecheckstring = (Math.Sqrt(SquareUser)).ToString("D10");


    //je peux faire une double boucle inside ( i=0 , j=0 ; i && j < 0 ; i++ , j++)
    double carré;
    for (double i = 0; i < racinechek; i++)
    {
        for (double j = 0; j < i; j++)
        {
            carré = Math.Pow(i, j);
            Console.WriteLine(carré);
        }

    }
    Console.WriteLine("sortie de boucle");

}

//Console.WriteLine(carré.ToString("10D");    

//    for (double carré = 0; carré != SquareUser; carré++)
//    {
//        while (Math.Pow(carré,carré) != SquareUser)
//        {
//            carré = Math.Pow(carré, carré);
//            Console.WriteLine(carré);
//        }            

//    }

//Console.WriteLine("on sort de la boucle");


    
//Console.WriteLine($"La racine carrée de {SquareUser} est {}");
//string SquareUserfinal = SquareUser.ToString("10D");





#endregion

#endregion