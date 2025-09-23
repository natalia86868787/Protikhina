using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Protikhina
{
    /// <summary>
    /// Interaction logic for capcha.xaml
    /// </summary>
    public partial class capcha : Window
    {
        private Button firstSelected;
        public capcha()
        {
            InitializeComponent();
            loadPuzzle();

        }

        private void loadPuzzle()
        {
            throw new NotImplementedException();
        }

        private void LoadPuzzle()
        {
            PuzzleGrid.Children.Clear();
            var pieces = Enumerable.Range(1, 4).ToList();

            var rnd = new Random();
            pieces = pieces.OrderBy(x => rnd.Next()).ToList();

            foreach (var i in pieces)
            {

                var img = new Image
                {
                    Source = new BitmapImage(new Uri($"Images/{i}.png", UriKind.Relative)),
                    Stretch = System.Windows.Media.Stretch.Fill,
                };
                var btn = new Button
                {
                    Content = img,
                    Tag = i,
                    Margin = new Thickness(2)
                };
                btn.Click += Piece_Click;
                PuzzleGrid.Children.Add(btn);
            }
        }

        private void Piece_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void CheckPuzzle()
        {
            bool correct = true;
            for (int i = 0; i < PuzzleGrid.Children.Count; i++)
            {
                var btn = PuzzleGrid.Children[i] as Button;
                if (btn != null)
                {
                    int expected = i + 1; //позиция
                    int actual = (int)btn.Tag;
                    if (expected != actual)
                    {
                        correct = false;
                        break;
                    }
                }
            }
            if (correct)
            {
                MessageBox.Show("Капча решена!");
            }
        }
        
    }
}
