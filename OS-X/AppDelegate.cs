using AppKit;
using Foundation;

namespace OSX
{
    [Register("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {
        MainWindowController mainWindowController;

        public AppDelegate()
        {
        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            mainWindowController = new MainWindowController();
            mainWindowController.Window.MakeKeyAndOrderFront(this);
            mainWindowController.Window.StyleMask = NSWindowStyle.Titled | NSWindowStyle.Closable;
            mainWindowController.Window.Title = "Text to Soundboard";
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
    }
}
