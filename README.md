Your post describes an onboarding flow that takes the user through two preliminary screens before finally showing the main form. The problem is that you're seeing a flicker - briefly showing an unwanted form. And since you have a password protecting the main form contents, it's a fair and reasonable assumption that sensitive information could be revealed if the main form blinks on (even for a instant) before being authorized to do so.

The key to suppressing this is to override `SetVisibleCore` and prevent it from setting the base class visibility to `true` until your condition has been met.

```
protected override void SetVisibleCore(bool value)
{
    base.SetVisibleCore(value && OnboardingState == OnboardingState.Authorized);
}
```
___

Now you can run the `MainForm` of the app in the normal way, and it will no longer be even briefly visible while you do your onboarding sequence.

```
enum OnboardingState{Screen1, Screen2, Authorized, }

public partial class MainWindow : Form
{
    public MainWindow()
    {
        InitializeComponent();

        // IMPORTANT: Make sure that Handle is not null.
        _ = Handle;
        BeginInvoke(() => OnboardingState = OnboardingState.Screen1);
    }
    protected override void SetVisibleCore(bool value)
    {
        base.SetVisibleCore(value && OnboardingState == OnboardingState.Authorized);
    }

    // Respond to changes of the onboarding state
    // enum by showing the corresponding window.
    OnboardingState OnboardingState
    {
        get => _onboardingState;
        set
        {
            if (!Equals(_onboardingState, value))
            {
                _onboardingState = value;
                switch (_onboardingState)
                {
                    case OnboardingState.Screen1:
                        using (var dlg = new OnboardingForm1())
                        {
                            if (DialogResult.OK == dlg.ShowDialog(this))
                            {
                                OnboardingState = OnboardingState.Screen2;
                            }
                            else Close();
                        }
                        break;
                    case OnboardingState.Screen2:
                        using (var dlg = new OnboardingForm2())
                        {
                            if (DialogResult.OK == dlg.ShowDialog(this))
                            {
                                OnboardingState = OnboardingState.Authorized;
                            }
                            else Close();
                        }
                        break;
                    case OnboardingState.Authorized:
                        Show();
                        break;
                }
            }
        }
    }
    OnboardingState _onboardingState = (OnboardingState)(-1);
}
```

___

**First Screen**

```
public partial class OnboardingForm1 : Form
{
    public OnboardingForm1()
    {
        InitializeComponent();
        buttonLogin.Click += (sender, e) => DialogResult = DialogResult.OK;
    }
}
```

___

**Second Screen**

```
public partial class OnboardingForm2 : Form
{
    public OnboardingForm2()
    {
        InitializeComponent();
        Shown += (sender, e) => ActiveControl = null;
        textBoxUid.TextChanged += localUpdateVisibility;
        textBoxPswd.TextChanged += localUpdateVisibility;
        void localUpdateVisibility(object? sender, EventArgs e)
        {
            textBoxPswd.Visible = !string.IsNullOrWhiteSpace(textBoxUid.Text);
            buttonLogin.Visible = textBoxUid.Visible && !string.IsNullOrWhiteSpace(textBoxPswd.Text);
        }
        buttonLogin.Click += (sender, e) => DialogResult = DialogResult.OK;
    }
}
```

