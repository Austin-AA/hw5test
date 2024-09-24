// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Runtime.Intrinsics.Arm;

string s = "Hello World!";
DoReplacement(ref s);
Console.WriteLine(s);

unsafe void DoReplacement(ref string s)
{
    s = s.Replace('H', 'J');
    return;
}
