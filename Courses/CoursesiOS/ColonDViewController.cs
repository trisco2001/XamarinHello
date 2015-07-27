using System;
using System.Drawing;

using CoreFoundation;
using UIKit;
using Foundation;

namespace CoursesiOS
{
    [Register("UniversalView")]
    public class UniversalView : UIView
    {
        public UniversalView()
        {
            Initialize();
        }

        public UniversalView(RectangleF bounds) : base(bounds)
        {
            Initialize();
        }

        void Initialize()
        {
            BackgroundColor = UIColor.Red;
        }

        public override void TouchesEnded(NSSet touches, UIEvent evt)
        {
            base.TouchesEnded(touches, evt);
        }
    }

    [Register("ColonViewController")]
    public class ColonViewController : UIViewController
    {
        public ColonViewController(IntPtr p) : base(p)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            //View = new UniversalView();

            base.ViewDidLoad();

            // Perform any additional setup after loading the view
        }

        public override void TouchesEnded(NSSet touches, UIEvent evt)
        {
            this.DismissModalViewController(true);
        }
    }
}