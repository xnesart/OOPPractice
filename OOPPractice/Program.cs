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

//
ElefantAnimal elefantAnimal = new ElefantAnimal("Миша");
elefantAnimal.GetEat("фрукты");
// elefantAnimal.DoSpecialAction("ходить");


 Aviary aviaryDesertHerbivore = new Aviary("пустынные животные","пустыня",100, false);
 aviaryDesertHerbivore.AddAnimalInAviary(new ElefantAnimal("Куро"));
 aviaryDesertHerbivore.AddAnimalInAviary(new ElefantAnimal("Тимоша"));
 aviaryDesertHerbivore.AddAnimalInAviary(new TigerAnimal("Пима"));
 aviaryDesertHerbivore.ShowAnimals();
 aviaryDesertHerbivore.CheckAnimalSatisfied(); 
 aviaryDesertHerbivore.AnimalsFeedInAviary("фрукты");
 aviaryDesertHerbivore.CheckAnimalSatisfied();
 aviaryDesertHerbivore.AnimalsDoSound();
 aviaryDesertHerbivore.DoAction("Тимоша", "ходить");


 
 
 Aviary aviaryJunglePredators = new Aviary("тропический вольер","джунгли",100, true);
 aviaryJunglePredators.AddAnimalInAviary(new TigerAnimal("Пима"));
 aviaryJunglePredators.AddAnimalInAviary(new TigerAnimal("Сима"));
 aviaryJunglePredators.ShowAnimals();
 aviaryJunglePredators.CheckAnimalSatisfied(); 
 aviaryJunglePredators.AnimalsFeedInAviary("мясо");
 aviaryJunglePredators.CheckAnimalSatisfied();
 aviaryJunglePredators.AnimalsDoSound();
 
 Aviary aviaryJungleHerbivore = new Aviary("тропический вольер","джунгли",100, false);
 aviaryJungleHerbivore.AddAnimalInAviary(new SlothAnimal("Ленивц"));
 aviaryJungleHerbivore.AddAnimalInAviary(new SlothAnimal("Семён"));
 aviaryJungleHerbivore.AddAnimalInAviary(new GoatAnimal("Козовская"));
 aviaryJungleHerbivore.ShowAnimals();
 aviaryJungleHerbivore.CheckAnimalSatisfied(); 
 aviaryJungleHerbivore.AnimalsFeedInAviary("фрукты");
 aviaryJungleHerbivore.CheckAnimalSatisfied();
 aviaryJungleHerbivore.AnimalsDoSound();
 
 
 Aviary aviaryGlacier = new Aviary("холодный вольер", "ледник", 100, true);
 aviaryGlacier.AddAnimalInAviary(new SeagullAnimal("Чайковская"));
 aviaryGlacier.AddAnimalInAviary(new SeagullAnimal("Чайковская2"));
 aviaryGlacier.AddAnimalInAviary(new SeagullAnimal("Чайковская3"));
 aviaryGlacier.AddAnimalInAviary(new SeagullAnimal("Чайковская4"));
 aviaryGlacier.AddAnimalInAviary(new SeagullAnimal("Чайковская5"));
 aviaryGlacier.AddAnimalInAviary(new SeagullAnimal("Чайковская6"));
 
 aviaryGlacier.AddAnimalInAviary(new PenguinAnimal("Пингивнский"));
 aviaryGlacier.ShowAnimals();
 aviaryGlacier.CheckAnimalSatisfied();
 aviaryGlacier.AnimalsFeedInAviary("рыба и мясо");
 aviaryGlacier.ShowFreeSquare();
 aviaryGlacier.RemoveAnimalInAviary("Чайковская", "чайка");
 aviaryGlacier.ShowFreeSquare();


Console.Read();