/* See https://aka.ms/new-console-template for more information
ARELY MARTINEZ 
OCT 19 9:42 PM 
THE PROGRAM WILL ASK THE USER WHAT THEY FEEL LIKE HAVING THEY 
WILL ENTER 1 2 OR 3 DEPENDING ON WHAT THEY WANT. IF THEY DONT 
TYPE IN A NUMBER (HAS TO BE 1, 2, OR 3 ASWELL). THE USER WILL 
BE ASKED UNTIL THEY ENTER A VAILD OPTION. A RANDOMIZER WILL 
GENERATE A NUMBER AND THE RESTUARNT WILL BE DISPLAY. AT THE 
END OF THE PROGAM THE USER WILL HAVE THE OPTION TO PLAY AGAIN
BY ENTERING IN YES AND VISE VERSA FOR NO. IF THEY DONT TYPE ANY 
VARIATION OF YES OR NO THEY WILL BE ASK OVER AGIN UNTIL THEY DO.

PEER REVIEW: NAME -- REVIEW
*/

Console.WriteLine("Hello, World!");
Console.Clear();
bool playAgain = true;
while (playAgain) {
    Console.WriteLine("LETS PICK A RESTUARNT FOR YOU ");
    Console.WriteLine(" ");
    Console.WriteLine("WHAT DO YOU FEEL LIKE HAVING? ");
    Console.WriteLine(" ");

    bool isConverted = true;
    bool isNumber; 
    int vaildNum = 0;
        
    while (isConverted){
        Console.WriteLine("ENTER '1' FOR MEXICAN " );
        Console.WriteLine("ENTER '2' FOR CHINESE " );
        Console.WriteLine("ENTER '3' FOR ITALIAN " );
        String userInput = Console.ReadLine();

        isNumber = Int32.TryParse(userInput, out vaildNum);

        if(isNumber == true && vaildNum == 1 || vaildNum == 2 || vaildNum == 3) {
            isConverted = false;
            Console.WriteLine(" ");
            Console.WriteLine("* YOU ENTERED A VAILD RESPONSE ");
            Console.WriteLine(" ");
        } else {
            Console.WriteLine( " " );
            Console.WriteLine("* INVAILD ENTRY, TRY AGAIN!!! ");
            Console.WriteLine(" ");
        }
    }
    switch (vaildNum) {
        case 1:
            Console.WriteLine("* YOU CHOSE MEXICAN FOOD!!");
            Console.WriteLine("");
            Console.Write("* LETS EAT AT - ");
            Random ranNum = new Random();
            int numbers = ranNum.Next(1, 10);
            if(numbers == 1){
                Console.WriteLine("LA COSTA");
            }if(numbers == 2){
                Console.WriteLine("LA ESTELLA");
            } if(numbers == 3){
                Console.WriteLine("TAQUERIA LA MEXICANA");
            } if(numbers == 4){
                Console.WriteLine("EL TORITO");
            } if(numbers == 5){
                Console.WriteLine("TACOS LA POTRANCA");
            }if(numbers == 6){
                Console.WriteLine("TAQUERIA LAS COMADRES");
            }if(numbers == 7){
                Console.WriteLine("LA DONA ");
            } if(numbers == 8){
                Console.WriteLine("MARISCOS LA COSTA");
            } if(numbers == 9){
                Console.WriteLine("RUBIO'S COSTAL GRILL");
            } if(numbers == 10){
                Console.WriteLine("LOS PRIMOS TEX MEX FOOD");
            }
        break;

        case 2:
            Console.WriteLine("* YOU CHOSE CHINESE FOOD!!");
            Console.WriteLine("");
            Console.Write("* LETS EAT AT - ");
            Random ranNum2 = new Random();
            int numbers2 = ranNum2.Next(1, 10);
            if(numbers2 == 1){
                Console.WriteLine("PANDA EXPRESS");
            }if(numbers2 == 2){
                Console.WriteLine("AMAZING KITCHEN");
            } if(numbers2 == 3){
                Console.WriteLine("CHINA WORK");
            } if(numbers2 == 4){
                Console.WriteLine("NEW KING BUFFET");
            } if(numbers2 == 5){
                Console.WriteLine("FORTUNE GARDEN CHINESE");
            }if(numbers2 == 6){
                Console.WriteLine("MEI MEI CHINESE FOOD ");
            }if(numbers2 == 7){
                Console.WriteLine("GOLDEN EAGLE RESTAURANT");
            } if(numbers2 == 8){
                Console.WriteLine("GOLDEN BOWL RESTAURANT");
            } if(numbers2 == 9){
                Console.WriteLine("MIDORI FINE ASAIN CUISINE");
            } if(numbers2 == 10){
                Console.WriteLine("NEW CHINA RESTAURANT");
            }
        break;

        case 3:
            Console.WriteLine("* YOU CHOSE ITALIAN FOOD!!");
            Console.WriteLine("");
            Console.Write("* LETS EAT AT - ");
            Random ranNum3 = new Random();
            int numbers3 = ranNum3.Next(1, 10);
            if(numbers3 == 1){
                Console.WriteLine("OLIVE GARDEN");
            }if(numbers3 == 2){
                Console.WriteLine("ROMANO'S MACARONI GRILL");
            } if(numbers3 == 3){
                Console.WriteLine("LOCANDO WINE BAR");
            } if(numbers3 == 4){
                Console.WriteLine("RUSTY'S");
            } if(numbers3 == 5){
                Console.WriteLine("BLAZE PIZZA");
            }if(numbers3 == 6){
                Console.WriteLine("PADELLA ITALIANA");
            }if(numbers3 == 7){
                Console.WriteLine("M & J BRISTO");
            } if(numbers3 == 8){
                Console.WriteLine("MOD PIZZA");
            } if(numbers3 == 9){
                Console.WriteLine("LOCANDO RAVELLO");
            } if(numbers3 == 10){
                Console.WriteLine("CHIANTI'S");
            }
        break;
    }
    Console.WriteLine(" ");
    bool converted = true;
    while (converted){
        Console.WriteLine("WOULD YOU LIKE TO PLAY AGAIN? YES OR NO? ");
        string rePlay = Console.ReadLine().ToUpper();

        if(rePlay == "YES"){
            playAgain = true;
            converted = false;
            Console.Clear();
            Console.WriteLine( "LETS PLAY AGAIN!!" );
            Console.WriteLine( " " );
            break;
        } 
        if(rePlay == "NO" ){
            playAgain = false;
            converted = false;
            Console.WriteLine(" ");
            Console.WriteLine( "THANK YOU FOR PLAYING!!! " );
            break;
        }
        else{
            converted = true;
            Console.WriteLine(" ");
            Console.WriteLine( "INVAILD RESPONSE TRY AGAIN!!" );
            Console.WriteLine(" ");
        }
    } 
}