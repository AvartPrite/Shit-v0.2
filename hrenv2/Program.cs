class Calendar{
    static string Menu => "Calendar v0.2 \n" +
        "1. Дата и время \n" +
        "2. Настройки ";
        
    static void Main(){
        string action, color;

        Console.WriteLine(Menu);
        
        do{
            action = Console.ReadLine();
            if (action == "1"){
                Console.WriteLine($"\n{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}\n{DateTime.Now.ToString("D")}");
            }
            else if (action == "2"){
                Console.WriteLine(@"Выберите цвет шрифта(цифра):
                1. Жёлтый          6. Тёмно-серый        11. Серый
                2. Синий           7. Тёмно-зелёный      12. Зелёный
                3. Голубой         8. Тёмно-фиолетовый   13. Красный
                4. Тёмно-синий     9. Тёмно-красный      14. Фиолетовый
                5. Тёмно-голубой   10. Тёмно-жёлтый      15. Чёрный");
                
                color = Console.ReadLine();
                
                Console.ForegroundColor = color switch{
                    "1" => ConsoleColor.Yellow,
                    "2" => ConsoleColor.Blue,
                    "3" => ConsoleColor.Cyan,
                    "4" => ConsoleColor.DarkBlue,
                    "5" => ConsoleColor.DarkCyan,
                    "6" => ConsoleColor.DarkGray,
                    "7" => ConsoleColor.DarkGreen,
                    "8" => ConsoleColor.DarkMagenta,
                    "9" => ConsoleColor.DarkRed,
                    "10" => ConsoleColor.DarkYellow,
                    "11" => ConsoleColor.Gray,
                    "12" => ConsoleColor.Green,
                    "13" => ConsoleColor.Red,
                    "14" => ConsoleColor.Magenta,
                    "15" => ConsoleColor.Black,
                    _ => ConsoleColor.White
                };
                Console.WriteLine(Menu);
            }
        }
        while(action != "Выход");
    }
    
    
}