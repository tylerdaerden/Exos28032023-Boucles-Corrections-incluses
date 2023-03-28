#region Exos Boucles 28022023 ! 

#region Exercice 1.1  Fibonacci OK ! 
////Calculer les 25 premiers nombres de la suite de Fibonacci
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

//Console.ReadLine();

#endregion

#region Exercice 1.2 Factoriel OK ! 
//Calculer le factoriel d’un nombre entré au clavier.

//Ma version 👇👇👇
//Console.WriteLine("De quel nombre voulez vous calculer la factorielle ?  ");
//long UserChoix = long.Parse(Console.ReadLine()!);
//long factorielle = 1;

//for (long i = 1; i <= UserChoix; i++)
//{
//    factorielle *= i;
//}

//Console.WriteLine($"la Factorielle de {UserChoix} est {factorielle}");

//Console.ReadLine();

#endregion

#region Exercice 1.3 Nombres Premiers  A FINIR Voir soluce Thierry !
//Grâce à une boucle « for », calculez les x premiers nombre premier

//int x;
//do
//{
//    Console.WriteLine("Combien de nombres premiers souhaitez vous trouver ?");
//}
//while (!int.TryParse(Console.ReadLine(), out x));

//Console.WriteLine($"nous allons afficher les {x} premiers nombres premiers ");
//Thread.Sleep(2000); // juste pour le fun de jouer avec l'affichage , j'avoue 🕹
//Console.Clear();
//Thread.Sleep(1000);

//Console.WriteLine($"voici les nombres premiers jusque {x} ");

//for (int count = 0; count <= x; count++)
//{
//    bool estPremier = true;

//    int sqrt = (int)Math.Sqrt(count);

//    for (int diviseur = 2; diviseur <= sqrt && estPremier; diviseur++)
//    {
//        //Console.WriteLine($"count : {count} / diviseur : {diviseur}");
//        if (count % diviseur == 0)
//        {
//            estPremier = false;
//        }
//    }

//    if (estPremier && count > 1)
//    {
//        Console.WriteLine(count);
//    }
//}

//Console.ReadLine();

// méthode trouvée pour voir number is prime or not
//int x ;
//do
//{
//    Console.WriteLine("Quel nombre voulez vous tester?");
//}
//while (!int.TryParse(Console.ReadLine(), out x));

//int a = 0;
//for (int i = 1; i <= x; i++)
//{
//    if (x % i == 0)
//    {
//        a++;
//    }
//}
//if (a == 2)
//{
//    Console.WriteLine("{0} est premier", x);
//}
//else
//{
//    Console.WriteLine("n'est pas premier");
//}
//Console.ReadLine();

//int x;
//do
//{
//    Console.WriteLine("Quel nombre voulez vous tester?");
//}
//while (!int.TryParse(Console.ReadLine(), out x));

//bool EstPremier  = true ;

//for (int CompteBoucle = 0; CompteBoucle < x; CompteBoucle++)
//{
//    for (int Div2 = 2; j < 10; j++)
//    {
//        if ()

//    }

//    CompteBoucle ++;

//}



#endregion

#region Exercice 1.4 Tables multiplication OK !
//A l’aide de boucles « for » afficher les 5 premières tables de multiplication en allant jusque « x20 ».
//1x1 = 1 ; 2x1 = 2; ……
//2x1 = 2; 2x2 = 4; ……

//int tablede = 1;

////Parcours des tables dans 1ere boucle , incrémentation du multiplicateur dans 2ème boucle 
//for (int i = 1; i <= 20; i++)
//{

//    for (int multiplicateur = 1; multiplicateur <= 5; multiplicateur++)
//    {
//        Console.Write($"{tablede} * {multiplicateur} = {tablede * multiplicateur}");
//        Console.Write("     ");

//    }
//    Console.WriteLine();
//    Console.WriteLine();
//    tablede++;
//}

//Console.ReadLine();

#endregion

#region Exercice 1.5 boucle Doubles OK !
//À l’aide d’une boucle « for » comptez de 0, à 20,0 en augmentant de 0,1, en utilisant des doubles, et afficher la valeur à chaque itération.
//Remarquez-vous quelque chose de particulier ?

//for (double i = 00; i <= 20.0; i = i + 0.1)
//{
//    Console.WriteLine(i);
//}
// on arrive pas à 20 et régulièrement on passe de une à 10 décimale

#endregion

#region Exercice 1.6 racine carrée  A FINIR
//Bonus: Calculer la racine carré d’un nombre avec maximum 10 décimales (Math.Sqrt(x) ne peut être utilisée que pour vérifier la réponse),


////Méthode : créer une boucle qui va tester le carré d'un nombre jusqu'à ce que ça matche avec le nombre choisi 

//{ Console.WriteLine("Entrez le nombre dont vous souhaitez la racine carrée");
//    double SquareUser = double.Parse(Console.ReadLine()!);
//    double racinechek = Math.Sqrt(SquareUser);
//    //préshot de l'affichage final 
//    //string racinecheckstring = (Math.Sqrt(SquareUser)).ToString("D10");


//    //je peux faire une double boucle inside ( i=0 , j=0 ; i && j < 0 ; i++ , j++)
//    double carré;
//    for (double i = 0; i < racinechek; i++)
//    {
//        for (double j = 0; j < i; j++)
//        {
//            carré = Math.Pow(i, j);
//            Console.WriteLine(carré);
//        }

//    }
//    Console.WriteLine("sortie de boucle");

//}

////Console.WriteLine(carré.ToString("10D");    

////    for (double carré = 0; carré != SquareUser; carré++)
////    {
////        while (Math.Pow(carré,carré) != SquareUser)
////        {
////            carré = Math.Pow(carré, carré);
////            Console.WriteLine(carré);
////        }            

////    }

////Console.WriteLine("on sort de la boucle");



////Console.WriteLine($"La racine carrée de {SquareUser} est {}");
////string SquareUserfinal = SquareUser.ToString("10D");





#endregion

#endregion