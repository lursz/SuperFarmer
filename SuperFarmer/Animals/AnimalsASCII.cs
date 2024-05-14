namespace SuperFarmer.Animals;

public static class AnimalsASCII
{
 public static string Rabbit => """
                                
                                  //
                                 ('>
                                 /rr
                                *\))_
                                """;

 public static string Pig => """
                              <`--'\>______
                              /. .  `'     \
                             (`')  ,        @
                              `-._,        /
                                 )-)_/--( >
                             """;

 public static string Sheep => """
                                n__n
                               /U  U\\.@@@@`.
                               \\__/(@@@@@@@@)-@
                                     (@@@@@@)
                                      ||  ||
                               """;

 public static string Cow => """
                                      __n__n__
                               .------`-\00/-'
                              /  ##  ## (oo)
                             / \## __   ./
                                |//YY \|/
                             """;

 public static string Horse => """
                                           .''
                                 ._.-.___.' (`\
                                //(        ( `'
                               '/ )\ ).__. )
                               ' <' `\ ._/'\
                                  `   \     \
                               """;

 public static string Dog => """
                                       __
                              \ ______/ V`-,
                               }        /~~
                              /_)^ --,r'
                             |b      |b
                             """;

 public static string Hound => """
                                            .--~~,__
                               :-....,-------`~~'._.'
                                `-,,,  ,_      ;'~U'
                                 _,-' ,'`-__; '--.
                                (_/'~~      ''''(;
                               """;

 public static string Fox => """
                             _,-=._              /|_/|
                             `-.}   `=._,.-=-._.,  @ @._,
                                `._ _,-.   )      _,.-'
                                   `    G.m-"^m`m'
                             """;

 public static string Wolf => """
                                         :               :
                                         :      _/|      :
                                          :   =/_/      :
                                           `._/ |     .'
                                        (   /  ,|...-'
                                         \_/^\/||__
""";

 public static string exchangeRates => """
                                       EXCHANGE RATES:
                                       
                                       1 Rabbit = 1 Rabbit

                                       1 Sheep = 6 Rabbits

                                       1 Pig = 2 Sheep

                                       1 Cow = 3 Pigs

                                       1 Horse = 2 Cows

                                       1 Dog = 1 Sheep

                                       1 Hound = 1 Cow
                                       """;
 
 public static string GetAnimalASCII(Animal animal)
 {
     switch (animal)
     {
         case Animal.Rabbit:
             return Rabbit;
         case Animal.Pig:
             return Pig;
         case Animal.Sheep:
             return Sheep;
         case Animal.Cow:
             return Cow;
         case Animal.Horse:
             return Horse;
         case Animal.Dog:
             return Dog;
         case Animal.Hound:
             return Hound;
         default:
             return "";
     }
 }

 public static Animal stringToAnimal(string animal)
 {
     animal = animal.ToLower();
     switch (animal)
     {
         case "rabbit":
             return Animal.Rabbit;
         case "pig":
             return Animal.Pig;
         case "sheep":
             return Animal.Sheep;
         case "cow":
             return Animal.Cow;
         case "horse":
             return Animal.Horse;
         case "dog":
             return Animal.Dog;
         case "hound":
             return Animal.Hound;
         default:
             return Animal.Rabbit;
     }
 }
}