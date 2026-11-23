// List <int> ints=new List<int>(){1,2,3,4};
// int sum=0;
// foreach (var item in ints)
// {
//   sum+=item;
// }
// Console.WriteLine(sum);

// List<string> strings =new List<string>(){"Apple", "kiwi", "olu"};
// strings.Sort((x, y) => y.Length.CompareTo(x.Length));
// foreach (var item in strings)
// {
//     Console.WriteLine(item);
// }
// Person person1=new Person();
// {
//     person1.Name="Qrbon";
//     person1.Age=18;

// }
// Person person2=new Person();
// {
//     person2.Name="Ahmad";
//     person2.Age=13;

// }
// Person person3=new Person();
// {
//     person3.Name="Daler";
//     person3.Age=16;

// }
// List<Person> persons=new List<Person>(){person1, person2, person3};
// var orderedPersons = persons.OrderBy(p => p.Age);
// foreach (var item in orderedPersons)
// {
//     Console.WriteLine(item.Name +" " + item.Age);
// }

// List<int> ints = new List<int>(){1,2,3,4,5,6,7,8};
// foreach (var item in ints)
// {
//     if(item%2!=0) ints.Remove(item);
//     else Console.WriteLine(item+" ");
// }

// List <string> strings =new List<string>(){"qrbon", };
// foreach (var item in strings)
// {
//     Console.WriteLine(item.ToUpper());
// }

// List <int> strings =new List<int>(){1};
// int max=int.MinValue;
// int min=int.MaxValue;
// foreach (var item in strings)
// {
//     if (item>max) max=item;
//     if (item<min) min=item;
// }
// System.Console.WriteLine(max);
// System.Console.WriteLine(min);


// List<string> strings =new List<string>(){"qrbon"};
// foreach (var str in strings)
// {
//     if (str.ToUpper().Distinct().Count() == str.Length) System.Console.WriteLine(str);
// }


