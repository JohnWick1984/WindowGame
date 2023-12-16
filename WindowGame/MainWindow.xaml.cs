using System.Windows;

namespace NumberGuesserWPF
{
    public partial class MainWindow : Window
    {
        private NumberGuesser game;

        public MainWindow()
        {
            InitializeComponent();
            game = new NumberGuesser();
            StartNewGame();
        }

        private void StartNewGame()
        {
            game.PlayGame();
            GuessText.Text = "Догадка: ";
        }

        private void GuessedButtonClick(object sender, RoutedEventArgs e)
        {
            GuessText.Text = $"Поздравляем! Вы угадали число {game.TargetNumber} за {game.Attempts} попыток.";
            DisableButtons();
        }

        private void NotGuessedButtonClick(object sender, RoutedEventArgs e)
        {
            GuessText.Text = $"Загаданное число: {game.TargetNumber}. Попробуйте еще раз.";
            DisableButtons();
        }

        private void RestartButtonClick(object sender, RoutedEventArgs e)
        {
            StartNewGame();
            EnableButtons();
        }

        private void DisableButtons()
        {
            // Деактивация кнопок "Угадал" и "Не угадал"
            GuessedButton.IsEnabled = false;
            NotGuessedButton.IsEnabled = false;
        }

        private void EnableButtons()
        {
            // Активация кнопок "Угадал" и "Не угадал"
            GuessedButton.IsEnabled = true;
            NotGuessedButton.IsEnabled = true;
        }
    }
}
