using ObserverPattern;

ClientA clientA = new();
clientA.DoSomething();

Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");

ClientB clientB = new();
clientB.DoSomething();

