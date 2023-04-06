using OOPPractice.Classes;

// Название вида (Слон, Пингвин, Тигр)
// Необходимый биом (Тропики, Тундра, Пустыня)
// Необходимая площадь на особь (10 м^2)
// Что кушает (Рыба, Мясо, Сено) - Один тип животного может питаться несколькими продуктами
// Хищник или травоядное - Отдельный параметр выделен для дальнейшего удобства
// Издаваемый звук (Ауф, Хрю, Рррр)
// Функционал животного (пока достаточно условно обозначить действие выводом в консоль):
// Есть
// Издать звук
// Играть

Elefant elefant = new Elefant("Тима", "пустыня", "слон", "10 квадратных метров");
bool full = elefant.IsSatisfied;
elefant.GetEat("фрукты");
elefant.DoSound();
full = elefant.IsSatisfied;
elefant.Play();
Console.WriteLine(full);

Tiger tiger = new Tiger("Матильда", "тропики", "тигр", "10 квадратных метров");
tiger.GetEat("мясо");
tiger.DoSound();
full = tiger.IsSatisfied;
tiger.Play();
Console.WriteLine(full);

Penguin penguin = new("Петя", "тундра", "пингвин", "10 квадратных метров");
penguin.GetEat("мясо");
penguin.DoSound();
full = penguin.IsSatisfied;
penguin.Play();
Console.WriteLine(full);
Console.Read();