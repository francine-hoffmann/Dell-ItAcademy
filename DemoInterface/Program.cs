Pessoa p1 = new Pessoa ("John Doe", 20);
Pessoa p2 = new Pessoa ("Claire fraser", 20);
Pessoa p3 = new Pessoa ("John Doe", 20);
Pessoa p4 = p1;
//IGUALDADE DE REFERENCIA == 

Console.WriteLine(p1 == p4);
Console.WriteLine(p1 == p3);

//igualdade de valor equals
Console.WriteLine(p1.Equals(p4));
Console.WriteLine(p1.Equals(p3));
// gethashcode codigo de ids, sempre que sobrescreve o equals tem que sobreescrevfer o hash
Console.WriteLine(p1.GetHashCode());
Console.WriteLine(p3.GetHashCode());
//apos sobresverver o hash deles , eles devem possuir o mesmo valor
Pessoa other = (Pessoa) p2.Clone();

