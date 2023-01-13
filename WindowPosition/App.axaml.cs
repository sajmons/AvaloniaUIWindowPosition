using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Input;
using Avalonia.Markup.Xaml;

namespace WindowPosition
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow();

                desktop.MainWindow.KeyDown += (s, e) =>
                {
                    HandleMovement(desktop.MainWindow, e);
                };

                base.OnFrameworkInitializationCompleted();
            }
        }

        private void HandleMovement(Window window, KeyEventArgs e)
        {
            if (!e.Handled)
            {
                int x = window.Position.X;
                int y = window.Position.Y;
                int increment = 1;

                switch (e.Key)
                {
                    case Key.Up:
                        y -= increment;
                        e.Handled = true;
                        break;

                    case Key.Down:
                        y += increment;
                        e.Handled = true;
                        break;

                    case Key.Left:
                        x -= increment;
                        e.Handled = true;
                        break;
                    case Key.Right:
                        x += increment;
                        e.Handled = true;
                        break;
                }

                if (e.Handled)
                {
                    window.Position = new PixelPoint(x, y);
                }
            }
        }
    }
}