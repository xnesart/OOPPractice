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


Aviary aviaryDesertHerbivore = new Aviary("пустынные животные","пустыня","20 квадратных метров", false);
aviaryDesertHerbivore.AddAnimalInAviary(new ElefantAnimal("Куро"));
aviaryDesertHerbivore.AddAnimalInAviary(new ElefantAnimal("Тимоша"));
aviaryDesertHerbivore.AddAnimalInAviary(new TigerAnimal("Пима"));
aviaryDesertHerbivore.ShowAnimals();
aviaryDesertHerbivore.CheckAnimalSatisfied(); 
aviaryDesertHerbivore.AnimalsFeedInAviary("фрукты");
aviaryDesertHerbivore.CheckAnimalSatisfied();
aviaryDesertHerbivore.AnimalsDoSound();

Aviary aviaryJunglePredators = new Aviary("тропический вольер","джунгли","20 квадратных метров", true);
aviaryJunglePredators.AddAnimalInAviary(new TigerAnimal("Пима"));
aviaryJunglePredators.AddAnimalInAviary(new TigerAnimal("Сима"));
aviaryJunglePredators.ShowAnimals();
aviaryJunglePredators.CheckAnimalSatisfied(); 
aviaryJunglePredators.AnimalsFeedInAviary("мясо");
aviaryJunglePredators.CheckAnimalSatisfied();
aviaryJunglePredators.AnimalsDoSound();

Aviary aviaryJungleHerbivore = new Aviary("тропический вольер","джунгли","20 квадратных метров", false);
aviaryJungleHerbivore.AddAnimalInAviary(new SlothAnimal("Ленивц"));
aviaryJungleHerbivore.AddAnimalInAviary(new SlothAnimal("Семён"));
aviaryJungleHerbivore.AddAnimalInAviary(new GoatAnimal("Козовская"));
aviaryJungleHerbivore.ShowAnimals();
aviaryJungleHerbivore.CheckAnimalSatisfied(); 
aviaryJungleHerbivore.AnimalsFeedInAviary("фрукты");
aviaryJungleHerbivore.CheckAnimalSatisfied();
aviaryJungleHerbivore.AnimalsDoSound();


Aviary aviaryGlacier = new Aviary("холодный вольер", "ледник", "20 квадратных метров", true);
aviaryGlacier.AddAnimalInAviary(new SeagullAnimal("Чайковская"));
aviaryGlacier.AddAnimalInAviary(new PenguinAnimal("Пингивнский"));
aviaryGlacier.ShowAnimals();
aviaryGlacier.CheckAnimalSatisfied();
aviaryGlacier.AnimalsFeedInAviary("рыба и мясо");


Console.Read();