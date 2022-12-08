using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPTemplateMethodProject
{
    abstract class WindowTemlate
    {
        string title;
        public WindowTemlate(string title = "Window")
        {
            this.title = title;
        }
        public virtual void Title(string title)
        {
            Console.WriteLine($"Создаем заголовок {title}");
        }
        public abstract void ScrollBars();
        public abstract void Show();
        public abstract void Content();

        public void CreateWindow()
        {
            Title(title);
            ScrollBars();
            Content();
            Show();
        }
    }

    internal class FormWindow : WindowTemlate
    {
        public FormWindow(string title = "Form Window") : base(title) { }
        public override void Content()
        {
            Console.WriteLine("Создаем контролы");
        }

        public override void ScrollBars()
        {
            Console.WriteLine("Создаем полосы прокрутки вертикальные");
        }

        public override void Show()
        {
            Console.WriteLine("Показываем окно формы");
        }
    }

    internal class GameWindow : WindowTemlate
    {
        public GameWindow(string title = "Game Window") : base(title) { }
        public override void Content()
        {
            Console.WriteLine("Создаем Опции игры");
            Console.WriteLine("Создаем Интерфейс игры");
        }

        public override void ScrollBars()
        {
            Console.WriteLine("Создаем полосы прокрутки горизонтальные");
        }

        public override void Show()
        {
            Console.WriteLine("Показываем окно игры");
        }
    }
}
