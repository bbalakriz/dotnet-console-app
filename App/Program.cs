// See https://aka.ms/new-console-template for more information
var counter = 0;
var max = 100;
while (max is -1 || counter < max)
{
    Console.WriteLine($"Counter: {++counter}");
    await Task.Delay(TimeSpan.FromMilliseconds(2_000));
}