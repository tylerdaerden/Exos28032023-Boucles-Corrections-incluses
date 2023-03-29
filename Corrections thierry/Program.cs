#region La suite de fibonacci
{
    //long premier = 0;
    //long second = 1;

    //Console.WriteLine(premier);
    //Console.WriteLine(second);

    //for (long i = 0, addition; i < 73; i++, premier = second, second = addition)
    //{
    //    Console.WriteLine(addition = premier + second);
    //}

    //Console.WriteLine("98 boucles");
    //Console.ReadLine();

    ////Attention les performances pour les 25 premiers nombre 392808 (Exponentiel!!!!)
    //for (long i = 1; i < 75; i++)
    //{
    //    Console.WriteLine(Fibonnaci(i));
    //}
    //Console.WriteLine(count);
}
#endregion

#region Factoriel
{
    //int nombre;

    //do
    //{
    //    Console.Write("Entrez un nombre entre 1 et 20 : ");
    //} while (!int.TryParse(Console.ReadLine(), out nombre) || nombre < 1 || nombre > 20);

    //long factoriel = nombre;
    //for (int multiplicateur = nombre - 1; multiplicateur > 1; multiplicateur--)
    //{
    //    factoriel *= multiplicateur;
    //}

    //Console.WriteLine($"Factoriel de {nombre} est {factoriel}");
}
#endregion

#region X premiers nombre premier
{
    //int nombre;

    //do
    //{
    //    Console.Write("Entrez un nombre entier : ");
    //} while (!int.TryParse(Console.ReadLine(), out nombre));

    ////2 est le premier nombre premier
    //for (int count = 0, valeur = 2; count < nombre; valeur++)
    //{
    //    bool estPremier = true;
    //    int racine = (int)Math.Sqrt(valeur);

    //    for (int diviseur = 2; diviseur <= racine && estPremier; diviseur++)
    //    {
    //        if (valeur % diviseur == 0)
    //            estPremier = false;
    //    }

    //    if (estPremier)
    //    {
    //        Console.WriteLine($"{valeur} est un nombre premier!");
    //        count++;
    //    }
    //}
}
#endregion

#region Table de multiplication
{
    //for (int ligne = 1; ligne < 21; ligne++)
    //{
    //    for (int col = 1; col < 6; col++)
    //    {
    //        Console.Write($" {ligne:D3} x {col:D3} = {ligne * col:D3} |");
    //    }
    //    Console.WriteLine();
    //}
}
#endregion

#region Explication du double
{
    //double, float utilise le pricipe de calcul à virgule flottante
    //for (double d = 0D; d < 20D; d += .1)
    //{
    //    Console.WriteLine(d);
    //}

    //for (decimal d = 0M; d < 20M; d += .1M)
    //{
    //    Console.WriteLine(d);
    //}

    //for (int i = 1; i < 51; i++)
    //{
    //    Console.WriteLine(Math.Pow(2, -i));
    //}
}
#endregion

#region Racine carée
{
    //decimal error = decimal.Zero;
    //decimal nombre = (decimal)Math.PI;

    //decimal Xn = nombre;
    //decimal RC = nombre;
    //decimal pas = nombre;

    //while (pas > error)
    //{
    //    RC = 0.5M * (RC + (nombre / RC));
    //    pas = (Xn - RC) / Xn;
    //    Xn = RC;

    //    Console.WriteLine($"pas={pas} Racine={RC}");
    //}

    //Console.WriteLine($"la racine carrée de {nombre} est : {RC}");
}
            #endregion         
        
