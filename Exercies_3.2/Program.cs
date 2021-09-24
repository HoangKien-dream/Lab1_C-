using System;

namespace Exercies_3._2
{
    class Window
    {
        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }

        public virtual void DrawWindow()
        {
            Console.WriteLine("Window: drawing Window at {0}, {1}",top, left);
        }

        protected int top;
        protected int left;
    }

    class ListBox: Window
    {
        public ListBox(int top, int left, string content) : base(top, left)
        {
            listBoxContent = content;
        }

        public override void DrawWindow()
        {
            base.DrawWindow();
            Console.WriteLine("Writing string to the listbox: {0}", listBoxContent);
        }

        private string listBoxContent;
    }

    class Button: Window
    {
        public Button(int top, int left) : base(top, left)
        {
        }

        public override void DrawWindow()
        {
            Console.WriteLine("Drawing a button at {0}, {1}\n", top, left);
        }
    }
    
    
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Window window = new Window(1, 2);
            ListBox listBox = new ListBox(3, 4, "Stand alone list box");
            Button button = new Button(5, 6);
            window.DrawWindow();
            listBox.DrawWindow();
            button.DrawWindow();
            Window[] winArray = new Window[3];
            winArray[0] = new Window(1, 2);
            winArray[1] = new ListBox(3, 4, "list box in array");
            winArray[2] = new Button(5, 6);
            for (int i = 0; i < 3; i++)
            {
                winArray[i].DrawWindow();
            }

            Console.ReadLine();
        }
    }
}