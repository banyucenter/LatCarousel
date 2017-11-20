using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LatCarousel
{
	public partial class MainPage : ContentPage, INotifyPropertyChanged
	{
		public MainPage()
		{
			InitializeComponent();
			Title = "Welcome Carousel";

			MyDataSource = new List<CarouselData>() { new CarouselData() { Image="gambarone.jpg" },
                                                      new CarouselData() { Image="gambartwo.jpg" },
                                                      new CarouselData() { Image="gambarthree.jpg" },
													  new CarouselData() { Image="gambarfour.jpg" }
			};

            BindingContext = this;
		}

		public List<CarouselData> MyDataSource { get; set; }

		private int _position;
		public int Position { get { return _position; } set { _position = value; OnPropertyChanged(); } }
	}
}
