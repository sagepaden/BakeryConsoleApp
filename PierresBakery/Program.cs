using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PierresBakery.Models;

namespace PierresBakery
{
  class Program
  {
    static void Main() 
    {
      try 
      {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Title = "ASCII Art";
        string title = @"
        @@@@@@@   @@@  @@@@@@@@  @@@@@@@   @@@@@@@   @@@@@@@@   @@@@@@   
        @@@@@@@@  @@@  @@@@@@@@  @@@@@@@@  @@@@@@@@  @@@@@@@@  @@@@@@@   
        @@!  @@@  @@!  @@!       @@!  @@@  @@!  @@@  @@!       !@@       
        !@!  @!@  !@!  !@!       !@!  @!@  !@!  @!@  !@!       !@!       
        @!@@!@!   !!@  @!!!:!    @!@!!@!   @!@!!@!   @!!!:!    !!@@!!    
        !!@!!!    !!!  !!!!!:    !!@!@!    !!@!@!    !!!!!:     !!@!!!   
        !!:       !!:  !!:       !!: :!!   !!: :!!   !!:            !:!  
        :!:       :!:  :!:       :!:  !:!  :!:  !:!  :!:           !:!   
        :::       :::  ::: ::::  ::   :::  ::   :::  ::: ::::  :::: ::   
        ::        :::  : :: ::   ::   :::  ::   :::  : :: ::   :: : :    
                                                                    
                                                                    
          @@@@@@@    @@@@@@   @@@  @@@  @@@@@@@@  @@@@@@@   @@@ @@@  
          @@@@@@@@  @@@@@@@@  @@@  @@@  @@@@@@@@  @@@@@@@@  @@@ @@@  
          @@!  @@@  @@!  @@@  @@!  !@@  @@!       @@!  @@@  @@! !@@  
          !@   @!@  !@!  @!@  !@!  @!!  !@!       !@!  @!@  !@! @!!  
          @!@!@!@   @!@!@!@!  @!@@!@!   @!!!:!    @!@!!@!    !@!@!   
          !!!@!!!!  !!!@!!!!  !!@!!!    !!!!!:    !!@!@!      @!!!   
          !!:  !!!  !!:  !!!  !!: :!!   !!:       !!: :!!     !!:    
          :!:  !:!  :!:  !:!  :!:  !:!  :!:       :!:  !:!    :!:    
          ::::::::  ::   :::  :::  :::  ::: ::::  ::   :::    :::    
          :: : ::   ::   :::  ::   :::  : :: ::   ::   :::    :::     ";
        
        string consoleBread = @"
           ______                    _     _____   _                
           | ___ \                  | |_  |  ___| | |               
           | |_/ /_ __ ___  __ _  __| (_) |___ \  | |__  _   ___  __
           | ___ \ '__/ _ \/ _` |/ _` |       \ \ | '_ \| | | \ \/ /
           | |_/ / | |  __/ (_| | (_| |_  /\__/ / | |_) | |_| |>  < 
           \____/|_|  \___|\__,_|\__,_(_) \____/  |_.__/ \__,_/_/\_\
                                (Buy 2 Get 1 Free)                       
        ";

        string consolePastry = @"
          ______         _                  _____   _                
          | ___ \       | |             _  / __  \ | |               
          | |_/ /_ _ ___| |_ _ __ _   _(_) `' / /' | |__  _   ___  __
          |  __/ _` / __| __| '__| | | |     / /   | '_ \| | | \ \/ /
          | | | (_| \__ \ |_| |  | |_| |_  ./ /___ | |_) | |_| |>  < 
          \_|  \__,_|___/\__|_|   \__, (_) \_____/ |_.__/ \__,_/_/\_\
                                   __/ |                             
                                  |___/                              
                                  (Buy 3 Get 1 Free)
        ";



        Console.WriteLine(title);
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine(consoleBread);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(consolePastry);

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Come on bud I dont got all day. H'many breads ya want?");
        int breadQuantity = int.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("K, now pastries, chop chop");
        int pastryQuantity = int.Parse(Console.ReadLine());
        Bread newBread = new Bread(breadQuantity);
        Pastry newPastry = new Pastry(pastryQuantity);
        int breadPrice = newBread.GetBreadPrice(breadQuantity);
        int pastryPrice = newPastry.GetPastryPrice(pastryQuantity);
        int totalPrice = breadPrice + pastryPrice;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("K gimme $" + totalPrice + ". And move along");
      }
      catch (Exception ex)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Message = {0}", ex.Message);
        Console.WriteLine("Listen here you little brat, enter an actual number or you're getting a one way ticket to the rubber room");
        Console.ResetColor();
        Main();
      }
    }
  }
}

                                                                        
