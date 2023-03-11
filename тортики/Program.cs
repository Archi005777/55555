namespace тортики
{
    public class menu
    {
        private int startcol = 10, startrow = 5;
        private int newpos, lastpos;
        public List<string> coun = new();
      //  public List<string> couninfo = new();
        public int arrcont = 0;
        private void show()
        {
            Console.SetCursorPosition(startcol - 3, startrow - 3);
           // Console.WriteLine(Prov.curentpath);
            for (int i = 0; i < arrcont; i++)
            {
                Console.SetCursorPosition(startcol, startrow + i);
                Console.WriteLine(coun[i]);
            }
        }
        private void clearshow()
        {
            Console.SetCursorPosition(startcol - 3, startrow - 3);
            Console.WriteLine("                                                    ");

            for (int i = 0; i < arrcont; i++)
            {
                Console.SetCursorPosition(startcol + 50, startrow + i);
                Console.WriteLine("                                                                  ");
            }
        }

        private void showpos()
        {
            Console.SetCursorPosition(startcol - 3, startrow + lastpos);
            Console.Write(' ');

            Console.SetCursorPosition(startcol - 3, startrow + newpos);
            Console.Write('\u0010');

        }
        public int keyinfo()
        {
            ConsoleKeyInfo cki;
            Console.TreatControlCAsInput = true;
            int i = 0;
            do
            {
                cki = Console.ReadKey();
                switch (cki.Key)
                {
                    case ConsoleKey.UpArrow: i = 1; break;
                    case ConsoleKey.DownArrow: i = 2; break;
                    case ConsoleKey.LeftArrow: i = 3; break;
                    case ConsoleKey.RightArrow: i = 4; break;
                    case ConsoleKey.Escape: i = 5; break;
                    case ConsoleKey.Enter: i = 6; break;
                }
            } while (i == 0);
            return i;
        }
        public int main()
        {
            int i;
            show();
            showpos();
            do
            {
                i = keyinfo();
                if (i != 5) { lastpos = newpos; }
                switch (i)
                {
                    case 1: newpos--; break;
                    case 2: newpos++; break;
                        //case 5: newpos++; break;
                }
                if (newpos > arrcont - 1) { newpos = 0; }
                if (newpos < 0) { newpos = arrcont - 1; }
                showpos();/*
                if (i == 6)
                {
                }
                if (i == 5)
                {
                }*/


            } while ((i != 6)&&(i!=6));
            return newpos;

        }
    }

    public class cake
    {

        int finalcost = 0;

        public cake()
        {
            menu men = new menu();
            List<string> mainmenu = new List<string>() { "новый тортик", "сохранить", "выход" };
            men.coun = mainmenu;
            men.arrcont = 3;
            bool check = true;
            do
            {
                switch (men.main())
                {
                    case 0: newcake(); break;
                    case 1: savecake(); break;
                    case 2: check = false; break;
                }

            } while (check);
        }
        private void newcake() 
        {
            menu men = new menu();
            List<string> mainmenu = new List<string>() { "форма","размер","вкус","количество","глазурь","декор" };
            men.coun = mainmenu;
            men.arrcont = 6;
            bool check = true;
            do
            {
                switch (men.main())
                {
                    case 0: /*newcake()*/; break;
                    case 1: /*savecake()*/; break;
                    case 2: check = false; break;
                        
                }

            } while (check);

        }
        private void savecake() { }
        public void form() // форма
        {
                      //  enum forms { circle, star, rectangle }
        }

    class size // размер имеет значение
    {
        List<string> sizes = new List<string>() { "20x20", "30x30", "40x40" };
    }
    class zapor //вкус если что
    {
        enum zapoirs { orange, ananas, vanilla, biscuit }
    }
    class colvo // количество
    {
        int colvos = 0;
    }
    class glazur // глазурь мля
    {
        bool itis = false;

    }
    class decor // какой то декор
    {
        bool itis = false;

    }
}
internal class Program
    {
        static void Main(string[] args)
        {
            cake tort = new cake();
        }
    }
}
/*Необходимо реализовать программу по заказу тортов для условной кондитерской в консоли
Из функционала необходимо реализовать следующее:
•  Выбор торта должен быть реализован из нескольких пунктов - форма, размер, 
вкус, количество, глазурь и декор. 
•  Меню должно быть стрелочным
•  При нажатии Enter это меню должно переходить в дополнительное меню с выбором определенного вида
пункта. Внутри должно быть не менее трех пунктов. 
•  Должна быть возможность выхода их этого меню по нажатию клавиши Escape
•  Должен быть вывод суммарной цены и суммарного заказа
•  По окончанию заказа итоговый заказ и его стоимость должен быть сохранен в файл в формате,
представленный в текстовом файле "История заказов" (на видео ошибка, там нет сохранения цены).
Вместо значений, указанных в <>, должны быть значения из кода. Все заказы, сделанные в приложении,
должны сохраняться в этом файле. Расположение на ваш выбор
•  Должна быть возможность после оформления заказа сделать еще один заказ
Из структуры кода, необходимо реализовать следующее:
•  Необходимо создать отдельный класс для заказа. Внутри класса должен быть следующий функционал:
выбор пункта основного меню, выбор пункта дополнительного меню (ОДИН МЕТОД, НЕ НЕСКОЛЬКО ДЛЯ КАЖДОГО!)
, сохранение в файл. Остальные методы по желанию. Методы внутри класса заказа должны быть как 
приватными, так и публичными
•  Должен быть свой тип данных - подпункт меню (условно говоря, я нажимаю enter и у меня выводятся 
все подпункты меню. Подпункт хранит в себе описание и цену подпункта)
•  Внутри подпункта меню нужно создать конструктор, чтобы из кода можно было проще создавать объект 
этого меню */