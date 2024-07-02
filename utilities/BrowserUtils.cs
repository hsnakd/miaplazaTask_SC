using System.Threading;

namespace csharp_cucumber_selenium_framework.utilities
{
    public static class BrowserUtils
    {
        /*
         * This method will accept int (in seconds) and execute Thread.Sleep for a given duration
         */
        public static void Sleep(int seconds)
        {
            seconds *= 1000; // convert seconds to milliseconds
            try
            {
                Thread.Sleep(seconds);
            }
            catch (ThreadInterruptedException)
            {
                // Handle interrupted exception if needed
            }
        }
    }
}