using System.Collections.ObjectModel;
using System.Diagnostics;

namespace SimpleDashboard;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		AnimateText(380);
		WishLsts = new ObservableCollection<WishLish>();
		GetWishLish();
		//amount.Text = SelectedAm.ToString();
	}
    public ObservableCollection<WishLish> WishLsts { get; set; }
    public double SelectedAm { get; set; }
    [Obsolete]
    private void AnimateText(int v)
    {
		float value = (float)v;
		var stopwatch = new Stopwatch();
		stopwatch.Start();

		Device.StartTimer(TimeSpan.FromSeconds(1 / 100f), () =>
		{
			double t = stopwatch.Elapsed.TotalMilliseconds % 500 / 500;
			SelectedAm = Math.Floor(Math.Min(value, (float)(10 * t) + SelectedAm));

			if(SelectedAm>= (double)v)
            {
				stopwatch.Stop();
				
				return false;
            }
			amount.Text = SelectedAm.ToString();
			return true;
		});
    }

	void GetWishLish()
    {
		WishLsts.Add(new WishLish() { color = Colors.Blue, icon = "https://www.pngitem.com/pimgs/m/197-1974567_transportation-image-white-moving-truck-icon-hd-png.png", title = "Fashion" });
		WishLsts.Add(new WishLish() { color = Colors.Green, icon = "https://toppng.com/uploads/preview/phone-icon-white-contact-us-icon-transparent-white-11553435474tl7fefjrod.png", title = "Calls" });
		WishLsts.Add(new WishLish() { color = Colors.OrangeRed, icon = "https://media.gettyimages.com/vectors/red-call-icon-vector-id971654072?s=2048x2048", title = "Savings" });
		WishLsts.Add(new WishLish() { color = Colors.Red, icon = "https://cdn-icons-png.flaticon.com/512/5501/5501375.png", title = "Savings" });
		WishLsts.Add(new WishLish() { color = Colors.LightBlue, icon = "https://icons-for-free.com/download-icon-fuel+pump+icon-1320136427946720947_512.png", title = "Fuel" });

		wish.ItemsSource = WishLsts;
    }


}

public class WishLish
{
    public string icon { get; set; }
    public string title { get; set; }
    public Color color { get; set; }
}