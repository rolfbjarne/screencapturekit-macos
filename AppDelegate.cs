using ScreenCaptureKit;

namespace screencapture_macos;

[Register ("AppDelegate")]
public class AppDelegate : NSApplicationDelegate {
	public async override void DidFinishLaunching (NSNotification notification)
	{
		// Insert code here to initialize your application
		var test = await SCShareableContent.GetShareableContentAsync(false, true);
		foreach (var w in test.Windows)
		    Console.WriteLine("Window: " + w.Title);
	}

	public override void WillTerminate (NSNotification notification)
	{
		// Insert code here to tear down your application
	}
}
