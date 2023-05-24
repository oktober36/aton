using Aton.classes;

const int maxLength = 100;
const int minLength = 20;


var t = new Train(minLength, maxLength);
var answer = Solver.Solve(t);

Console.WriteLine("Посчитанное кол-во вагонов: {0}, реальное: {1}", answer, t.GetWagonsCount());