using System;
using Xamarin.Forms;
namespace Todo
{
    public class CustomCell : ViewCell
    {
        Image image = new Image();
        Label itemText = new Label();
        Label detailText = new Label();
        StackLayout wrapperStackLayout = new StackLayout();
        StackLayout innerStackLayout = new StackLayout();

        static ImageSource blinky = ImageSource.FromFile("blinky.png");
        static ImageSource clyde = ImageSource.FromFile("clyde.png");
        static ImageSource inky = ImageSource.FromFile("inky.png");
        static ImageSource pinky = ImageSource.FromFile("pinky.png");

        static ImageSource[] ghosts = { blinky, clyde, inky, pinky };

        public CustomCell()
        {

            //bindings
            //itemText.SetBinding(Label.TextProperty, "Text");
            //detailText.SetBinding(Label.TextProperty, "Detail");
            //image.SetBinding(Image.SourceProperty, "Image");

            //properties
            wrapperStackLayout.Orientation = StackOrientation.Horizontal;
            wrapperStackLayout.Padding = new Thickness(15, 0);
            innerStackLayout.Padding = new Thickness(15, 0);

            //add views
            innerStackLayout.Children.Add(itemText);
            innerStackLayout.Children.Add(detailText);
            wrapperStackLayout.Children.Add(image);
            wrapperStackLayout.Children.Add(innerStackLayout);

            View = wrapperStackLayout;
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            var item = BindingContext as TodoItem;

            if (BindingContext != null)
            {
                itemText.Text = item.Text;
                detailText.Text = item.Detail;

                //int randIndex = new Random().Next(4);
                //image.Source = ghosts[randIndex];
                image.Source = item.Image;
            }
        }
    }
}
