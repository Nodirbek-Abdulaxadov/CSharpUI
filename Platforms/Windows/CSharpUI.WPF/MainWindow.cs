using System.Windows;
using System.Windows.Controls;

namespace CSharpUI.WPF;

public class MainWindow : Window
{
    private int count = 0;
    private TextBlock counterLabel;

    public MainWindow()
    {
        // Set up the window
        Title = "Counter";
        Width = 300;
        Height = 200;

        var stackPanel = new StackPanel
        {
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center,
            Margin = new Thickness(20)
        };

        // Convert Razor Markup to WPF C#
        var header = new TextBlock
        {
            Text = "Counter",
            FontSize = 20,
            FontWeight = FontWeights.Bold,
            TextAlignment = TextAlignment.Center,
            Margin = new Thickness(0, 0, 0, 10)
        };
        counterLabel = new TextBlock
        {
            Text = "Current count: 0",
            FontSize = 16,
            Margin = new Thickness(0, 0, 0, 10)
        };

        stackPanel.Children.Add(header);
        stackPanel.Children.Add(counterLabel);

        // Initialize the button and event handler
        var incrementButton = new Button
        {
            Content = "Click me",
            Width = 100,
            Height = 30,
            HorizontalAlignment = HorizontalAlignment.Center
        };
        incrementButton.Click += IncrementButton_Click;

        stackPanel.Children.Add(incrementButton);
        Content = stackPanel;
    }

    private void IncrementButton_Click(object sender, RoutedEventArgs e)
    {
        count++;
        counterLabel.Text = $"Current count: {count}";
    }
}