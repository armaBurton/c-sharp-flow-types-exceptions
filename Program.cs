Animal?[] animals = new Animal?[]{
  new Cat {
    Name = "Karen", 
    Born = new(year: 2022, month: 8, day: 23), 
    Legs = 4, 
    isDomestic = true
  }, 
  null, 
  new Cat {
    Name = "Mufasa",
    Born = new(year: 1994, month: 6, day: 12)
  },
  new Spider {
    Name = "Sid Vicious",
    Born = DateTime.Today,
    isPoisonous = true
  },
  new Spider {
    Name = "Captain Furry",
    Born = DateTime.Today
  }
};

foreach (Animal? animal in animals){
  string message;

  switch (animal){
    case Cat fourLeggedCat when fourLeggedCat.Legs == 4:
      message = $"The cat name {fourLeggedCat.Name} has four legs.";
      break;
    case Cat wildCat when wildCat.isDomestic == false:
      message = $"The non-domestic cat is named {wildCat.Name}";
      break;
    case Cat cat:
      message = $"The cat is named {cat.Name}.";
      break;
    default:
      message = $"The animal named {animal.Name} is a {animal.GetType().Name}.";
      break;
    case Spider spider when spider.isPoisonous:
      message = $"The {spider.Name} spider is poisonous. Run!";
      break;
    case null:
      message = "The animal is null";
      break;
  }
  WriteLine($"switch statement: {message}");
}



















// int a = 3;
// int b = a++;
// WriteLine($"a is {a}, b is {b}");
// WriteLine("\n");

// int c = 3, d = ++c;
// WriteLine($"c is {c}, d is {d}");
// WriteLine("\n");

// int e = 11, f = 3;
// WriteLine($"e is {e}, f is {f}");
// WriteLine($"e + f = {e + f}");
// WriteLine($"e - f = {e - f}");
// WriteLine($"e * f = {e * f}");
// WriteLine($"e / f = {e / f}");
// WriteLine($"e % f = {e % f}");
// WriteLine("\n");

// double g = 11.0;
// WriteLine($"g is {g:N1}, f is {f}");
// WriteLine ($"g / f = {g / f}");
// WriteLine("\n");

// bool a = true, b = false;
// WriteLine($"AND   | a      | b     ");
// WriteLine($"a     | { a & a, -5}  | {a & b, -5}");
// WriteLine($"a     | { b & a, -5}  | {b & b, -5}");
// WriteLine();
// WriteLine($"OR    | a      | b     ");
// WriteLine($"a     | { a & a, -5}  | {a & b, -5}");
// WriteLine($"a     | { b & a, -5}  | {b & b, -5}");
// WriteLine();
// WriteLine($"XOR   | a      | b     ");
// WriteLine($"a     | { a ^ a, -5}  | {a ^ b, -5}");
// WriteLine($"a     | { b ^ a, -5}  | {b ^ b, -5}");
// WriteLine();

// static bool DoStuff(){
//   WriteLine("I am doing stuff.");
//   return true;
// }

// WriteLine();
// WriteLine($"a & DoStuff() = {a & DoStuff()}");
// WriteLine($"b & DoStuff() = {b & DoStuff()}");
// WriteLine();
// WriteLine($"a && DoStuff() = {a && DoStuff()}");
// WriteLine($"b && DoStuff() = {b && DoStuff()}");

// static string ToBinaryString(int value){
//   return Convert.ToString(value, toBase:2).PadLeft(8, '0');
// }

// int a = 10, b = 6;

// WriteLine($"     a = {a}, {ToBinaryString(a)}");
// WriteLine($"     b =  {b}, {ToBinaryString(b)}");
// WriteLine($" a & b =  {a & b}, {ToBinaryString(a & b)}");
// WriteLine($" a | b = {a | b}, {ToBinaryString(a | b)}");
// WriteLine($" a ^ b = {a ^ b}, {ToBinaryString(a ^ b)}");
// WriteLine($"a << 3 = {a << 3}, {ToBinaryString(a << 3)}");
// WriteLine($"b >> 1 =  {b >> 1}, {ToBinaryString(b >> 1)}");

// int age = 50;
// WriteLine($"The {nameof(age)} variable uses {sizeof(int)} bytes of memory");

// object o = "3";
// int j = 4;

// if (o is int i){
//   WriteLine($"{i}, x {j} = {i * j}");
// } else {
//   WriteLine($"o is not an int so it cannot multiply.");
// }

// int randoNumbo = Random.Shared.Next(1, 7);
// WriteLine($"My random number is {randoNumbo}");

// switch(randoNumbo){
//   case 1:
//     WriteLine($"One");
//     break;
//   case 2:
//     WriteLine($"Two");
//     break;
//   case 3:
//   case 4:
//     WriteLine($"Three or Four");
//     goto case 1;
//   case 5:
//     goto A_label;
//   default:
//     WriteLine($"Default");
//     break;  
// }

// WriteLine($"After end of switch");
// A_label:
// WriteLine($"After A_label");