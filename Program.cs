﻿// int a = 3;
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

static string ToBinaryString(int value){
  return Convert.ToString(value, toBase:2).PadLeft(8, '0');
}

int a = 10, b = 6;

WriteLine($"     a = {a}, {ToBinaryString(a)}");
WriteLine($"     b =  {b}, {ToBinaryString(b)}");
WriteLine($" a & b =  {a & b}, {ToBinaryString(a & b)}");
WriteLine($" a | b = {a | b}, {ToBinaryString(a | b)}");
WriteLine($" a ^ b = {a ^ b}, {ToBinaryString(a ^ b)}");
WriteLine($"a << 3 = {a << 3}, {ToBinaryString(a << 3)}");
WriteLine($"b >> 1 =  {b >> 1}, {ToBinaryString(b >> 1)}");


