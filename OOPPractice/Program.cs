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
Animal elefant = new Animal();
elefant._name = "Петя";
elefant._biome = "Пустыня";
elefant._square = 10*10;
elefant._eat = "сено";
elefant._isPredator = false;
elefant._sound = "Ауф";
string sound = elefant._sound;
string food = elefant._eat;
elefant.GetEat(food);
elefant.DoSound(sound);
elefant.Play();

Animal penguin = new Animal();
penguin._name = "Симба";
penguin._biome = "Тундра";
penguin._square = 10*10;
penguin._eat = "рыба";
penguin._isPredator = true;
penguin._sound = "хрю";
sound = penguin._sound;
food = penguin._eat;
penguin.GetEat(food);
penguin.DoSound(sound);
penguin.Play();

Animal tiger = new Animal();
tiger._name = "Матильда";
tiger._biome = "Тропики";
tiger._square = 10*10;
tiger._eat = "рыба и мясо";
tiger._isPredator = true;
tiger._sound = "рррр";
sound = tiger._sound;
food = tiger._eat;
tiger.GetEat(food);
tiger.DoSound(sound);
tiger.Play();

Console.Read();