using Android.Views;

namespace AndroidApp;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    private int count = 0;
    private TextView textView = null!;
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        var linearLayout = new LinearLayout(this)
        {
            Orientation = Orientation.Vertical,
        };

        // Create and configure the TextView (equivalent of TextBlock in WPF)
        textView = new TextView(this)
        {
            Text = "Welcome to the Xamarin Android App!",
            TextSize = 24,
            Gravity = GravityFlags.Center
        };

        // Create and configure the Button
        var button = new Button(this)
        {
            Text = "Click Me",
            LayoutParameters = new LinearLayout.LayoutParams(200, 100)
        };

        // Set the click event for the button
        button.Click += (sender, e) =>
        {
            count++;
            textView.Text = $"Button clicked {count} times!";
        };

        // Add the TextView and Button to the layout
        linearLayout.AddView(textView);
        linearLayout.AddView(button);

        // Set the content view of the activity
        SetContentView(linearLayout);
    }
}