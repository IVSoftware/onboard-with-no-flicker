namespace onboard_with_no_flicker
{
    enum OnboardingState{Screen1, Screen2, Authorized, }
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            // IMPORTANT: Make sure that Handle is not null.
            _ = Handle;
            BeginInvoke(() => OnboardingState = OnboardingState.Screen1);

            buttonLogout.Click += (sender, e) =>
            {
                Hide();
                OnboardingState = OnboardingState.Screen2;
            };
        }
        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(value && OnboardingState == OnboardingState.Authorized);
        }
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
                            using (var screen1 = new OnboardingForm1())
                            {
                                if (DialogResult.OK == screen1.ShowDialog(this))
                                {
                                    OnboardingState = OnboardingState.Screen2;
                                }
                                else Close();
                            }
                            break;
                        case OnboardingState.Screen2:
                            using (var screen1 = new OnboardingForm2())
                            {
                                if (DialogResult.OK == screen1.ShowDialog(this))
                                {
                                    OnboardingState = OnboardingState.Authorized;
                                }
                                else Close();
                            }
                            break;
                        case OnboardingState.Authorized:
                            SetVisibleCore(true);
                            break;
                    }
                }
            }
        }
        OnboardingState _onboardingState = (OnboardingState)(-1);
    }
}
