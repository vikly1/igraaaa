using System;
internal class Prog
{
    static void Main(string[] args)
    {
        Start();
        void Start()
        {
            Console.WriteLine("Приветик!");
            Console.WriteLine("Добро пожаловать в квест под названием 'Выживание на острове'");
            Console.WriteLine("Выбирайте правильные варианты ответов(вводите их номера), дабы не погибнуть");
            Console.WriteLine("Для выхода старта нажмите Enter, а для выхода любую другую клавишу.");
            var start = Console.ReadKey().Key;
            switch (start)
            {
                case ConsoleKey.Enter:
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Отлично! давайте выживать!!!:)");
                    StepOne();
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Ладьненько, прощайте!");
                    break;
            }
        }
        void StepOne()
        {
            Console.WriteLine();
            Console.WriteLine("Вы, позабыв все, что случилось, очнулись на берегу необитаемого острова, вокруг вас ничего нет, однако при себе имеются ножик, веревка и маленький топорик...");
            Console.WriteLine();
            var nextOne = Console.ReadLine();
            Console.WriteLine("Вы сильно хотите пить. Ваши действия:");
            Console.WriteLine("1 Сорвать кокос на рядом растущей пальме и проткнуть его с помощью ножика.");
            Console.WriteLine("2 Рискнуть, выйти в лес и попробовать найти источник пресной воды.");
            var StepOneSel = Console.ReadKey().Key;
            switch (StepOneSel)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("Вы лезете на дерево, срываете кокос, но срываетесь ввиду того, что недавно прошел дождь и древесина была скользкой");
                    Console.WriteLine("Вы погибли в связи с потерей сознания и внутреннего кровотечения...");
                    End();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("Вы пошли вглубь леса и, о чудо, нашли пресный источник воды.");
                    StepTwo();
                    break;
                default:
                    Console.WriteLine("Пожалуйста, выберите вариант ответа...");
                    StepOne();
                    break;
            }
        }
        void StepTwo()
        {
            Console.WriteLine();
            Console.WriteLine("Напившись кристально чистой воды и выйдя снова на побережье, Вы решаете:");
            Console.WriteLine();
            Console.WriteLine("1 Остаться и ждать помощи");
            Console.WriteLine("2 На скорую руку соорудить плот и попытаться покинуть это место");
            var StepTwoSel = Console.ReadKey().Key;
            switch (StepTwoSel)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("Верно! Вы дождались мимо проплывающего корабля, Вас заметили и спасли!!! Победа");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("Это была неудачная идея...");
                    Console.WriteLine("Благодаря мальенькому топорику вы срубили несколько бревен, а затем связали их с помощью веревки");
                    Console.WriteLine("Вы выплыли, думая, что плот выдержит, однако спустя полчаса он начал тонуть...");
                    End();
                    break;
                default:
                    Console.WriteLine("Пожалуйста, выберите вариант ответа...");
                    StepTwo();
                    break;

            }
        }
        void End()
        {
            Console.WriteLine();
            Console.WriteLine("Вы проиграли... не желаете начать заново?");
            Console.WriteLine();
            Console.WriteLine("нажмите enter для продолжения, или любую другую клавишу для выхода.");
            var Restart = Console.ReadKey().Key;
            switch (Restart)
            {
                case ConsoleKey.Enter:
                    Console.WriteLine("Отлично!!! Давайте начнем сначала!:)");
                    Console.WriteLine();
                    Start();
                    break;
            }
        }



    }
}