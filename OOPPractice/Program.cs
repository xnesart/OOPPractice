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

Elefant elefant = new Elefant("Тима");
bool full = elefant.IsSatisfied;
elefant.GetEat("фрукты");
elefant.DoSound();
full = elefant.IsSatisfied;
elefant.Play();
Console.WriteLine(full);

Tiger tiger = new Tiger("Матильда");
tiger.GetEat("мясо");
tiger.DoSound();
full = tiger.IsSatisfied;
tiger.Play();
Console.WriteLine(full);

Penguin penguin = new("Петя");
penguin.GetEat("мясо");
penguin.DoSound();
full = penguin.IsSatisfied;
penguin.Play();
Console.WriteLine(full);
Console.Read();