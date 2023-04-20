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

ElefantAnimal elefantAnimal = new ElefantAnimal("Тима");
bool full = elefantAnimal.IsSatisfied;
elefantAnimal.GetEat("фрукты");
elefantAnimal.DoSound();
full = elefantAnimal.IsSatisfied;
elefantAnimal.Play();
Console.WriteLine(full);

TigerAnimal tigerAnimal = new TigerAnimal("Матильда");
tigerAnimal.GetEat("мясо");
tigerAnimal.DoSound();
full = tigerAnimal.IsSatisfied;
tigerAnimal.Play();
Console.WriteLine(full);

SeagullAnimal seagullAnimal = new SeagullAnimal("Иля");
seagullAnimal.GetEat("рыба");
seagullAnimal.DoSound();
full = seagullAnimal.IsSatisfied;
seagullAnimal.Play();
seagullAnimal.PlayWithRelatives("птенцы");
Console.WriteLine(full);

SlothAnimal slothAnimal = new SlothAnimal("Сёма");
slothAnimal.GetEat("фрукты");
slothAnimal.DoSound();
full = slothAnimal.IsSatisfied;
slothAnimal.Play();
slothAnimal.PlayWithRelatives("детеныш");
Console.WriteLine(full);

GoatAnimal goatAnimal = new GoatAnimal("Репка");
goatAnimal.GetEat("растения");
goatAnimal.DoSound();
full = goatAnimal.IsSatisfied;
goatAnimal.Play();
goatAnimal.PlayWithRelatives("козлята");
Console.WriteLine(full);

PenguinAnimal penguinAnimal = new("Петя");
penguinAnimal.GetEat("мясо");
penguinAnimal.DoSound();
full = penguinAnimal.IsSatisfied;
penguinAnimal.Play();
Console.WriteLine(full);
Console.Read();